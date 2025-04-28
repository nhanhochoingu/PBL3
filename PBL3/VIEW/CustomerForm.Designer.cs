using System.Windows.Forms;

namespace PBL3
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Title_panel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.but_Menu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sidebar = new System.Windows.Forms.Panel();
            this.but_Booking = new System.Windows.Forms.Button();
            this.but_TaiKhoan = new System.Windows.Forms.Button();
            this.but_DieuKhoan = new System.Windows.Forms.Button();
            this.but_Thoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title_panel.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_panel
            // 
            this.Title_panel.Controls.Add(this.Title);
            this.Title_panel.Location = new System.Drawing.Point(0, 0);
            this.Title_panel.Name = "Title_panel";
            this.Title_panel.Size = new System.Drawing.Size(982, 60);
            this.Title_panel.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Title.Location = new System.Drawing.Point(291, 2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(424, 53);
            this.Title.TabIndex = 0;
            this.Title.Text = "Managerment System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // but_Menu
            // 
            this.but_Menu.BackColor = System.Drawing.Color.DimGray;
            this.but_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Menu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.but_Menu.Location = new System.Drawing.Point(0, 0);
            this.but_Menu.Name = "but_Menu";
            this.but_Menu.Size = new System.Drawing.Size(60, 60);
            this.but_Menu.TabIndex = 3;
            this.but_Menu.Text = "≡";
            this.but_Menu.UseVisualStyleBackColor = false;
            this.but_Menu.Click += new System.EventHandler(this.but_Menu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(962, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DimGray;
            this.sidebar.Controls.Add(this.pictureBox5);
            this.sidebar.Controls.Add(this.but_Thoat);
            this.sidebar.Controls.Add(this.pictureBox4);
            this.sidebar.Controls.Add(this.but_DieuKhoan);
            this.sidebar.Controls.Add(this.pictureBox3);
            this.sidebar.Controls.Add(this.but_TaiKhoan);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Controls.Add(this.but_Booking);
            this.sidebar.Controls.Add(this.but_Menu);
            this.sidebar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.sidebar.Location = new System.Drawing.Point(0, 60);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(60, 485);
            this.sidebar.TabIndex = 2;
            // 
            // but_Booking
            // 
            this.but_Booking.BackColor = System.Drawing.Color.DimGray;
            this.but_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Booking.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.but_Booking.Location = new System.Drawing.Point(0, 56);
            this.but_Booking.Name = "but_Booking";
            this.but_Booking.Size = new System.Drawing.Size(60, 60);
            this.but_Booking.TabIndex = 4;
            this.but_Booking.Text = "Đặt Sân";
            this.but_Booking.UseVisualStyleBackColor = false;
            // 
            // but_TaiKhoan
            // 
            this.but_TaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_TaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.but_TaiKhoan.Location = new System.Drawing.Point(0, 116);
            this.but_TaiKhoan.Name = "but_TaiKhoan";
            this.but_TaiKhoan.Size = new System.Drawing.Size(60, 60);
            this.but_TaiKhoan.TabIndex = 6;
            this.but_TaiKhoan.Text = "Tài Khoản";
            this.but_TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // but_DieuKhoan
            // 
            this.but_DieuKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_DieuKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_DieuKhoan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.but_DieuKhoan.Location = new System.Drawing.Point(0, 176);
            this.but_DieuKhoan.Name = "but_DieuKhoan";
            this.but_DieuKhoan.Size = new System.Drawing.Size(60, 60);
            this.but_DieuKhoan.TabIndex = 7;
            this.but_DieuKhoan.Text = "Điều Khoản";
            this.but_DieuKhoan.UseVisualStyleBackColor = true;
            // 
            // but_Thoat
            // 
            this.but_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Thoat.Location = new System.Drawing.Point(0, 236);
            this.but_Thoat.Name = "but_Thoat";
            this.but_Thoat.Size = new System.Drawing.Size(60, 60);
            this.but_Thoat.TabIndex = 9;
            this.but_Thoat.Text = "Thoát";
            this.but_Thoat.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PBL3.Properties.Resources.the_door_1389755_1920;
            this.pictureBox5.Location = new System.Drawing.Point(3, 239);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PBL3.Properties.Resources.bookmark_97575_1920;
            this.pictureBox4.Location = new System.Drawing.Point(3, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox3.Image = global::PBL3.Properties.Resources.icon_2426371_1280;
            this.pictureBox3.Location = new System.Drawing.Point(3, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Title_panel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Title_panel.ResumeLayout(false);
            this.Title_panel.PerformLayout();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel Title_panel;
        private Label Title;
        private MenuStrip menuStrip1;
        private Panel sidebar;
        private PictureBox pictureBox1;
        private Button but_Booking;
        private Button but_Menu;
        private PictureBox pictureBox2;
        private Button but_TaiKhoan;
        private PictureBox pictureBox3;
        private Button but_DieuKhoan;
        private PictureBox pictureBox4;
        private Button but_Thoat;
        private PictureBox pictureBox5;
    }
}