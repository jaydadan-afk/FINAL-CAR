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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            Slidebar = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            iconRestorer = new PictureBox();
            btnMenu = new PictureBox();
            iconMinimize = new PictureBox();
            iconMaximize = new PictureBox();
            iconClose = new PictureBox();
            panel1 = new Panel();
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
            Slidebar.Controls.Add(button4);
            Slidebar.Controls.Add(button3);
            Slidebar.Controls.Add(button2);
            Slidebar.Controls.Add(button1);
            Slidebar.Dock = DockStyle.Left;
            Slidebar.Location = new Point(0, 0);
            Slidebar.Name = "Slidebar";
            Slidebar.Size = new Size(200, 611);
            Slidebar.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(9, 294);
            button4.Name = "button4";
            button4.Size = new Size(188, 56);
            button4.TabIndex = 5;
            button4.Text = "Payment";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(9, 170);
            button3.Name = "button3";
            button3.Size = new Size(188, 56);
            button3.TabIndex = 4;
            button3.Text = "Booking";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(9, 232);
            button2.Name = "button2";
            button2.Size = new Size(188, 56);
            button2.TabIndex = 3;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(9, 108);
            button1.Name = "button1";
            button1.Size = new Size(188, 56);
            button1.TabIndex = 2;
            button1.Text = "Vehicle";
            button1.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 568);
            panel1.TabIndex = 2;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 611);
            Controls.Add(panel1);
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
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private PictureBox btnMenu;
        private PictureBox iconRestorer;
        private PictureBox iconMinimize;
        private PictureBox iconMaximize;
        private PictureBox iconClose;
        private Panel panel1;
    }
}