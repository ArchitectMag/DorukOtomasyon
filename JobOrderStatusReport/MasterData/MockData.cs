using System;
using System.Data;

namespace JobOrderStatusReport.MasterData
{
    public static class MockData
    {
        public static DataTable GetJobOrders()
        {
            DataTable jobOrdersTable = new DataTable();

            jobOrdersTable.Columns.Add(new DataColumn("JobOrderNo", typeof(int)));
            jobOrdersTable.Columns.Add(new DataColumn("JobStartDate", typeof(DateTime)));
            jobOrdersTable.Columns.Add(new DataColumn("JobEndDate", typeof(DateTime)));

            jobOrdersTable.Rows.Add(new object[] { 1001, Convert.ToDateTime("1.01.2017 08:00:00"), Convert.ToDateTime("1.01.2017 16:00:00") });
            jobOrdersTable.Rows.Add(new object[] { 1002, Convert.ToDateTime("1.01.2017 16:00:00"), Convert.ToDateTime("2.01.2017 00:00:00") });
            jobOrdersTable.Rows.Add(new object[] { 1003, Convert.ToDateTime("2.01.2017 00:00:00"), Convert.ToDateTime("2.01.2017 08:00:00") });
            jobOrdersTable.Rows.Add(new object[] { 1004, Convert.ToDateTime("2.01.2017 08:00:00"), Convert.ToDateTime("2.01.2017 16:00:00") });
            jobOrdersTable.Rows.Add(new object[] { 1005, Convert.ToDateTime("2.01.2017 16:00:00"), Convert.ToDateTime("3.01.2017 00:00:00") });
            jobOrdersTable.Rows.Add(new object[] { 1006, Convert.ToDateTime("3.01.2017 00:00:00"), Convert.ToDateTime("3.01.2017 08:00:00") });
            jobOrdersTable.Rows.Add(new object[] { 1007, Convert.ToDateTime("3.01.2017 08:00:00"), Convert.ToDateTime("3.01.2017 16:00:00") });
            jobOrdersTable.Rows.Add(new object[] { 1008, Convert.ToDateTime("3.01.2017 16:00:00"), Convert.ToDateTime("4.01.2017 00:00:00") });
            jobOrdersTable.Rows.Add(new object[] { 1009, Convert.ToDateTime("4.01.2017 00:00:00"), Convert.ToDateTime("4.01.2017 08:00:00") });

            return jobOrdersTable;
        }

        public static DataTable GetJobOrdersStatus()
        {
            DataTable jobOrdersStatusTable = new DataTable();

            jobOrdersStatusTable.Columns.Add(new DataColumn("JobStatus", typeof(string)));
            jobOrdersStatusTable.Columns.Add(new DataColumn("StatusStartDate", typeof(DateTime)));
            jobOrdersStatusTable.Columns.Add(new DataColumn("StatusEndDate", typeof(DateTime)));

            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("1.01.2017 10:00:00"), Convert.ToDateTime("1.01.2017 10:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Arıza", Convert.ToDateTime("1.01.2017 10:30:00"), Convert.ToDateTime("1.01.2017 11:00:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("1.01.2017 12:00:00"), Convert.ToDateTime("1.01.2017 12:30:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("1.01.2017 14:00:00"), Convert.ToDateTime("1.01.2017 14:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Setup", Convert.ToDateTime("1.01.2017 15:00:00"), Convert.ToDateTime("1.01.2017 16:30:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("1.01.2017 18:00:00"), Convert.ToDateTime("1.01.2017 18:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("1.01.2017 20:00:00"), Convert.ToDateTime("1.01.2017 20:30:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("1.01.2017 22:00:00"), Convert.ToDateTime("1.01.2017 22:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Arge", Convert.ToDateTime("1.01.2017 23:00:00"), Convert.ToDateTime("2.01.2017 08:30:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("2.01.2017 10:00:00"), Convert.ToDateTime("2.01.2017 10:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("2.01.2017 12:00:00"), Convert.ToDateTime("2.01.2017 12:30:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Arıza", Convert.ToDateTime("2.01.2017 13:00:00"), Convert.ToDateTime("2.01.2017 13:45:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("2.01.2017 14:00:00"), Convert.ToDateTime("2.01.2017 14:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("2.01.2017 18:00:00"), Convert.ToDateTime("2.01.2017 18:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Arge", Convert.ToDateTime("2.01.2017 20:00:00"), Convert.ToDateTime("3.01.2017 02:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("3.01.2017 04:00:00"), Convert.ToDateTime("3.01.2017 04:30:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Setup", Convert.ToDateTime("3.01.2017 06:00:00"), Convert.ToDateTime("3.01.2017 09:30:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("3.01.2017 10:00:00"), Convert.ToDateTime("3.01.2017 10:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("3.01.2017 12:00:00"), Convert.ToDateTime("3.01.2017 12:30:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("3.01.2017 14:00:00 "), Convert.ToDateTime("3.01.2017 14:10:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Arıza", Convert.ToDateTime("3.01.2017 15:00:00"), Convert.ToDateTime("3.01.2017 18:45:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("3.01.2017 20:00:00"), Convert.ToDateTime("3.01.2017 20:30:00") });
            jobOrdersStatusTable.Rows.Add(new object[] { "Mola", Convert.ToDateTime("3.01.2017 22:00:00"), Convert.ToDateTime("3.01.2017 22:10:00") });

            return jobOrdersStatusTable;
        }
    }
}