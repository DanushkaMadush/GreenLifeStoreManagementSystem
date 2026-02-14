namespace GreenLifeStoreManagementSystem.Forms
{
    partial class Reports
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.groupBoxReportOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelControls = new System.Windows.Forms.TableLayoutPanel();
            this.labelReportType = new System.Windows.Forms.Label();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panelReport = new System.Windows.Forms.Panel();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.labelReportTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.groupBoxReportOptions.SuspendLayout();
            this.tableLayoutPanelControls.SuspendLayout();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelControls, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelReport, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.groupBoxReportOptions);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(10, 10);
            this.panelControls.Margin = new System.Windows.Forms.Padding(10);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(880, 100);
            this.panelControls.TabIndex = 0;
            // 
            // groupBoxReportOptions
            // 
            this.groupBoxReportOptions.Controls.Add(this.tableLayoutPanelControls);
            this.groupBoxReportOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxReportOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxReportOptions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxReportOptions.Name = "groupBoxReportOptions";
            this.groupBoxReportOptions.Size = new System.Drawing.Size(880, 100);
            this.groupBoxReportOptions.TabIndex = 0;
            this.groupBoxReportOptions.TabStop = false;
            this.groupBoxReportOptions.Text = "Report Options";
            // 
            // tableLayoutPanelControls
            // 
            this.tableLayoutPanelControls.ColumnCount = 6;
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanelControls.Controls.Add(this.labelReportType, 0, 0);
            this.tableLayoutPanelControls.Controls.Add(this.comboBoxReportType, 1, 0);
            this.tableLayoutPanelControls.Controls.Add(this.labelFromDate, 2, 0);
            this.tableLayoutPanelControls.Controls.Add(this.dateTimePickerFromDate, 3, 0);
            this.tableLayoutPanelControls.Controls.Add(this.labelToDate, 4, 0);
            this.tableLayoutPanelControls.Controls.Add(this.dateTimePickerToDate, 5, 0);
            this.tableLayoutPanelControls.Controls.Add(this.buttonGenerate, 1, 1);
            this.tableLayoutPanelControls.Controls.Add(this.buttonExport, 3, 1);
            this.tableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelControls.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelControls.Name = "tableLayoutPanelControls";
            this.tableLayoutPanelControls.RowCount = 2;
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelControls.Size = new System.Drawing.Size(874, 78);
            this.tableLayoutPanelControls.TabIndex = 0;
            // 
            // labelReportType
            // 
            this.labelReportType.AutoSize = true;
            this.labelReportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelReportType.Location = new System.Drawing.Point(3, 0);
            this.labelReportType.Name = "labelReportType";
            this.labelReportType.Size = new System.Drawing.Size(94, 35);
            this.labelReportType.TabIndex = 0;
            this.labelReportType.Text = "Report Type:";
            this.labelReportType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] {
            "Sales Report",
            "Stock Report",
            "Customer Order History",
            "Sales Report",
            "Order Status Report",
            "Product Performance Report",
            "Customer Orders Report",
            "Daily Sales Report",
            "Monthly Sales Report"});
            this.comboBoxReportType.Location = new System.Drawing.Point(103, 3);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(194, 23);
            this.comboBoxReportType.TabIndex = 1;
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelFromDate.Location = new System.Drawing.Point(303, 0);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(74, 35);
            this.labelFromDate.TabIndex = 2;
            this.labelFromDate.Text = "From Date:";
            this.labelFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(383, 3);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(114, 21);
            this.dateTimePickerFromDate.TabIndex = 3;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelToDate.Location = new System.Drawing.Point(503, 0);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(54, 35);
            this.labelToDate.TabIndex = 4;
            this.labelToDate.Text = "To Date:";
            this.labelToDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePickerToDate.Location = new System.Drawing.Point(563, 3);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(308, 21);
            this.dateTimePickerToDate.TabIndex = 5;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.buttonGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGenerate.ForeColor = System.Drawing.Color.White;
            this.buttonGenerate.Location = new System.Drawing.Point(103, 38);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(194, 37);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate Report";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(383, 38);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(114, 37);
            this.buttonExport.TabIndex = 7;
            this.buttonExport.Text = "Export to CSV";
            this.buttonExport.UseVisualStyleBackColor = false;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.dataGridViewReport);
            this.panelReport.Controls.Add(this.labelReportTitle);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(10, 130);
            this.panelReport.Margin = new System.Windows.Forms.Padding(10);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(880, 460);
            this.panelReport.TabIndex = 1;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReport.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReport.Size = new System.Drawing.Size(880, 425);
            this.dataGridViewReport.TabIndex = 1;
            // 
            // labelReportTitle
            // 
            this.labelReportTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelReportTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelReportTitle.ForeColor = System.Drawing.Color.White;
            this.labelReportTitle.Location = new System.Drawing.Point(0, 0);
            this.labelReportTitle.Name = "labelReportTitle";
            this.labelReportTitle.Size = new System.Drawing.Size(880, 35);
            this.labelReportTitle.TabIndex = 0;
            this.labelReportTitle.Text = "Report Results";
            this.labelReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green Life Store - Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.groupBoxReportOptions.ResumeLayout(false);
            this.tableLayoutPanelControls.ResumeLayout(false);
            this.tableLayoutPanelControls.PerformLayout();
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.GroupBox groupBoxReportOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControls;
        private System.Windows.Forms.Label labelReportType;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Label labelReportTitle;
    }
}