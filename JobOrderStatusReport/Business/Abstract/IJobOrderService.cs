using System;
using System.Data;
using System.Windows.Forms;
using JobOrderStatusReport.DTO;
using System.Collections.Generic;

namespace JobOrderStatusReport.Business.Abstract
{
    public interface IJobOrderService
    {
        List<string> GetStatusName();

        List<JobOrderByStatusDto> FillJobOrder(DataGridViewRow dataRow);

        List<JobOrderByStatusDto> GetJobOrdersByStatus();

        DataTable GetJobStatusTimeReport(List<JobOrderByStatusDto> reportData);

        List<DataRow> GetFilterJobOrdersByStatus(DateTime startDate, DateTime endDate);
    }
}
