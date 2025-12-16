namespace FINAL_CAR
{
    partial class CUSTOMERS
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
            dgvCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 30);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "CUSTOMER";
            label1.Click += label1_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AllowUserToResizeRows = false;
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(35, 63);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Size = new Size(843, 357);
            dgvCustomer.TabIndex = 39;
            // 
            // CUSTOMERS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 486);
            Controls.Add(dgvCustomer);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CUSTOMERS";
            Text = "CUSTOMERS";
            Load += CUSTOMERS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCustomer;
    }
}