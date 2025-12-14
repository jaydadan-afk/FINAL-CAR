namespace FINAL_CAR
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            Slidebar = new Panel();
            pictureBox1 = new PictureBox();
            btnPayment = new Button();
            btnBooking = new Button();
            btnCustomer = new Button();
            btnVehicle = new Button();
            panel2 = new Panel();
            iconRestorer = new PictureBox();
            btnMenu = new PictureBox();
            iconMinimize = new PictureBox();
            iconMaximize = new PictureBox();
            iconClose = new PictureBox();
            panelMain = new Panel();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            Slidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRestorer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconClose).BeginInit();
            SuspendLayout();
            // 
            // Slidebar
            // 
            Slidebar.BackColor = Color.Black;
            Slidebar.Controls.Add(pictureBox1);
            Slidebar.Controls.Add(btnPayment);
            Slidebar.Controls.Add(btnBooking);
            Slidebar.Controls.Add(btnCustomer);
            Slidebar.Controls.Add(btnVehicle);
            Slidebar.Dock = DockStyle.Left;
            Slidebar.Location = new Point(0, 0);
            Slidebar.Margin = new Padding(3, 4, 3, 4);
            Slidebar.MaximumSize = new Size(229, 815);
            Slidebar.MinimumSize = new Size(70, 815);
            Slidebar.Name = "Slidebar";
            Slidebar.Size = new Size(229, 815);
            Slidebar.TabIndex = 0;
            Slidebar.Paint += Slidebar_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPayment.ForeColor = Color.White;
            btnPayment.Image = (Image)resources.GetObject("btnPayment.Image");
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(8, 436);
            btnPayment.Margin = new Padding(3, 4, 3, 4);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(215, 75);
            btnPayment.TabIndex = 5;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnBooking
            // 
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBooking.ForeColor = Color.White;
            btnBooking.Image = (Image)resources.GetObject("btnBooking.Image");
            btnBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooking.Location = new Point(8, 240);
            btnBooking.Margin = new Padding(3, 4, 3, 4);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(215, 75);
            btnBooking.TabIndex = 4;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(8, 338);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(215, 75);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.FlatAppearance.BorderSize = 0;
            btnVehicle.FlatStyle = FlatStyle.Flat;
            btnVehicle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVehicle.ForeColor = Color.White;
            btnVehicle.Image = (Image)resources.GetObject("btnVehicle.Image");
            btnVehicle.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicle.Location = new Point(8, 145);
            btnVehicle.Margin = new Padding(3, 4, 3, 4);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Size = new Size(215, 75);
            btnVehicle.TabIndex = 2;
            btnVehicle.Text = "Vehicle";
            btnVehicle.UseVisualStyleBackColor = true;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(53, 53, 53);
            panel2.Controls.Add(iconRestorer);
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(iconMinimize);
            panel2.Controls.Add(iconMaximize);
            panel2.Controls.Add(iconClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(229, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1238, 49);
            panel2.TabIndex = 1;
            // 
            // iconRestorer
            // 
            iconRestorer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconRestorer.Cursor = Cursors.Hand;
            iconRestorer.Image = (Image)resources.GetObject("iconRestorer.Image");
            iconRestorer.Location = new Point(1160, 8);
            iconRestorer.Margin = new Padding(3, 4, 3, 4);
            iconRestorer.Name = "iconRestorer";
            iconRestorer.Size = new Size(29, 33);
            iconRestorer.SizeMode = PictureBoxSizeMode.StretchImage;
            iconRestorer.TabIndex = 9;
            iconRestorer.TabStop = false;
            iconRestorer.Click += iconRestorer_Click;
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(0, 4);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(40, 47);
            btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenu.TabIndex = 2;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // iconMinimize
            // 
            iconMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimize.Cursor = Cursors.Hand;
            iconMinimize.Image = (Image)resources.GetObject("iconMinimize.Image");
            iconMinimize.Location = new Point(1125, 8);
            iconMinimize.Margin = new Padding(3, 4, 3, 4);
            iconMinimize.Name = "iconMinimize";
            iconMinimize.Size = new Size(29, 33);
            iconMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            iconMinimize.TabIndex = 6;
            iconMinimize.TabStop = false;
            iconMinimize.Click += iconMinimize_Click;
            // 
            // iconMaximize
            // 
            iconMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMaximize.Cursor = Cursors.Hand;
            iconMaximize.Image = (Image)resources.GetObject("iconMaximize.Image");
            iconMaximize.Location = new Point(1160, 8);
            iconMaximize.Margin = new Padding(3, 4, 3, 4);
            iconMaximize.Name = "iconMaximize";
            iconMaximize.Size = new Size(29, 33);
            iconMaximize.SizeMode = PictureBoxSizeMode.StretchImage;
            iconMaximize.TabIndex = 7;
            iconMaximize.TabStop = false;
            iconMaximize.Click += iconMaximize_Click;
            // 
            // iconClose
            // 
            iconClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconClose.Cursor = Cursors.Hand;
            iconClose.Image = (Image)resources.GetObject("iconClose.Image");
            iconClose.Location = new Point(1195, 8);
            iconClose.Margin = new Padding(3, 4, 3, 4);
            iconClose.Name = "iconClose";
            iconClose.Size = new Size(29, 33);
            iconClose.SizeMode = PictureBoxSizeMode.StretchImage;
            iconClose.TabIndex = 8;
            iconClose.TabStop = false;
            iconClose.Click += iconClose_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(229, 49);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1238, 766);
            panelMain.TabIndex = 2;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 815);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(Slidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            Slidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconRestorer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Slidebar;
        private Button btnPayment;
        private Button btnBooking;
        private Button btnCustomer;
        private Button btnVehicle;
        private Panel panel2;
        private PictureBox btnMenu;
        private PictureBox iconRestorer;
        private PictureBox iconMinimize;
        private PictureBox iconMaximize;
        private PictureBox iconClose;
        private Panel panelMain;
        private System.Windows.Forms.Timer sideBarTimer;
        private PictureBox pictureBox1;
    }
}