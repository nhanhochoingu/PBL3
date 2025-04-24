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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sânBóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muaNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtSânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLịchĐặtSânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.sânBóngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // sânBóngToolStripMenuItem
            // 
            this.sânBóngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muaNướcToolStripMenuItem,
            this.đặtSânToolStripMenuItem,
            this.xemLịchĐặtSânToolStripMenuItem});
            this.sânBóngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sânBóngToolStripMenuItem.Name = "sânBóngToolStripMenuItem";
            this.sânBóngToolStripMenuItem.Size = new System.Drawing.Size(123, 34);
            this.sânBóngToolStripMenuItem.Text = "Sân bóng";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(114, 34);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // muaNướcToolStripMenuItem
            // 
            this.muaNướcToolStripMenuItem.Name = "muaNướcToolStripMenuItem";
            this.muaNướcToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.muaNướcToolStripMenuItem.Text = "Mua Nước";
            // 
            // đặtSânToolStripMenuItem
            // 
            this.đặtSânToolStripMenuItem.Name = "đặtSânToolStripMenuItem";
            this.đặtSânToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.đặtSânToolStripMenuItem.Text = "Đặt sân";
            // 
            // xemLịchĐặtSânToolStripMenuItem
            // 
            this.xemLịchĐặtSânToolStripMenuItem.Name = "xemLịchĐặtSânToolStripMenuItem";
            this.xemLịchĐặtSânToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.xemLịchĐặtSânToolStripMenuItem.Text = "Xem lịch đặt sân";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 893);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sânBóngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muaNướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtSânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemLịchĐặtSânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
    }
}