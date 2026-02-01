namespace GreenLifeStoreManagementSystem.Forms
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Panel panelWelcome;
        public System.Windows.Forms.Label labelWelcome;
        public System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelParagraph;
        private System.Windows.Forms.Label labelBullet1;
        private System.Windows.Forms.Label labelBullet2;
        private System.Windows.Forms.Label labelBullet3;
        private System.Windows.Forms.Label labelBullet4;

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
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelParagraph = new System.Windows.Forms.Label();
            this.labelBullet1 = new System.Windows.Forms.Label();
            this.labelBullet2 = new System.Windows.Forms.Label();
            this.labelBullet3 = new System.Windows.Forms.Label();
            this.labelBullet4 = new System.Windows.Forms.Label();
            this.panelMainContainer.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Controls.Add(this.labelTitle);
            this.panelMainContainer.Controls.Add(this.labelSubtitle);
            this.panelMainContainer.Controls.Add(this.panelWelcome);
            this.panelMainContainer.Controls.Add(this.panelContent);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(800, 450);
            this.panelMainContainer.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelTitle.Location = new System.Drawing.Point(206, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(415, 47);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "GreenLife Organic Store";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.labelSubtitle.Location = new System.Drawing.Point(193, 77);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(428, 25);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Organic & Eco-Friendly Products Management System";
            // 
            // panelWelcome
            // 
            this.panelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Controls.Add(this.labelRole);
            this.panelWelcome.Location = new System.Drawing.Point(43, 126);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(407, 72);
            this.panelWelcome.TabIndex = 2;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelWelcome.Location = new System.Drawing.Point(10, 4);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(240, 30);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome, [Username]";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.DimGray;
            this.labelRole.Location = new System.Drawing.Point(11, 39);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(100, 20);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Role: [Admin]";
            // 
            // panelContent
            // 
            this.panelContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.panelContent.Controls.Add(this.labelParagraph);
            this.panelContent.Controls.Add(this.labelBullet1);
            this.panelContent.Controls.Add(this.labelBullet2);
            this.panelContent.Controls.Add(this.labelBullet3);
            this.panelContent.Controls.Add(this.labelBullet4);
            this.panelContent.Location = new System.Drawing.Point(43, 188);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelContent.Size = new System.Drawing.Size(500, 220);
            this.panelContent.TabIndex = 3;
            // 
            // labelParagraph
            // 
            this.labelParagraph.AutoSize = true;
            this.labelParagraph.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParagraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.labelParagraph.Location = new System.Drawing.Point(9, 25);
            this.labelParagraph.MaximumSize = new System.Drawing.Size(480, 0);
            this.labelParagraph.Name = "labelParagraph";
            this.labelParagraph.Size = new System.Drawing.Size(444, 60);
            this.labelParagraph.TabIndex = 0;
            this.labelParagraph.Text = "Welcome to GreenLife Organic Store Management System. This platform helps you man" +
    "age and explore a wide range of organic, eco-friendly products with ease.";
            // 
            // labelBullet1
            // 
            this.labelBullet1.AutoSize = true;
            this.labelBullet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBullet1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelBullet1.Location = new System.Drawing.Point(30, 113);
            this.labelBullet1.Name = "labelBullet1";
            this.labelBullet1.Size = new System.Drawing.Size(183, 20);
            this.labelBullet1.TabIndex = 1;
            this.labelBullet1.Text = "• Browse organic products";
            // 
            // labelBullet2
            // 
            this.labelBullet2.AutoSize = true;
            this.labelBullet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBullet2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelBullet2.Location = new System.Drawing.Point(30, 138);
            this.labelBullet2.Name = "labelBullet2";
            this.labelBullet2.Size = new System.Drawing.Size(165, 20);
            this.labelBullet2.TabIndex = 2;
            this.labelBullet2.Text = "• Place and track orders";
            // 
            // labelBullet3
            // 
            this.labelBullet3.AutoSize = true;
            this.labelBullet3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBullet3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelBullet3.Location = new System.Drawing.Point(30, 161);
            this.labelBullet3.Name = "labelBullet3";
            this.labelBullet3.Size = new System.Drawing.Size(235, 20);
            this.labelBullet3.TabIndex = 3;
            this.labelBullet3.Text = "• Manage products and customers";
            // 
            // labelBullet4
            // 
            this.labelBullet4.AutoSize = true;
            this.labelBullet4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBullet4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelBullet4.Location = new System.Drawing.Point(30, 185);
            this.labelBullet4.Name = "labelBullet4";
            this.labelBullet4.Size = new System.Drawing.Size(130, 20);
            this.labelBullet4.TabIndex = 4;
            this.labelBullet4.Text = "• Generate reports";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panelMainContainer.ResumeLayout(false);
            this.panelMainContainer.PerformLayout();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}