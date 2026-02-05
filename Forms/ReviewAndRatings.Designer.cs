namespace GreenLifeStoreManagementSystem.Forms
{
    partial class ReviewAndRatings
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewReviews;
        private System.Windows.Forms.Panel panelAddReview;
        private System.Windows.Forms.Label labelAddReview;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;

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
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            this.panelAddReview = new System.Windows.Forms.Panel();
            this.labelAddReview = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            this.panelAddReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Controls.Add(this.labelTitle);
            this.panelMainContainer.Controls.Add(this.comboBoxProduct);
            this.panelMainContainer.Controls.Add(this.buttonRefresh);
            this.panelMainContainer.Controls.Add(this.dataGridViewReviews);
            this.panelMainContainer.Controls.Add(this.panelAddReview);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(800, 450);
            this.panelMainContainer.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(275, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Product Reviews & Ratings";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxProduct.Location = new System.Drawing.Point(320, 25);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(220, 25);
            this.comboBoxProduct.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(560, 23);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(90, 28);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.AllowUserToAddRows = false;
            this.dataGridViewReviews.AllowUserToDeleteRows = false;
            this.dataGridViewReviews.AllowUserToResizeRows = false;
            this.dataGridViewReviews.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviews.Location = new System.Drawing.Point(30, 70);
            this.dataGridViewReviews.MultiSelect = false;
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.ReadOnly = true;
            this.dataGridViewReviews.RowHeadersVisible = false;
            this.dataGridViewReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReviews.Size = new System.Drawing.Size(620, 220);
            this.dataGridViewReviews.TabIndex = 3;
            // 
            // panelAddReview
            // 
            this.panelAddReview.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelAddReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.panelAddReview.Controls.Add(this.labelAddReview);
            this.panelAddReview.Controls.Add(this.labelRating);
            this.panelAddReview.Controls.Add(this.numericUpDownRating);
            this.panelAddReview.Controls.Add(this.labelComment);
            this.panelAddReview.Controls.Add(this.textBoxComment);
            this.panelAddReview.Controls.Add(this.buttonSubmit);
            this.panelAddReview.Controls.Add(this.buttonClear);
            this.panelAddReview.Location = new System.Drawing.Point(30, 310);
            this.panelAddReview.Name = "panelAddReview";
            this.panelAddReview.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelAddReview.Size = new System.Drawing.Size(620, 120);
            this.panelAddReview.TabIndex = 4;
            // 
            // labelAddReview
            // 
            this.labelAddReview.AutoSize = true;
            this.labelAddReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelAddReview.Location = new System.Drawing.Point(20, 10);
            this.labelAddReview.Name = "labelAddReview";
            this.labelAddReview.Size = new System.Drawing.Size(139, 21);
            this.labelAddReview.TabIndex = 0;
            this.labelAddReview.Text = "Add Your Review";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelRating.Location = new System.Drawing.Point(20, 45);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(51, 19);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "Rating:";
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownRating.Location = new System.Drawing.Point(80, 43);
            this.numericUpDownRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(50, 25);
            this.numericUpDownRating.TabIndex = 2;
            this.numericUpDownRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelComment.Location = new System.Drawing.Point(150, 45);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(73, 19);
            this.labelComment.TabIndex = 3;
            this.labelComment.Text = "Comment:";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxComment.Location = new System.Drawing.Point(230, 43);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(200, 50);
            this.textBoxComment.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(450, 43);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(70, 28);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(530, 43);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 28);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ReviewAndRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReviewAndRatings";
            this.Text = "ReviewAndRatings";
            this.panelMainContainer.ResumeLayout(false);
            this.panelMainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.panelAddReview.ResumeLayout(false);
            this.panelAddReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    }
}