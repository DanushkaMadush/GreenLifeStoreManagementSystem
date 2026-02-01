namespace GreenLifeStoreManagementSystem
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label labelTitle;
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
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackToLogin;
        private System.Windows.Forms.Label labelValidation;

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
            this.panelRegister = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackToLogin = new System.Windows.Forms.Button();
            this.labelValidation = new System.Windows.Forms.Label();

            this.panelRegister.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelRegister.Size = new System.Drawing.Size(420, 540);
            this.panelRegister.Location = new System.Drawing.Point((1215 - 420) / 2, (600 - 540) / 2); // Centered
            this.panelRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRegister.Controls.Add(this.labelTitle);
            this.panelRegister.Controls.Add(this.labelFullName);
            this.panelRegister.Controls.Add(this.textBoxFullName);
            this.panelRegister.Controls.Add(this.labelUsername);
            this.panelRegister.Controls.Add(this.textBoxUsername);
            this.panelRegister.Controls.Add(this.labelEmail);
            this.panelRegister.Controls.Add(this.textBoxEmail);
            this.panelRegister.Controls.Add(this.labelPhone);
            this.panelRegister.Controls.Add(this.textBoxPhone);
            this.panelRegister.Controls.Add(this.labelAddress);
            this.panelRegister.Controls.Add(this.textBoxAddress);
            this.panelRegister.Controls.Add(this.labelPassword);
            this.panelRegister.Controls.Add(this.textBoxPassword);
            this.panelRegister.Controls.Add(this.labelConfirmPassword);
            this.panelRegister.Controls.Add(this.textBoxConfirmPassword);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.buttonClear);
            this.panelRegister.Controls.Add(this.buttonBackToLogin);
            this.panelRegister.Controls.Add(this.labelValidation);

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.labelTitle.Location = new System.Drawing.Point(60, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(300, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Create New Account";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFullName.Location = new System.Drawing.Point(40, 70);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(72, 19);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Full Name:";

            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxFullName.Location = new System.Drawing.Point(160, 67);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(210, 25);
            this.textBoxFullName.TabIndex = 2;

            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelUsername.Location = new System.Drawing.Point(40, 110);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(71, 19);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username:";

            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxUsername.Location = new System.Drawing.Point(160, 107);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(210, 25);
            this.textBoxUsername.TabIndex = 4;

            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelEmail.Location = new System.Drawing.Point(40, 150);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 19);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email:";

            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxEmail.Location = new System.Drawing.Point(160, 147);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(210, 25);
            this.textBoxEmail.TabIndex = 6;

            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPhone.Location = new System.Drawing.Point(40, 190);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(98, 19);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Phone Number:";

            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPhone.Location = new System.Drawing.Point(160, 187);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(210, 25);
            this.textBoxPhone.TabIndex = 8;

            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelAddress.Location = new System.Drawing.Point(40, 230);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 19);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address:";

            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxAddress.Location = new System.Drawing.Point(160, 227);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(210, 25);
            this.textBoxAddress.TabIndex = 10;

            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPassword.Location = new System.Drawing.Point(40, 270);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 19);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password:";

            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(160, 267);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(210, 25);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.UseSystemPasswordChar = true;

            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelConfirmPassword.Location = new System.Drawing.Point(40, 310);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(120, 19);
            this.labelConfirmPassword.TabIndex = 13;
            this.labelConfirmPassword.Text = "Confirm Password:";

            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(160, 307);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(210, 25);
            this.textBoxConfirmPassword.TabIndex = 14;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;

            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(40, 360);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(330, 32);
            this.buttonRegister.TabIndex = 15;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;

            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(40, 405);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(155, 32);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;

            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBackToLogin.BackColor = System.Drawing.Color.LightGray;
            this.buttonBackToLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonBackToLogin.Location = new System.Drawing.Point(215, 405);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(155, 32);
            this.buttonBackToLogin.TabIndex = 17;
            this.buttonBackToLogin.Text = "Back to Login";
            this.buttonBackToLogin.UseVisualStyleBackColor = false;

            // 
            // labelValidation
            // 
            this.labelValidation.AutoSize = true;
            this.labelValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelValidation.ForeColor = System.Drawing.Color.IndianRed;
            this.labelValidation.Location = new System.Drawing.Point(40, 460);
            this.labelValidation.Name = "labelValidation";
            this.labelValidation.Size = new System.Drawing.Size(0, 15);
            this.labelValidation.TabIndex = 18;

            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 600);
            this.Controls.Add(this.panelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}