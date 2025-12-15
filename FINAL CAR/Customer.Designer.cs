namespace FINAL_CAR
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            Slidebar = new Panel();
            button1 = new Button();
            btnProfile = new Button();
            btnPayment = new Button();
            btnBooking = new Button();
            btnVehicle = new Button();
            panel2 = new Panel();
            iconMaximize = new PictureBox();
            btnMenu = new PictureBox();
            iconRestorer = new PictureBox();
            iconMinimize = new PictureBox();
            iconClose = new PictureBox();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            Slidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconRestorer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconClose).BeginInit();
            SuspendLayout();
            // 
            // Slidebar
            // 
            Slidebar.BackColor = Color.Silver;
            Slidebar.Controls.Add(button1);
            Slidebar.Controls.Add(btnProfile);
            Slidebar.Controls.Add(btnPayment);
            Slidebar.Controls.Add(btnBooking);
            Slidebar.Controls.Add(btnVehicle);
            Slidebar.Dock = DockStyle.Left;
            Slidebar.Location = new Point(0, 0);
            Slidebar.MaximumSize = new Size(197, 650);
            Slidebar.MinimumSize = new Size(50, 650);
            Slidebar.Name = "Slidebar";
            Slidebar.Size = new Size(197, 650);
            Slidebar.TabIndex = 0;
            Slidebar.Paint += Slidebar_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(83, 30);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(0, 209);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(197, 58);
            btnProfile.TabIndex = 7;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(0, 273);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(197, 58);
            btnPayment.TabIndex = 6;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnBooking
            // 
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBooking.Location = new Point(0, 145);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(197, 58);
            btnBooking.TabIndex = 5;
            btnBooking.Text = "My Booking";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.FlatAppearance.BorderSize = 0;
            btnVehicle.FlatStyle = FlatStyle.Flat;
            btnVehicle.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVehicle.Location = new Point(0, 81);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Size = new Size(197, 58);
            btnVehicle.TabIndex = 2;
            btnVehicle.Text = "Vehicle";
            btnVehicle.UseVisualStyleBackColor = true;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconMaximize);
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(iconRestorer);
            panel2.Controls.Add(iconMinimize);
            panel2.Controls.Add(iconClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(197, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1103, 42);
            panel2.TabIndex = 1;
            // 
            // iconMaximize
            // 
            iconMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMaximize.Image = (Image)resources.GetObject("iconMaximize.Image");
            iconMaximize.Location = new Point(1038, 12);
            iconMaximize.Name = "iconMaximize";
            iconMaximize.Size = new Size(25, 25);
            iconMaximize.SizeMode = PictureBoxSizeMode.StretchImage;
            iconMaximize.TabIndex = 5;
            iconMaximize.TabStop = false;
            iconMaximize.Click += iconMaximize_Click;
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(3, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(35, 35);
            btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenu.TabIndex = 2;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // iconRestorer
            // 
            iconRestorer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconRestorer.Image = (Image)resources.GetObject("iconRestorer.Image");
            iconRestorer.Location = new Point(1007, 12);
            iconRestorer.Name = "iconRestorer";
            iconRestorer.Size = new Size(25, 25);
            iconRestorer.SizeMode = PictureBoxSizeMode.StretchImage;
            iconRestorer.TabIndex = 4;
            iconRestorer.TabStop = false;
            iconRestorer.Click += iconRestorer_Click;
            // 
            // iconMinimize
            // 
            iconMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimize.Image = (Image)resources.GetObject("iconMinimize.Image");
            iconMinimize.Location = new Point(976, 12);
            iconMinimize.Name = "iconMinimize";
            iconMinimize.Size = new Size(25, 25);
            iconMinimize.TabIndex = 3;
            iconMinimize.TabStop = false;
            iconMinimize.Click += iconMinimize_Click;
            // 
            // iconClose
            // 
            iconClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconClose.Image = (Image)resources.GetObject("iconClose.Image");
            iconClose.Location = new Point(1069, 12);
            iconClose.Name = "iconClose";
            iconClose.Size = new Size(25, 25);
            iconClose.TabIndex = 2;
            iconClose.TabStop = false;
            iconClose.Click += iconClose_Click;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(197, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 608);
            panel1.TabIndex = 2;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(Slidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            Slidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconRestorer).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Slidebar;
        private Panel panel2;
        private Button btnVehicle;
        private Button btnProfile;
        private Button btnPayment;
        private Button btnBooking;
        private PictureBox btnMenu;
        private PictureBox iconMaximize;
        private PictureBox iconRestorer;
        private PictureBox iconMinimize;
        private PictureBox iconClose;
        private System.Windows.Forms.Timer sideBarTimer;
        private Panel panel1;
        private Button button1;
    }
}