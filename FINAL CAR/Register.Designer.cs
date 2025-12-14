namespace FINAL_CAR
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPass = new TextBox();
            txtEmail = new TextBox();
            btnSignup = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(1071, 332);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(151, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1071, 389);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 27);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged_1;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(1071, 453);
            txtConfirmPass.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(151, 27);
            txtConfirmPass.TabIndex = 2;
            txtConfirmPass.TextChanged += txtConfirmPass_TextChanged_1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1071, 510);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 27);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged_1;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(1103, 565);
            btnSignup.Margin = new Padding(3, 4, 3, 4);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(86, 31);
            btnSignup.TabIndex = 4;
            btnSignup.Text = "Signup";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(927, 637);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1351, 743);
            Controls.Add(btnBack);
            Controls.Add(btnSignup);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPass;
        private TextBox txtEmail;
        private Button btnSignup;
        private Button btnBack;
    }
}