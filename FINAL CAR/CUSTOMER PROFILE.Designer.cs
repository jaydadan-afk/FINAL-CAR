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
            txtContact = new TextBox();
            DA = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            btnBooking = new Button();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(263, 119);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(156, 23);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 96);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(263, 156);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = "Contact Number:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(263, 188);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(156, 23);
            txtContact.TabIndex = 3;
            // 
            // DA
            // 
            DA.AutoSize = true;
            DA.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DA.Location = new Point(263, 228);
            DA.Name = "DA";
            DA.Size = new Size(44, 20);
            DA.TabIndex = 4;
            DA.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(263, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(156, 23);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(263, 293);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Adress:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(263, 316);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(156, 23);
            txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(218, 25);
            label4.Name = "label4";
            label4.Size = new Size(148, 31);
            label4.TabIndex = 8;
            label4.Text = "MY PROFILE";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(291, 425);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 38);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(534, 425);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 38);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBooking
            // 
            btnBooking.Location = new Point(936, 50);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(111, 38);
            btnBooking.TabIndex = 11;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // CUSTOMER_PROFILE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 608);
            Controls.Add(btnBooking);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(DA);
            Controls.Add(txtContact);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCustomerName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CUSTOMER_PROFILE";
            Text = "CUSTOMER_PROFILE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private Label label1;
        private Label label2;
        private TextBox txtContact;
        private Label DA;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private Button btnEdit;
        private Button btnSave;
        private Button btnBooking;
    }
}