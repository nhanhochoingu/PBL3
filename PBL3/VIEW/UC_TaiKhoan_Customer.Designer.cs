namespace PBL3.VIEW
{
    partial class UC_TaiKhoan_Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_TaiKhoan = new System.Windows.Forms.GroupBox();
            this.cb_Show = new System.Windows.Forms.CheckBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.cb_Edit = new System.Windows.Forms.CheckBox();
            this.but_view_invoice = new System.Windows.Forms.Button();
            this.but_Save = new System.Windows.Forms.Button();
            this.txt_Sđt = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lb_Mail = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.lb_Sđt = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.grb_LichSu = new System.Windows.Forms.GroupBox();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.grb_TaiKhoan.SuspendLayout();
            this.grb_LichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_TaiKhoan
            // 
            this.grb_TaiKhoan.Controls.Add(this.cb_Show);
            this.grb_TaiKhoan.Controls.Add(this.lb_Password);
            this.grb_TaiKhoan.Controls.Add(this.lb_username);
            this.grb_TaiKhoan.Controls.Add(this.cb_Edit);
            this.grb_TaiKhoan.Controls.Add(this.but_view_invoice);
            this.grb_TaiKhoan.Controls.Add(this.but_Save);
            this.grb_TaiKhoan.Controls.Add(this.txt_Sđt);
            this.grb_TaiKhoan.Controls.Add(this.txt_Email);
            this.grb_TaiKhoan.Controls.Add(this.txt_Password);
            this.grb_TaiKhoan.Controls.Add(this.txt_username);
            this.grb_TaiKhoan.Controls.Add(this.txt_Ten);
            this.grb_TaiKhoan.Controls.Add(this.txt_ID);
            this.grb_TaiKhoan.Controls.Add(this.lb_Mail);
            this.grb_TaiKhoan.Controls.Add(this.lb_Ten);
            this.grb_TaiKhoan.Controls.Add(this.lb_Sđt);
            this.grb_TaiKhoan.Controls.Add(this.lb_ID);
            this.grb_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TaiKhoan.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.grb_TaiKhoan.Location = new System.Drawing.Point(3, 14);
            this.grb_TaiKhoan.Name = "grb_TaiKhoan";
            this.grb_TaiKhoan.Size = new System.Drawing.Size(980, 196);
            this.grb_TaiKhoan.TabIndex = 0;
            this.grb_TaiKhoan.TabStop = false;
            this.grb_TaiKhoan.Text = "TÀI KHOẢN";
            // 
            // cb_Show
            // 
            this.cb_Show.AutoSize = true;
            this.cb_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Show.Location = new System.Drawing.Point(424, 164);
            this.cb_Show.Name = "cb_Show";
            this.cb_Show.Size = new System.Drawing.Size(109, 17);
            this.cb_Show.TabIndex = 8;
            this.cb_Show.Text = "Hiện mật khẩu";
            this.cb_Show.UseVisualStyleBackColor = true;
            this.cb_Show.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(293, 135);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(97, 20);
            this.lb_Password.TabIndex = 7;
            this.lb_Password.Text = "Password:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(293, 95);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(103, 20);
            this.lb_username.TabIndex = 7;
            this.lb_username.Text = "UserName:";
            // 
            // cb_Edit
            // 
            this.cb_Edit.AutoSize = true;
            this.cb_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Edit.Location = new System.Drawing.Point(769, 42);
            this.cb_Edit.Name = "cb_Edit";
            this.cb_Edit.Size = new System.Drawing.Size(164, 22);
            this.cb_Edit.TabIndex = 6;
            this.cb_Edit.Text = "Thay đổi thông tin";
            this.cb_Edit.UseVisualStyleBackColor = true;
            this.cb_Edit.CheckedChanged += new System.EventHandler(this.cb_Edit_CheckedChanged);
            // 
            // but_view_invoice
            // 
            this.but_view_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_view_invoice.Location = new System.Drawing.Point(769, 128);
            this.but_view_invoice.Name = "but_view_invoice";
            this.but_view_invoice.Size = new System.Drawing.Size(144, 38);
            this.but_view_invoice.TabIndex = 5;
            this.but_view_invoice.Text = "Xem Hoá Đơn";
            this.but_view_invoice.UseVisualStyleBackColor = true;
            this.but_view_invoice.Click += new System.EventHandler(this.but_view_invoice_Click);
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(769, 77);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(144, 38);
            this.but_Save.TabIndex = 5;
            this.but_Save.Text = "Lưu";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // txt_Sđt
            // 
            this.txt_Sđt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_Sđt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Sđt.Location = new System.Drawing.Point(63, 92);
            this.txt_Sđt.Name = "txt_Sđt";
            this.txt_Sđt.Size = new System.Drawing.Size(224, 27);
            this.txt_Sđt.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Location = new System.Drawing.Point(424, 42);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(330, 27);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Location = new System.Drawing.Point(424, 128);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(330, 27);
            this.txt_Password.TabIndex = 4;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Location = new System.Drawing.Point(424, 88);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(330, 27);
            this.txt_username.TabIndex = 4;
            // 
            // txt_Ten
            // 
            this.txt_Ten.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_Ten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Ten.Location = new System.Drawing.Point(63, 135);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(224, 27);
            this.txt_Ten.TabIndex = 4;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Location = new System.Drawing.Point(63, 43);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(224, 27);
            this.txt_ID.TabIndex = 4;
            // 
            // lb_Mail
            // 
            this.lb_Mail.AutoSize = true;
            this.lb_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mail.Location = new System.Drawing.Point(293, 46);
            this.lb_Mail.Name = "lb_Mail";
            this.lb_Mail.Size = new System.Drawing.Size(62, 20);
            this.lb_Mail.TabIndex = 3;
            this.lb_Mail.Text = "Email:";
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ten.Location = new System.Drawing.Point(6, 135);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(46, 20);
            this.lb_Ten.TabIndex = 2;
            this.lb_Ten.Text = "Tên:";
            // 
            // lb_Sđt
            // 
            this.lb_Sđt.AutoSize = true;
            this.lb_Sđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sđt.Location = new System.Drawing.Point(6, 95);
            this.lb_Sđt.Name = "lb_Sđt";
            this.lb_Sđt.Size = new System.Drawing.Size(51, 20);
            this.lb_Sđt.TabIndex = 1;
            this.lb_Sđt.Text = "SĐT:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(6, 46);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(34, 20);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID:";
            // 
            // grb_LichSu
            // 
            this.grb_LichSu.Controls.Add(this.dgvBills);
            this.grb_LichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_LichSu.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.grb_LichSu.Location = new System.Drawing.Point(3, 217);
            this.grb_LichSu.Name = "grb_LichSu";
            this.grb_LichSu.Size = new System.Drawing.Size(980, 480);
            this.grb_LichSu.TabIndex = 1;
            this.grb_LichSu.TabStop = false;
            this.grb_LichSu.Text = "LỊCH SỬ HOÁ ĐƠN";
            // 
            // dgvBills
            // 
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Location = new System.Drawing.Point(7, 29);
            this.dgvBills.MultiSelect = false;
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.RowTemplate.Height = 24;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.Size = new System.Drawing.Size(967, 445);
            this.dgvBills.TabIndex = 0;
            this.dgvBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellClick);
            // 
            // UC_TaiKhoan_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.grb_LichSu);
            this.Controls.Add(this.grb_TaiKhoan);
            this.Name = "UC_TaiKhoan_Customer";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.UC_TaiKhoan_Load);
            this.grb_TaiKhoan.ResumeLayout(false);
            this.grb_TaiKhoan.PerformLayout();
            this.grb_LichSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_TaiKhoan;
        private System.Windows.Forms.GroupBox grb_LichSu;
        private System.Windows.Forms.Label lb_Mail;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.Label lb_Sđt;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.TextBox txt_Sđt;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.CheckBox cb_Edit;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.CheckBox cb_Show;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.Button but_view_invoice;
    }
}
