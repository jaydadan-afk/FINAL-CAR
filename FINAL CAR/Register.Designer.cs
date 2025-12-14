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
            txtUsername.Location = new Point(511, 170);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(133, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(511, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(133, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged_1;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(511, 261);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(133, 23);
            txtConfirmPass.TabIndex = 2;
            txtConfirmPass.TextChanged += txtConfirmPass_TextChanged_1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(511, 304);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 23);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged_1;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(539, 345);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(75, 23);
            btnSignup.TabIndex = 4;
            btnSignup.Text = "Signup";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(385, 399);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSignup);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Register";
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