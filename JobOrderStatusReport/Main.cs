using System;
using System.Drawing;
using System.Windows.Forms;
using JobOrderStatusReport.DTO;
using System.Collections.Generic;
using JobOrderStatusReport.MasterData;
using JobOrderStatusReport.Business.Abstract;

namespace JobOrderStatusReport
{
    public partial class Main : Form
    {
        private readonly IJobOrderService _jobOrderService;

        public Main(IJobOrderService jobOrderService)
        {
            InitializeComponent();
            _jobOrderService = jobOrderService;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DgvReportStatus.RowsDefaultCellStyle.BackColor = Color.Bisque;
            DgvReportStatus.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            DgvJobOrders.DataSource = MockData.GetJobOrders();
            DgvJobOrderStatus.DataSource = MockData.GetJobOrdersStatus();

            DgvJobOrderStatus.CurrentCell.Selected = false;
            GetAllJobReport();
        }

        private void BtnGetReport_Click(object sender, EventArgs e)
        {
            GetAllJobReport();
        }

        private void DgvJobOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DgvJobOrders.Rows[index];
            List<JobOrderByStatusDto> jobOrderByStatus = _jobOrderService.FillJobOrder(selectedRow);

            DgvReportStatus.DataSource = null;
            DgvReportStatus.DataSource = _jobOrderService.GetJobStatusTimeReport(jobOrderByStatus);
        }

        private void GetAllJobReport()
        {
            List<JobOrderByStatusDto> jobsByStatus = _jobOrderService.GetJobOrdersByStatus();
            DgvReportStatus.DataSource = _jobOrderService.GetJobStatusTimeReport(jobsByStatus);
            DgvReportStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DgvJobOrderStatus_SelectionChanged(object sender, EventArgs e)
        {
            DgvJobOrderStatus.CurrentCell.Selected = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}