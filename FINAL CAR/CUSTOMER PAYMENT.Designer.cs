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
            panel1 = new Panel();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 29);
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
            dgvPayment.Location = new Point(-39, 0);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.Size = new Size(843, 357);
            dgvPayment.TabIndex = 38;
            dgvPayment.CellContentClick += dgvPayment_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvPayment);
            panel1.Location = new Point(132, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 355);
            panel1.TabIndex = 41;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(509, 461);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 40);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CUSTOMER_PAYMENT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 534);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CUSTOMER_PAYMENT";
            Text = "CUSTOMER_PAYMENT";
            Activated += CUSTOMER_PAYMENT_Activated;
            Load += CUSTOMER_PAYMENT_Load_1;
            Shown += CUSTOMER_PAYMENT_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPayment;
        private Panel panel1;
        private Button btnDelete;
    }
}