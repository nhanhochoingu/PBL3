namespace PBL3.VIEW
{
    partial class UC_Pitchs_Admin
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Pitchprice = new System.Windows.Forms.TextBox();
            this.txt_Pitchstatus = new System.Windows.Forms.TextBox();
            this.txt_Pitchname = new System.Windows.Forms.TextBox();
            this.txt_Pitchtype = new System.Windows.Forms.TextBox();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_bookedpitch = new System.Windows.Forms.Button();
            this.but_SeeAllPitch = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.but_del = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.txt_Pitchprice);
            this.groupBox1.Controls.Add(this.txt_Pitchstatus);
            this.groupBox1.Controls.Add(this.txt_Pitchname);
            this.groupBox1.Controls.Add(this.txt_Pitchtype);
            this.groupBox1.Controls.Add(this.but_cancel);
            this.groupBox1.Controls.Add(this.but_bookedpitch);
            this.groupBox1.Controls.Add(this.but_SeeAllPitch);
            this.groupBox1.Controls.Add(this.but_del);
            this.groupBox1.Controls.Add(this.but_add);
            this.groupBox1.Controls.Add(this.but_update);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐẶT SÂN";
            // 
            // txt_Pitchprice
            // 
            this.txt_Pitchprice.Location = new System.Drawing.Point(421, 86);
            this.txt_Pitchprice.Name = "txt_Pitchprice";
            this.txt_Pitchprice.Size = new System.Drawing.Size(168, 30);
            this.txt_Pitchprice.TabIndex = 4;
            // 
            // txt_Pitchstatus
            // 
            this.txt_Pitchstatus.Location = new System.Drawing.Point(421, 40);
            this.txt_Pitchstatus.Name = "txt_Pitchstatus";
            this.txt_Pitchstatus.Size = new System.Drawing.Size(168, 30);
            this.txt_Pitchstatus.TabIndex = 4;
            // 
            // txt_Pitchname
            // 
            this.txt_Pitchname.Location = new System.Drawing.Point(107, 87);
            this.txt_Pitchname.Name = "txt_Pitchname";
            this.txt_Pitchname.Size = new System.Drawing.Size(168, 30);
            this.txt_Pitchname.TabIndex = 4;
            // 
            // txt_Pitchtype
            // 
            this.txt_Pitchtype.Location = new System.Drawing.Point(107, 40);
            this.txt_Pitchtype.Name = "txt_Pitchtype";
            this.txt_Pitchtype.Size = new System.Drawing.Size(168, 30);
            this.txt_Pitchtype.TabIndex = 4;
            // 
            // but_cancel
            // 
            this.but_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cancel.Location = new System.Drawing.Point(209, 153);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(174, 29);
            this.but_cancel.TabIndex = 3;
            this.but_cancel.Text = "Huỷ Sân Đã Đặt";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_bookedpitch
            // 
            this.but_bookedpitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_bookedpitch.Location = new System.Drawing.Point(10, 154);
            this.but_bookedpitch.Name = "but_bookedpitch";
            this.but_bookedpitch.Size = new System.Drawing.Size(174, 29);
            this.but_bookedpitch.TabIndex = 3;
            this.but_bookedpitch.Text = "Xem Sân Đã Đặt";
            this.but_bookedpitch.UseVisualStyleBackColor = true;
            this.but_bookedpitch.Click += new System.EventHandler(this.but_bookedpitch_Click);
            // 
            // but_SeeAllPitch
            // 
            this.but_SeeAllPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_SeeAllPitch.Location = new System.Drawing.Point(612, 87);
            this.but_SeeAllPitch.Name = "but_SeeAllPitch";
            this.but_SeeAllPitch.Size = new System.Drawing.Size(132, 29);
            this.but_SeeAllPitch.TabIndex = 3;
            this.but_SeeAllPitch.Text = "Xem Tất Cả Sân";
            this.but_SeeAllPitch.UseVisualStyleBackColor = true;
            this.but_SeeAllPitch.Click += new System.EventHandler(this.but_SeeAllPitch_Click);
            // 
            // but_add
            // 
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.Location = new System.Drawing.Point(770, 37);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(132, 29);
            this.but_add.TabIndex = 3;
            this.but_add.Text = "Thêm Sân";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_update
            // 
            this.but_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_update.Location = new System.Drawing.Point(612, 37);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(132, 29);
            this.but_update.TabIndex = 3;
            this.but_update.Text = "Cập Nhật Sân";
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá Sân (/h)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Sân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình Trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Sân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Location = new System.Drawing.Point(3, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 488);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN SÂN BÓNG";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // but_del
            // 
            this.but_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.Location = new System.Drawing.Point(770, 90);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(132, 29);
            this.but_del.TabIndex = 3;
            this.but_del.Text = "Xoá Sân";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(402, 155);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 22);
            this.dtp.TabIndex = 5;
            // 
            // UC_Pitchs_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Pitchs_Admin";
            this.Size = new System.Drawing.Size(1000, 700);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_bookedpitch;
        private System.Windows.Forms.Button but_SeeAllPitch;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_Pitchprice;
        private System.Windows.Forms.TextBox txt_Pitchstatus;
        private System.Windows.Forms.TextBox txt_Pitchname;
        private System.Windows.Forms.TextBox txt_Pitchtype;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}
