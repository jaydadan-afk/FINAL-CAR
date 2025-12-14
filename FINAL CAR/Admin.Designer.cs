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
            btnLogout = new Button();
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
            Slidebar.BackColor = Color.RosyBrown;
            Slidebar.Controls.Add(btnLogout);
            Slidebar.Controls.Add(btnPayment);
            Slidebar.Controls.Add(btnBooking);
            Slidebar.Controls.Add(btnCustomer);
            Slidebar.Controls.Add(btnVehicle);
            Slidebar.Dock = DockStyle.Left;
            Slidebar.Location = new Point(0, 0);
            Slidebar.MaximumSize = new Size(200, 611);
            Slidebar.MinimumSize = new Size(61, 611);
            Slidebar.Name = "Slidebar";
            Slidebar.Size = new Size(200, 611);
            Slidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(22, 23);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(81, 31);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button1_Click;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Location = new Point(9, 294);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(188, 56);
            btnPayment.TabIndex = 5;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnBooking
            // 
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Image = (Image)resources.GetObject("btnBooking.Image");
            btnBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooking.Location = new Point(9, 170);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(188, 56);
            btnBooking.TabIndex = 4;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(9, 232);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(188, 56);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.FlatAppearance.BorderSize = 0;
            btnVehicle.FlatStyle = FlatStyle.Flat;
            btnVehicle.Image = (Image)resources.GetObject("btnVehicle.Image");
            btnVehicle.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicle.Location = new Point(9, 108);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Size = new Size(188, 56);
            btnVehicle.TabIndex = 2;
            btnVehicle.Text = "Vehicle";
            btnVehicle.UseVisualStyleBackColor = true;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconRestorer);
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(iconMinimize);
            panel2.Controls.Add(iconMaximize);
            panel2.Controls.Add(iconClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 43);
            panel2.TabIndex = 1;
            // 
            // iconRestorer
            // 
            iconRestorer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconRestorer.Cursor = Cursors.Hand;
            iconRestorer.Image = (Image)resources.GetObject("iconRestorer.Image");
            iconRestorer.Location = new Point(1016, 12);
            iconRestorer.Name = "iconRestorer";
            iconRestorer.Size = new Size(25, 25);
            iconRestorer.SizeMode = PictureBoxSizeMode.StretchImage;
            iconRestorer.TabIndex = 9;
            iconRestorer.TabStop = false;
            iconRestorer.Click += iconRestorer_Click;
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(3, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(35, 35);
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
            iconMinimize.Location = new Point(985, 12);
            iconMinimize.Name = "iconMinimize";
            iconMinimize.Size = new Size(25, 25);
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
            iconMaximize.Location = new Point(1016, 12);
            iconMaximize.Name = "iconMaximize";
            iconMaximize.Size = new Size(25, 25);
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
            iconClose.Location = new Point(1047, 12);
            iconClose.Name = "iconClose";
            iconClose.Size = new Size(25, 25);
            iconClose.SizeMode = PictureBoxSizeMode.StretchImage;
            iconClose.TabIndex = 8;
            iconClose.TabStop = false;
            iconClose.Click += iconClose_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 43);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1084, 568);
            panelMain.TabIndex = 2;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 611);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(Slidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            Slidebar.ResumeLayout(false);
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
        private Button btnLogout;
    }
}