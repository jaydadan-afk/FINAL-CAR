namespace FINAL_CAR
{
    partial class CUSTOMER_BOOKING
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
            label1 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            txtContact = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            datePickup = new DateTimePicker();
            label8 = new Label();
            dateTime = new DateTimePicker();
            label9 = new Label();
            comboCar = new ComboBox();
            btnConfirm = new Button();
            txtAddress = new TextBox();
            numericDays = new NumericUpDown();
            txtAmount = new TextBox();
            label11 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericDays).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 0;
            label1.Text = "BOOKING";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(253, 90);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(202, 23);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(181, 91);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 2;
            label2.Text = "Name :";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(253, 136);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(202, 23);
            txtContact.TabIndex = 3;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(185, 179);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 4;
            label3.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(253, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 23);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(179, 137);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 7;
            label4.Text = "Phone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(164, 280);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 12;
            label6.Text = "Select Car:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F);
            label7.Location = new Point(179, 229);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 13;
            label7.Text = "Adress :";
            // 
            // datePickup
            // 
            datePickup.Format = DateTimePickerFormat.Short;
            datePickup.Location = new Point(703, 91);
            datePickup.Name = "datePickup";
            datePickup.Size = new Size(131, 23);
            datePickup.TabIndex = 14;
            datePickup.ValueChanged += datePickup_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F);
            label8.Location = new Point(593, 91);
            label8.Name = "label8";
            label8.Size = new Size(95, 17);
            label8.TabIndex = 15;
            label8.Text = "Pickup Date :";
            // 
            // dateTime
            // 
            dateTime.Format = DateTimePickerFormat.Time;
            dateTime.Location = new Point(703, 140);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(131, 23);
            dateTime.TabIndex = 16;
            dateTime.ValueChanged += dateTime_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F);
            label9.Location = new Point(593, 140);
            label9.Name = "label9";
            label9.Size = new Size(96, 17);
            label9.TabIndex = 18;
            label9.Text = "Pickup Time :";
            // 
            // comboCar
            // 
            comboCar.FormattingEnabled = true;
            comboCar.Location = new Point(253, 279);
            comboCar.Name = "comboCar";
            comboCar.Size = new Size(202, 23);
            comboCar.TabIndex = 22;
            comboCar.SelectedIndexChanged += comboCar_SelectedIndexChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(737, 315);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 37);
            btnConfirm.TabIndex = 23;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(253, 230);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(202, 23);
            txtAddress.TabIndex = 24;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // numericDays
            // 
            numericDays.Location = new Point(703, 193);
            numericDays.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDays.Name = "numericDays";
            numericDays.Size = new Size(202, 23);
            numericDays.TabIndex = 25;
            numericDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericDays.ValueChanged += numericDays_ValueChanged;
            // 
            // txtAmount
            // 
            txtAmount.ForeColor = Color.Red;
            txtAmount.Location = new Point(703, 245);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(202, 23);
            txtAmount.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F);
            label11.Location = new Point(626, 246);
            label11.Name = "label11";
            label11.Size = new Size(62, 17);
            label11.TabIndex = 27;
            label11.Text = "Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(597, 195);
            label5.Name = "label5";
            label5.Size = new Size(96, 17);
            label5.TabIndex = 28;
            label5.Text = " Rental Days:";
            // 
            // CUSTOMER_BOOKING
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 571);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(txtAmount);
            Controls.Add(numericDays);
            Controls.Add(txtAddress);
            Controls.Add(btnConfirm);
            Controls.Add(comboCar);
            Controls.Add(label9);
            Controls.Add(dateTime);
            Controls.Add(label8);
            Controls.Add(datePickup);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtContact);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CUSTOMER_BOOKING";
            Text = "CUSTOMER_BOOKING";
            Activated += CUSTOMER_BOOKING_Activated;
            Load += CUSTOMER_BOOKING_Load;
            ((System.ComponentModel.ISupportInitialize)numericDays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerName;
        private Label label2;
        private TextBox txtContact;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Label label6;
        private Label label7;
        private DateTimePicker datePickup;
        private Label label8;
        private DateTimePicker dateTime;
        private Label label9;
        private ComboBox comboCar;
        private Button btnConfirm;
        private TextBox txtAddress;
        private NumericUpDown numericDays;
        private TextBox txtAmount;
        private Label label11;
        private Label label5;
    }
}