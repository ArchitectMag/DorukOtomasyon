using System.Drawing;
using System.Windows.Forms;

namespace JobOrderStatusReport
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnGetReport = new System.Windows.Forms.Button();
            this.DgvJobOrders = new System.Windows.Forms.DataGridView();
            this.DgvReportStatus = new System.Windows.Forms.DataGridView();
            this.DgvJobOrderStatus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReportStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrderStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetReport
            // 
            this.BtnGetReport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnGetReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGetReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGetReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGetReport.Location = new System.Drawing.Point(30, 804);
            this.BtnGetReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGetReport.Name = "BtnGetReport";
            this.BtnGetReport.Size = new System.Drawing.Size(940, 53);
            this.BtnGetReport.TabIndex = 0;
            this.BtnGetReport.Text = "Tüm Rapor Getir";
            this.BtnGetReport.UseVisualStyleBackColor = false;
            this.BtnGetReport.Click += new System.EventHandler(this.BtnGetReport_Click);
            // 
            // DgvJobOrders
            // 
            this.DgvJobOrders.AllowUserToAddRows = false;
            this.DgvJobOrders.AllowUserToDeleteRows = false;
            this.DgvJobOrders.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvJobOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJobOrders.Location = new System.Drawing.Point(30, 62);
            this.DgvJobOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvJobOrders.Name = "DgvJobOrders";
            this.DgvJobOrders.ReadOnly = true;
            this.DgvJobOrders.RowHeadersWidth = 51;
            this.DgvJobOrders.RowTemplate.Height = 29;
            this.DgvJobOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvJobOrders.Size = new System.Drawing.Size(431, 288);
            this.DgvJobOrders.TabIndex = 1;
            this.DgvJobOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJobOrders_CellClick);
            // 
            // DgvReportStatus
            // 
            this.DgvReportStatus.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvReportStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvReportStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReportStatus.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvReportStatus.Location = new System.Drawing.Point(30, 379);
            this.DgvReportStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvReportStatus.Name = "DgvReportStatus";
            this.DgvReportStatus.RowHeadersWidth = 51;
            this.DgvReportStatus.RowTemplate.Height = 29;
            this.DgvReportStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReportStatus.Size = new System.Drawing.Size(940, 410);
            this.DgvReportStatus.TabIndex = 4;
            // 
            // DgvJobOrderStatus
            // 
            this.DgvJobOrderStatus.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvJobOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvJobOrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJobOrderStatus.Location = new System.Drawing.Point(510, 62);
            this.DgvJobOrderStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvJobOrderStatus.Name = "DgvJobOrderStatus";
            this.DgvJobOrderStatus.RowHeadersWidth = 51;
            this.DgvJobOrderStatus.RowTemplate.Height = 29;
            this.DgvJobOrderStatus.Size = new System.Drawing.Size(460, 288);
            this.DgvJobOrderStatus.TabIndex = 5;
            this.DgvJobOrderStatus.SelectionChanged += new System.EventHandler(this.DgvJobOrderStatus_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "İş Emirleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(510, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duraksamalar";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1018, 890);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvJobOrderStatus);
            this.Controls.Add(this.DgvReportStatus);
            this.Controls.Add(this.DgvJobOrders);
            this.Controls.Add(this.BtnGetReport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReportStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrderStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnGetReport;
        private DataGridView DgvJobOrders;
        private DataGridView DgvReportStatus;
        private DataGridView DgvJobOrderStatus;
        private Label label1;
        private Label label2;
    }
}

