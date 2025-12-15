namespace FINAL_CAR
{
    partial class CUSTOMER_PAYMENT
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
            dgvPayment = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colCar = new DataGridViewTextBoxColumn();
            colDays = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            panel1 = new Panel();
            btnConfirmPayment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 29);
            label1.TabIndex = 0;
            label1.Text = "PAYMENT";
            label1.Click += label1_Click;
            // 
            // dgvPayment
            // 
            dgvPayment.AllowUserToDeleteRows = false;
            dgvPayment.AllowUserToResizeRows = false;
            dgvPayment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayment.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvPayment.BorderStyle = BorderStyle.None;
            dgvPayment.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Columns.AddRange(new DataGridViewColumn[] { colName, colContact, colEmail, colAddress, colCar, colDays, colDate, colTime, colAmount, Status });
            dgvPayment.Location = new Point(-39, 3);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.Size = new Size(843, 357);
            dgvPayment.TabIndex = 38;
            dgvPayment.CellContentClick += dgvPayment_CellContentClick;
            // 
            // colName
            // 
            colName.HeaderText = "Customer Name";
            colName.Name = "colName";
            // 
            // colContact
            // 
            colContact.HeaderText = "Contact";
            colContact.Name = "colContact";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Address";
            colAddress.Name = "colAddress";
            // 
            // colCar
            // 
            colCar.HeaderText = "Car Type";
            colCar.Name = "colCar";
            // 
            // colDays
            // 
            colDays.HeaderText = "Rented Days";
            colDays.Name = "colDays";
            // 
            // colDate
            // 
            colDate.HeaderText = "Pickup Date";
            colDate.Name = "colDate";
            // 
            // colTime
            // 
            colTime.HeaderText = "Pickup Time";
            colTime.Name = "colTime";
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Total Amount";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(608, 468);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 40);
            btnEdit.TabIndex = 39;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvPayment);
            panel1.Location = new Point(132, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 355);
            panel1.TabIndex = 41;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.Location = new Point(745, 468);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(96, 40);
            btnConfirmPayment.TabIndex = 42;
            btnConfirmPayment.Text = "Confirm";
            btnConfirmPayment.UseVisualStyleBackColor = true;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            // 
            // CUSTOMER_PAYMENT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 534);
            Controls.Add(btnConfirmPayment);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnEdit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CUSTOMER_PAYMENT";
            Text = "CUSTOMER_PAYMENT";
            Load += CUSTOMER_PAYMENT_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPayment;
        private Button btnEdit;
        private Panel panel1;
        private Button btnConfirmPayment;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colCar;
        private DataGridViewTextBoxColumn colDays;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn Status;
    }
}