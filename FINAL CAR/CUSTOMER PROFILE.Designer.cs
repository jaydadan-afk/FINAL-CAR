namespace FINAL_CAR
{
    partial class CUSTOMER_PROFILE
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
            txtCustomerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNumber = new TextBox();
            DA = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = SystemColors.ControlLight;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Location = new Point(181, 75);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(156, 16);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 78);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 128);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Phone Number:";
            // 
            // txtNumber
            // 
            txtNumber.BackColor = SystemColors.ControlLight;
            txtNumber.BorderStyle = BorderStyle.None;
            txtNumber.Location = new Point(181, 128);
            txtNumber.Name = "txtNumber";
            txtNumber.ReadOnly = true;
            txtNumber.Size = new Size(156, 16);
            txtNumber.TabIndex = 3;
            txtNumber.TextChanged += txtNumber_TextChanged;
            // 
            // DA
            // 
            DA.AutoSize = true;
            DA.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DA.Location = new Point(103, 175);
            DA.Name = "DA";
            DA.Size = new Size(44, 20);
            DA.TabIndex = 4;
            DA.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(181, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(156, 16);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 226);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Adress:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ControlLight;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Location = new Point(181, 230);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(156, 16);
            txtAddress.TabIndex = 7;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 12);
            label4.Name = "label4";
            label4.Size = new Size(148, 31);
            label4.TabIndex = 8;
            label4.Text = "MY PROFILE";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(132, 388);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 26);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(284, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 26);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(DA);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(318, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 453);
            panel1.TabIndex = 12;
            // 
            // CUSTOMER_PROFILE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1103, 608);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CUSTOMER_PROFILE";
            Text = "CUSTOMER_PROFILE";
            Load += CUSTOMER_PROFILE_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCustomerName;
        private Label label1;
        private Label label2;
        private TextBox txtNumber;
        private Label DA;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private Button btnEdit;
        private Button btnSave;
        private Panel panel1;
    }
}