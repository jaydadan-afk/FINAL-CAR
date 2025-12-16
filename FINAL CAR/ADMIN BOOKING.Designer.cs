namespace FINAL_CAR
{
    partial class BOOKINGS
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
            dgvAdminBooking = new DataGridView();
            BtnConfirm = new Button();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdminBooking).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 24);
            label1.TabIndex = 2;
            label1.Text = "CUSTOMER BOOKINGS";
            // 
            // dgvAdminBooking
            // 
            dgvAdminBooking.AllowUserToDeleteRows = false;
            dgvAdminBooking.AllowUserToResizeRows = false;
            dgvAdminBooking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdminBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminBooking.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvAdminBooking.BorderStyle = BorderStyle.None;
            dgvAdminBooking.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvAdminBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminBooking.Location = new Point(82, 57);
            dgvAdminBooking.Name = "dgvAdminBooking";
            dgvAdminBooking.Size = new Size(843, 357);
            dgvAdminBooking.TabIndex = 39;
            dgvAdminBooking.CellContentClick += dgvPayment_CellContentClick;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Location = new Point(438, 442);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(97, 40);
            BtnConfirm.TabIndex = 40;
            BtnConfirm.Text = "Confirm";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(569, 442);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(89, 40);
            BtnDelete.TabIndex = 41;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BOOKINGS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 533);
            Controls.Add(BtnDelete);
            Controls.Add(BtnConfirm);
            Controls.Add(dgvAdminBooking);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BOOKINGS";
            Text = "BOOKINGS";
            Load += BOOKINGS_Load;
            Shown += BOOKINGS_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvAdminBooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvAdminBooking;
        private Button BtnConfirm;
        private Button BtnDelete;
    }
}