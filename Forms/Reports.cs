using GreenLifeStoreManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeStoreManagementSystem.Forms
{
    public partial class Reports : Form
    {
        private ReportsRepository reportsRepository;

        public Reports()
        {
            InitializeComponent();
            reportsRepository = new ReportsRepository();
            InitializeForm();
            WireEvents();
        }

        private void InitializeForm()
        {
            dateTimePickerFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerToDate.Value = DateTime.Now;
            comboBoxReportType.Items.Clear();
            comboBoxReportType.Items.AddRange(new object[] {
                    "Sales Report",
                    "Stock Report",
                    "Customer Order History"
                });

            comboBoxReportType.SelectedIndex = 0;
            dataGridViewReport.DataSource = null;
            labelReportTitle.Text = "Select report type and click Generate Report";
        }

        private void WireEvents()
        {
            buttonGenerate.Click += ButtonGenerate_Click;
            buttonExport.Click += ButtonExport_Click;
            comboBoxReportType.SelectedIndexChanged += ComboBoxReportType_SelectedIndexChanged;
        }

        private void ComboBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewReport.DataSource = null;
            labelReportTitle.Text = $"{comboBoxReportType.SelectedItem} - Click Generate Report";
            if (comboBoxReportType.SelectedItem?.ToString() == "Customer Order History")
            {
                ShowCustomerIdInput();
            }
            else
            {
                HideCustomerIdInput();
            }
        }

        private void ShowCustomerIdInput()
        {
            if (tableLayoutPanelControls.GetControlFromPosition(6, 0) == null)
            {
                Label labelCustomerId = new Label()
                {
                    Text = "Customer ID:",
                    AutoSize = true,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    Font = new Font("Microsoft Sans Serif", 9F)
                };

                TextBox textBoxCustomerId = new TextBox()
                {
                    Name = "textBoxCustomerId",
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    Font = new Font("Microsoft Sans Serif", 9F)
                };

                tableLayoutPanelControls.Controls.Add(labelCustomerId, 6, 0);
                tableLayoutPanelControls.Controls.Add(textBoxCustomerId, 7, 0);

                if (tableLayoutPanelControls.ColumnCount < 8)
                {
                    tableLayoutPanelControls.ColumnCount = 8;
                    tableLayoutPanelControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
                    tableLayoutPanelControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
                }
            }
        }

        private void HideCustomerIdInput()
        {
            Control labelCustomerId = tableLayoutPanelControls.GetControlFromPosition(6, 0);
            Control textBoxCustomerId = tableLayoutPanelControls.GetControlFromPosition(7, 0);

            if (labelCustomerId != null)
            {
                tableLayoutPanelControls.Controls.Remove(labelCustomerId);
                labelCustomerId.Dispose();
            }

            if (textBoxCustomerId != null)
            {
                tableLayoutPanelControls.Controls.Remove(textBoxCustomerId);
                textBoxCustomerId.Dispose();
            }
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxReportType.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.", "No Report Type Selected",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePickerFromDate.Value > dateTimePickerToDate.Value)
            {
                MessageBox.Show("From date cannot be greater than To date.", "Invalid Date Range",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string reportType = comboBoxReportType.SelectedItem.ToString();
                DateTime fromDate = dateTimePickerFromDate.Value;
                DateTime toDate = dateTimePickerToDate.Value;

                GenerateReport(reportType, fromDate, toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReport(string reportType, DateTime fromDate, DateTime toDate)
        {
            dataGridViewReport.DataSource = null;
            dataGridViewReport.Columns.Clear();

            switch (reportType)
            {
                case "Sales Report":
                    GenerateSalesReport(fromDate, toDate);
                    break;
                case "Stock Report":
                    GenerateStockReport();
                    break;
                case "Customer Order History":
                    GenerateCustomerOrderHistoryReport();
                    break;
            }
        }

        private void GenerateSalesReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable salesData = reportsRepository.GetSalesReport(fromDate, toDate);

                if (salesData != null && salesData.Rows.Count > 0)
                {
                    dataGridViewReport.DataSource = salesData;
                    if (dataGridViewReport.Columns["OrderDate"] != null)
                    {
                        dataGridViewReport.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }

                    if (dataGridViewReport.Columns["TotalAmount"] != null)
                    {
                        dataGridViewReport.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
                    }

                    labelReportTitle.Text = $"Sales Report ({fromDate:dd/MM/yyyy} - {toDate:dd/MM/yyyy}) - {salesData.Rows.Count} records";
                }
                else
                {
                    labelReportTitle.Text = $"Sales Report ({fromDate:dd/MM/yyyy} - {toDate:dd/MM/yyyy}) - No data found";
                    MessageBox.Show("No sales data found for the selected date range.", "No Data",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating sales report: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelReportTitle.Text = "Error generating Sales Report";
            }
        }

        private void GenerateStockReport()
        {
            try
            {
                DataTable stockData = reportsRepository.GetStockReport();

                if (stockData != null && stockData.Rows.Count > 0)
                {
                    dataGridViewReport.DataSource = stockData;

                    if (dataGridViewReport.Columns["Discount"] != null)
                    {
                        dataGridViewReport.Columns["Discount"].DefaultCellStyle.Format = "P2";
                    }

                    labelReportTitle.Text = $"Stock Report - {stockData.Rows.Count} products";
                }
                else
                {
                    labelReportTitle.Text = "Stock Report - No data found";
                    MessageBox.Show("No stock data found.", "No Data",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating stock report: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelReportTitle.Text = "Error generating Stock Report";
            }
        }

        private void GenerateCustomerOrderHistoryReport()
        {
            try
            {
                TextBox textBoxCustomerId = tableLayoutPanelControls.GetControlFromPosition(7, 0) as TextBox;

                if (textBoxCustomerId == null || string.IsNullOrWhiteSpace(textBoxCustomerId.Text))
                {
                    MessageBox.Show("Please enter a Customer ID.", "Customer ID Required",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxCustomerId.Text, out int customerId))
                {
                    MessageBox.Show("Please enter a valid Customer ID (numeric).", "Invalid Customer ID",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable customerOrderData = reportsRepository.GetCustomerOrderHistory(customerId);

                if (customerOrderData != null && customerOrderData.Rows.Count > 0)
                {
                    dataGridViewReport.DataSource = customerOrderData;

                    if (dataGridViewReport.Columns["OrderDate"] != null)
                    {
                        dataGridViewReport.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }

                    if (dataGridViewReport.Columns["TotalAmount"] != null)
                    {
                        dataGridViewReport.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
                    }

                    labelReportTitle.Text = $"Customer Order History (Customer ID: {customerId}) - {customerOrderData.Rows.Count} orders";
                }
                else
                {
                    labelReportTitle.Text = $"Customer Order History (Customer ID: {customerId}) - No orders found";
                    MessageBox.Show($"No order history found for Customer ID: {customerId}.", "No Data",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating customer order history report: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelReportTitle.Text = "Error generating Customer Order History Report";
            }
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export. Please generate a report first.", "No Data",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Export Report to CSV";
            saveFileDialog.FileName = $"{comboBoxReportType.SelectedItem?.ToString().Replace(" ", "_")}_{DateTime.Now:yyyyMMdd}.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToCSV(saveFileDialog.FileName);
                    MessageBox.Show("Report exported successfully!", "Export Complete",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting report: {ex.Message}", "Export Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToCSV(string fileName)
        {
            StringBuilder csv = new StringBuilder();

            var headers = dataGridViewReport.Columns.Cast<DataGridViewColumn>()
                .Select(column => column.HeaderText);
            csv.AppendLine(string.Join(",", headers));

            foreach (DataGridViewRow row in dataGridViewReport.Rows)
            {
                if (!row.IsNewRow)
                {
                    var fields = row.Cells.Cast<DataGridViewCell>()
                        .Select(cell => $"\"{cell.Value?.ToString()?.Replace("\"", "\"\"")}\"");
                    csv.AppendLine(string.Join(",", fields));
                }
            }

            File.WriteAllText(fileName, csv.ToString(), Encoding.UTF8);
        }
    }
}
