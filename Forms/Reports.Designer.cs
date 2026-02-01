namespace GreenLifeStoreManagementSystem.Forms
{
    partial class Reports
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Button buttonExportCsv;
        private System.Windows.Forms.Button buttonExportPdf;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.buttonExportCsv = new System.Windows.Forms.Button();
            this.buttonExportPdf = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panelMainContainer.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Controls.Add(this.labelTitle);
            this.panelMainContainer.Controls.Add(this.comboBoxReportType);
            this.panelMainContainer.Controls.Add(this.buttonGenerate);
            this.panelMainContainer.Controls.Add(this.labelFrom);
            this.panelMainContainer.Controls.Add(this.dateTimePickerFrom);
            this.panelMainContainer.Controls.Add(this.labelTo);
            this.panelMainContainer.Controls.Add(this.dateTimePickerTo);
            this.panelMainContainer.Controls.Add(this.dataGridViewReport);
            this.panelMainContainer.Controls.Add(this.buttonExportCsv);
            this.panelMainContainer.Controls.Add(this.buttonExportPdf);
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(900, 600);
            this.panelMainContainer.TabIndex = 0;

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Reports";

            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportType.Items.AddRange(new object[] {
                    "Sales Report",
                    "Stock Report",
                    "Customer Order History"
                });
            this.comboBoxReportType.Location = new System.Drawing.Point(160, 27);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(200, 25);
            this.comboBoxReportType.TabIndex = 1;

            // 
            // buttonGenerate
            // 
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.buttonGenerate.ForeColor = System.Drawing.Color.White;
            this.buttonGenerate.Location = new System.Drawing.Point(380, 25);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(110, 28);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;

            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFrom.Location = new System.Drawing.Point(520, 30);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(41, 19);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "From:";

            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(570, 27);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(110, 25);
            this.dateTimePickerFrom.TabIndex = 4;

            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTo.Location = new System.Drawing.Point(700, 30);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(27, 19);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "To:";

            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(740, 27);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(110, 25);
            this.dateTimePickerTo.TabIndex = 6;

            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToResizeRows = false;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(30, 70);
            this.dataGridViewReport.MultiSelect = false;
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReport.Size = new System.Drawing.Size(820, 420);
            this.dataGridViewReport.TabIndex = 7;
            // Columns (add in code-behind for clarity)

            // 
            // buttonExportCsv
            // 
            this.buttonExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportCsv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonExportCsv.BackColor = System.Drawing.Color.LightGray;
            this.buttonExportCsv.ForeColor = System.Drawing.Color.Black;
            this.buttonExportCsv.Location = new System.Drawing.Point(570, 510);
            this.buttonExportCsv.Name = "buttonExportCsv";
            this.buttonExportCsv.Size = new System.Drawing.Size(130, 36);
            this.buttonExportCsv.TabIndex = 8;
            this.buttonExportCsv.Text = "Export to CSV";
            this.buttonExportCsv.UseVisualStyleBackColor = false;

            // 
            // buttonExportPdf
            // 
            this.buttonExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonExportPdf.BackColor = System.Drawing.Color.LightGray;
            this.buttonExportPdf.ForeColor = System.Drawing.Color.Black;
            this.buttonExportPdf.Location = new System.Drawing.Point(720, 510);
            this.buttonExportPdf.Name = "buttonExportPdf";
            this.buttonExportPdf.Size = new System.Drawing.Size(130, 36);
            this.buttonExportPdf.TabIndex = 9;
            this.buttonExportPdf.Text = "Export to PDF";
            this.buttonExportPdf.UseVisualStyleBackColor = false;

            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panelMainContainer.ResumeLayout(false);
            this.panelMainContainer.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}