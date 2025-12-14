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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(453, 39);
            label1.Name = "label1";
            label1.Size = new Size(108, 29);
            label1.TabIndex = 0;
            label1.Text = "PAYMENT";
            // 
            // CUSTOMER_PAYMENT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 534);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CUSTOMER_PAYMENT";
            Text = "CUSTOMER_PAYMENT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}