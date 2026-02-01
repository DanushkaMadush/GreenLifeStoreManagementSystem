namespace GreenLifeStoreManagementSystem.Forms
{
    partial class Profile
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button buttonUpdate;
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();

            this.panelMainContainer.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Controls.Add(this.labelTitle);
            this.panelMainContainer.Controls.Add(this.panelForm);
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(600, 500);
            this.panelMainContainer.TabIndex = 0;

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "My Profile";

            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(245, 250, 245);
            this.panelForm.Location = new System.Drawing.Point(30, 70);
            this.panelForm.Size = new System.Drawing.Size(540, 400);
            this.panelForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelForm.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelForm.Controls.Add(this.labelFullName);
            this.panelForm.Controls.Add(this.textBoxFullName);
            this.panelForm.Controls.Add(this.labelUsername);
            this.panelForm.Controls.Add(this.textBoxUsername);
            this.panelForm.Controls.Add(this.labelEmail);
            this.panelForm.Controls.Add(this.textBoxEmail);
            this.panelForm.Controls.Add(this.labelPhone);
            this.panelForm.Controls.Add(this.textBoxPhone);
            this.panelForm.Controls.Add(this.labelAddress);
            this.panelForm.Controls.Add(this.textBoxAddress);
            this.panelForm.Controls.Add(this.labelPassword);
            this.panelForm.Controls.Add(this.textBoxPassword);
            this.panelForm.Controls.Add(this.labelConfirmPassword);
            this.panelForm.Controls.Add(this.textBoxConfirmPassword);
            this.panelForm.Controls.Add(this.buttonUpdate);
            this.panelForm.Controls.Add(this.buttonClear);

            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFullName.Location = new System.Drawing.Point(30, 20);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(72, 19);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full Name:";

            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxFullName.Location = new System.Drawing.Point(180, 17);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(300, 25);
            this.textBoxFullName.TabIndex = 1;

            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelUsername.Location = new System.Drawing.Point(30, 55);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(71, 19);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";

            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxUsername.Location = new System.Drawing.Point(180, 52);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(300, 25);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.ReadOnly = true;

            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelEmail.Location = new System.Drawing.Point(30, 90);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 19);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";

            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxEmail.Location = new System.Drawing.Point(180, 87);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(300, 25);
            this.textBoxEmail.TabIndex = 5;

            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPhone.Location = new System.Drawing.Point(30, 125);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(98, 19);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone Number:";

            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPhone.Location = new System.Drawing.Point(180, 122);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(300, 25);
            this.textBoxPhone.TabIndex = 7;

            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelAddress.Location = new System.Drawing.Point(30, 160);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 19);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address:";

            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxAddress.Location = new System.Drawing.Point(180, 157);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(300, 25);
            this.textBoxAddress.TabIndex = 9;

            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPassword.Location = new System.Drawing.Point(30, 195);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 19);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password:";

            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(180, 192);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(300, 25);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.UseSystemPasswordChar = true;

            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelConfirmPassword.Location = new System.Drawing.Point(30, 230);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(120, 19);
            this.labelConfirmPassword.TabIndex = 12;
            this.labelConfirmPassword.Text = "Confirm Password:";

            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(180, 227);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(300, 25);
            this.textBoxConfirmPassword.TabIndex = 13;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;

            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(180, 270);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 32);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update Profile";
            this.buttonUpdate.UseVisualStyleBackColor = false;

            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(340, 270);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(140, 32);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;

            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.panelMainContainer.ResumeLayout(false);
            this.panelMainContainer.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}