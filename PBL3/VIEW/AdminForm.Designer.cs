namespace PBL3
{
    partial class AdminForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Title_panel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.but_Booking = new System.Windows.Forms.Button();
            this.but_Menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title_panel.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Title_panel
            // 
            this.Title_panel.Controls.Add(this.Title);
            this.Title_panel.Location = new System.Drawing.Point(0, 0);
            this.Title_panel.Name = "Title_panel";
            this.Title_panel.Size = new System.Drawing.Size(982, 60);
            this.Title_panel.TabIndex = 1;
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
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DimGray;
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Controls.Add(this.but_Booking);
            this.sidebar.Controls.Add(this.but_Menu);
            this.sidebar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(60, 653);
            this.sidebar.TabIndex = 2;
            // 
            // but_Booking
            // 
            this.but_Booking.BackColor = System.Drawing.Color.DimGray;
            this.but_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Booking.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.but_Booking.Location = new System.Drawing.Point(0, 56);
            this.but_Booking.Name = "but_Booking";
            this.but_Booking.Size = new System.Drawing.Size(60, 60);
            this.but_Booking.TabIndex = 4;
            this.but_Booking.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL3.Properties.Resources.Lovepik_com_402682230_3d_three_dimensional_2025_new_years_day_calendar_model_elements;
            this.pictureBox1.Location = new System.Drawing.Point(3, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.Title_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "Pitch\'s Managerment";
            this.Title_panel.ResumeLayout(false);
            this.Title_panel.PerformLayout();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel Title_panel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button but_Menu;
        private System.Windows.Forms.Button but_Booking;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}