namespace PBL3.VIEW
{
    partial class UC_Revenue_Admin
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_revenue = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.but_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.but_del = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Staffname = new System.Windows.Forms.TextBox();
            this.txt_Staffphone = new System.Windows.Forms.TextBox();
            this.txt_Staffemail = new System.Windows.Forms.TextBox();
            this.txt_Staffcoeff = new System.Windows.Forms.TextBox();
            this.txt_Stafftime = new System.Windows.Forms.TextBox();
            this.but_pitch = new System.Windows.Forms.Button();
            this.but_drink = new System.Windows.Forms.Button();
            this.but_refresh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Location = new System.Drawing.Point(3, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 488);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN THỐNG KÊ";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 29);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(978, 453);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.but_drink);
            this.groupBox1.Controls.Add(this.but_pitch);
            this.groupBox1.Controls.Add(this.but_revenue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THỐNG KÊ";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(158, 91);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 5;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(158, 39);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày kết thúc";
            // 
            // but_edit
            // 
            this.but_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_edit.Location = new System.Drawing.Point(472, 85);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(108, 29);
            this.but_edit.TabIndex = 3;
            this.but_edit.Text = "Thay Đổi";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // but_revenue
            // 
            this.but_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_revenue.Location = new System.Drawing.Point(6, 156);
            this.but_revenue.Name = "but_revenue";
            this.but_revenue.Size = new System.Drawing.Size(124, 29);
            this.but_revenue.TabIndex = 3;
            this.but_revenue.Text = "Doanh Thu";
            this.but_revenue.UseVisualStyleBackColor = true;
            this.but_revenue.Click += new System.EventHandler(this.but_revenue_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Staffemail);
            this.groupBox3.Controls.Add(this.txt_Staffphone);
            this.groupBox3.Controls.Add(this.txt_Stafftime);
            this.groupBox3.Controls.Add(this.txt_Staffcoeff);
            this.groupBox3.Controls.Add(this.txt_Staffname);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.but_refresh);
            this.groupBox3.Controls.Add(this.but_add);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.but_edit);
            this.groupBox3.Controls.Add(this.but_del);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox3.Location = new System.Drawing.Point(401, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 200);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NHÂN VIÊN";
            // 
            // but_add
            // 
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.Location = new System.Drawing.Point(472, 143);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(108, 29);
            this.but_add.TabIndex = 3;
            this.but_add.Text = "Thêm";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // but_del
            // 
            this.but_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.Location = new System.Drawing.Point(472, 36);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(108, 29);
            this.but_del.TabIndex = 3;
            this.but_del.Text = "Xoá";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hệ Số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số Giờ Làm";
            // 
            // txt_Staffname
            // 
            this.txt_Staffname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Staffname.Location = new System.Drawing.Point(73, 42);
            this.txt_Staffname.Name = "txt_Staffname";
            this.txt_Staffname.Size = new System.Drawing.Size(157, 22);
            this.txt_Staffname.TabIndex = 6;
            // 
            // txt_Staffphone
            // 
            this.txt_Staffphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Staffphone.Location = new System.Drawing.Point(73, 93);
            this.txt_Staffphone.Name = "txt_Staffphone";
            this.txt_Staffphone.Size = new System.Drawing.Size(157, 22);
            this.txt_Staffphone.TabIndex = 6;
            // 
            // txt_Staffemail
            // 
            this.txt_Staffemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Staffemail.Location = new System.Drawing.Point(73, 140);
            this.txt_Staffemail.Name = "txt_Staffemail";
            this.txt_Staffemail.Size = new System.Drawing.Size(157, 22);
            this.txt_Staffemail.TabIndex = 6;
            // 
            // txt_Staffcoeff
            // 
            this.txt_Staffcoeff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Staffcoeff.Location = new System.Drawing.Point(354, 36);
            this.txt_Staffcoeff.Name = "txt_Staffcoeff";
            this.txt_Staffcoeff.Size = new System.Drawing.Size(95, 22);
            this.txt_Staffcoeff.TabIndex = 6;
            // 
            // txt_Stafftime
            // 
            this.txt_Stafftime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stafftime.Location = new System.Drawing.Point(354, 91);
            this.txt_Stafftime.Name = "txt_Stafftime";
            this.txt_Stafftime.Size = new System.Drawing.Size(95, 22);
            this.txt_Stafftime.TabIndex = 6;
            // 
            // but_pitch
            // 
            this.but_pitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_pitch.Location = new System.Drawing.Point(132, 156);
            this.but_pitch.Name = "but_pitch";
            this.but_pitch.Size = new System.Drawing.Size(124, 29);
            this.but_pitch.TabIndex = 3;
            this.but_pitch.Text = "Sân";
            this.but_pitch.UseVisualStyleBackColor = true;
            this.but_pitch.Click += new System.EventHandler(this.but_pitch_Click);
            // 
            // but_drink
            // 
            this.but_drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_drink.Location = new System.Drawing.Point(262, 156);
            this.but_drink.Name = "but_drink";
            this.but_drink.Size = new System.Drawing.Size(124, 29);
            this.but_drink.TabIndex = 3;
            this.but_drink.Text = "Nước";
            this.but_drink.UseVisualStyleBackColor = true;
            this.but_drink.Click += new System.EventHandler(this.but_drink_Click);
            // 
            // but_refresh
            // 
            this.but_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_refresh.Location = new System.Drawing.Point(354, 143);
            this.but_refresh.Name = "but_refresh";
            this.but_refresh.Size = new System.Drawing.Size(108, 29);
            this.but_refresh.TabIndex = 3;
            this.but_refresh.Text = "Làm Mới";
            this.but_refresh.UseVisualStyleBackColor = true;
            this.but_refresh.Click += new System.EventHandler(this.but_refresh_Click);
            // 
            // UC_Revenue_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_Revenue_Admin";
            this.Size = new System.Drawing.Size(1000, 700);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_revenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.TextBox txt_Staffname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Staffemail;
        private System.Windows.Forms.TextBox txt_Staffphone;
        private System.Windows.Forms.TextBox txt_Stafftime;
        private System.Windows.Forms.TextBox txt_Staffcoeff;
        private System.Windows.Forms.Button but_drink;
        private System.Windows.Forms.Button but_pitch;
        private System.Windows.Forms.Button but_refresh;
    }
}
