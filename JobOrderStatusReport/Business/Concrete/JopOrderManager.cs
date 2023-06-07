using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using JobOrderStatusReport.DTO;
using System.Collections.Generic;
using JobOrderStatusReport.Helpers;
using JobOrderStatusReport.MasterData;
using JobOrderStatusReport.Business.Abstract;

namespace JobOrderStatusReport.Business.Concrete
{
    public class JopOrderManager : IJobOrderService
    {
        public List<string> GetStatusName()
        {
            List<string> columnList = new List<string>();

            foreach (DataRow jobOrder in MockData.GetJobOrdersStatus().Rows)
            {
                if (!columnList.Contains(jobOrder[0]))
                {
                    columnList.Add(jobOrder[0].ToString());
                }
            }

            return columnList.OrderBy(o => o).ToList();
        }

        public List<JobOrderByStatusDto> FillJobOrder(DataGridViewRow dataRow)
        {
            List<JobOrderByStatusDto> jobOrderByStatus = new List<JobOrderByStatusDto>();

            jobOrderByStatus.Add(new JobOrderByStatusDto
            {
                JobOrderNo = Convert.ToInt32(dataRow.Cells[0].Value.ToString()),
                JobStartDate = Convert.ToDateTime(dataRow.Cells[1].Value.ToString()),
                JobEndDate = Convert.ToDateTime(dataRow.Cells[2].Value.ToString()),
                JobOrdersByStatus = GetFilterJobOrdersByStatus(Convert.ToDateTime(dataRow.Cells[1].Value.ToString()), Convert.ToDateTime(dataRow.Cells[2].Value.ToString()))
            });

            return jobOrderByStatus;
        }

        public List<JobOrderByStatusDto> GetJobOrdersByStatus()
        {
            List<JobOrderByStatusDto> drList = new List<JobOrderByStatusDto>();

            foreach (DataRow jobOrder in MockData.GetJobOrders().Rows)
            {
                int jobOrderNo = Convert.ToInt32(jobOrder["JobOrderNo"].ToString());
                DateTime jobStartDate = Convert.ToDateTime(jobOrder["JobStartDate"]);
                DateTime jobEndDate = Convert.ToDateTime(jobOrder["JobEndDate"]);

                var filterJobOrdersByStatus = GetFilterJobOrdersByStatus(jobStartDate, jobEndDate);
                drList.Add(new JobOrderByStatusDto()
                {
                    JobOrderNo = jobOrderNo,
                    JobStartDate = jobStartDate,
                    JobEndDate = jobEndDate,
                    JobOrdersByStatus = filterJobOrdersByStatus
                });
            }
            return drList;
        }

        public DataTable GetJobStatusTimeReport(List<JobOrderByStatusDto> reportData)
        {
            DataTable jobOrdersStatusReportTable = new DataTable();

            jobOrdersStatusReportTable.Columns.Add(new DataColumn("JobOrderNo", typeof(int)));
            foreach (string statuName in GetStatusName())
            {
                jobOrdersStatusReportTable.Columns.Add(new DataColumn(statuName, typeof(int)));
            }
            jobOrdersStatusReportTable.Columns.Add(new DataColumn("Toplam", typeof(int)));

            if (reportData != null)
            {
                foreach (JobOrderByStatusDto jobOrder in reportData)
                {

                    var reportDataObject = new ReportDto();
                    reportDataObject.JobOrderNumber = jobOrder.JobOrderNo;
                    foreach (var jobOrderStatus in jobOrder.JobOrdersByStatus)
                    {
                        var minute = 0;
                        TimeSpan time;

                        string statusName = jobOrderStatus["JobStatus"].ToString();
                        DateTime statusStartDate = Convert.ToDateTime(jobOrderStatus["StatusStartDate"]);
                        DateTime statusEndDate = Convert.ToDateTime(jobOrderStatus["StatusEndDate"]);

                        if (statusStartDate >= jobOrder.JobStartDate)
                        {
                            if (statusEndDate >= jobOrder.JobEndDate)
                            {
                                time = jobOrder.JobEndDate - statusStartDate;
                                minute = DateTimeHelper.CalculateTotalMunite(time);
                            }
                            else
                            {
                                time = statusEndDate - statusStartDate;
                                minute = DateTimeHelper.CalculateTotalMunite(time);
                            }
                        }
                        else
                        {
                            statusStartDate = jobOrder.JobStartDate;
                            if (statusEndDate >= jobOrder.JobEndDate)
                            {
                                time = jobOrder.JobEndDate - statusStartDate;
                                minute = DateTimeHelper.CalculateTotalMunite(time);
                            }
                            else
                            {
                                time = statusEndDate - statusStartDate;
                                minute = DateTimeHelper.CalculateTotalMunite(time);
                            }
                        }

                        reportDataObject.TotalMinutes += minute;
                        var existStatus = reportDataObject.StatusDurations.FirstOrDefault(r => r.StatusName == statusName);

                        if (existStatus != null)
                        {
                            existStatus.StatusTime += minute;
                        }
                        else
                        {
                            reportDataObject.StatusDurations.Add(new StatusDurationDto
                            {
                                StatusName = statusName,
                                StatusTime = minute
                            });
                        }
                    }

                    object[] dataRow = new object[GetStatusName().Count + 2];
                    dataRow[0] = jobOrder.JobOrderNo;
                    for (int i = 0; i < GetStatusName().Count; i++)
                    {
                        if (reportDataObject.StatusDurations.Any(s => s.StatusName == GetStatusName()[i]))
                        {

                            dataRow[i + 1] = reportDataObject.StatusDurations.First(s => s.StatusName == GetStatusName()[i]).StatusTime;
                        }
                        else
                        {
                            dataRow[i + 1] = 0;
                        }
                    }

                    dataRow[GetStatusName().Count + 1] = reportDataObject.TotalMinutes;
                    jobOrdersStatusReportTable.Rows.Add(dataRow);

                }
            }

            return jobOrdersStatusReportTable;
        }

        public List<DataRow> GetFilterJobOrdersByStatus(DateTime startDate, DateTime endDate)
        {
            return MockData.GetJobOrdersStatus().Select().Where(x => Convert.ToDateTime(x["StatusStartDate"]) <= endDate &&
                                                                     Convert.ToDateTime(x["StatusEndDate"]) >= startDate).ToList();
        }
    }
}