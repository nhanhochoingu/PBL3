namespace PBL3.VIEW
{
    partial class UC_Booking_Customer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Service = new System.Windows.Forms.Button();
            this.but_YourPitch = new System.Windows.Forms.Button();
            this.but_SeeAllPitch = new System.Windows.Forms.Button();
            this.but_Book = new System.Windows.Forms.Button();
            this.cb_Minutes = new System.Windows.Forms.ComboBox();
            this.cb_StartTime = new System.Windows.Forms.ComboBox();
            this.cb_PitchType = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Service);
            this.groupBox1.Controls.Add(this.but_YourPitch);
            this.groupBox1.Controls.Add(this.but_SeeAllPitch);
            this.groupBox1.Controls.Add(this.but_Book);
            this.groupBox1.Controls.Add(this.cb_Minutes);
            this.groupBox1.Controls.Add(this.cb_StartTime);
            this.groupBox1.Controls.Add(this.cb_PitchType);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐẶT SÂN";
            // 
            // but_Service
            // 
            this.but_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Service.Location = new System.Drawing.Point(761, 84);
            this.but_Service.Name = "but_Service";
            this.but_Service.Size = new System.Drawing.Size(132, 29);
            this.but_Service.TabIndex = 3;
            this.but_Service.Text = "Dịch Vụ";
            this.but_Service.UseVisualStyleBackColor = true;
            this.but_Service.Click += new System.EventHandler(this.but_Service_Click);
            // 
            // but_YourPitch
            // 
            this.but_YourPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_YourPitch.Location = new System.Drawing.Point(761, 31);
            this.but_YourPitch.Name = "but_YourPitch";
            this.but_YourPitch.Size = new System.Drawing.Size(132, 29);
            this.but_YourPitch.TabIndex = 3;
            this.but_YourPitch.Text = "Sân Của Bạn";
            this.but_YourPitch.UseVisualStyleBackColor = true;
            this.but_YourPitch.Click += new System.EventHandler(this.but_YourPitch_Click);
            // 
            // but_SeeAllPitch
            // 
            this.but_SeeAllPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_SeeAllPitch.Location = new System.Drawing.Point(612, 84);
            this.but_SeeAllPitch.Name = "but_SeeAllPitch";
            this.but_SeeAllPitch.Size = new System.Drawing.Size(132, 29);
            this.but_SeeAllPitch.TabIndex = 3;
            this.but_SeeAllPitch.Text = "Xem Tất Cả Sân";
            this.but_SeeAllPitch.UseVisualStyleBackColor = true;
            this.but_SeeAllPitch.Click += new System.EventHandler(this.but_SeeAllPitch_Click);
            // 
            // but_Book
            // 
            this.but_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Book.Location = new System.Drawing.Point(612, 31);
            this.but_Book.Name = "but_Book";
            this.but_Book.Size = new System.Drawing.Size(132, 29);
            this.but_Book.TabIndex = 3;
            this.but_Book.Text = "Đặt Sân";
            this.but_Book.UseVisualStyleBackColor = true;
            this.but_Book.Click += new System.EventHandler(this.but_Book_Click);
            // 
            // cb_Minutes
            // 
            this.cb_Minutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Minutes.FormattingEnabled = true;
            this.cb_Minutes.Items.AddRange(new object[] {
            "60",
            "90"});
            this.cb_Minutes.Location = new System.Drawing.Point(400, 89);
            this.cb_Minutes.Name = "cb_Minutes";
            this.cb_Minutes.Size = new System.Drawing.Size(145, 24);
            this.cb_Minutes.TabIndex = 2;
            // 
            // cb_StartTime
            // 
            this.cb_StartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_StartTime.FormattingEnabled = true;
            this.cb_StartTime.Items.AddRange(new object[] {
            "5:30",
            "6:30",
            "7:30",
            "8:30",
            "9:30",
            "10:30",
            "14:30",
            "15:30",
            "16:30",
            "17:30",
            "18:30",
            "19:30",
            "20:30",
            "21:30",
            "22:30"});
            this.cb_StartTime.Location = new System.Drawing.Point(117, 89);
            this.cb_StartTime.Name = "cb_StartTime";
            this.cb_StartTime.Size = new System.Drawing.Size(145, 24);
            this.cb_StartTime.TabIndex = 2;
            // 
            // cb_PitchType
            // 
            this.cb_PitchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_PitchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PitchType.FormattingEnabled = true;
            this.cb_PitchType.Items.AddRange(new object[] {
            "5",
            "7",
            "11"});
            this.cb_PitchType.Location = new System.Drawing.Point(117, 36);
            this.cb_PitchType.Name = "cb_PitchType";
            this.cb_PitchType.Size = new System.Drawing.Size(145, 24);
            this.cb_PitchType.TabIndex = 2;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(400, 38);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(145, 22);
            this.dtp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Phút Đá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giờ Đá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 40);
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
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN SÂN BÓNG";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 29);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(978, 441);
            this.dgv.TabIndex = 0;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // UC_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Booking";
            this.Size = new System.Drawing.Size(1000, 700);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Minutes;
        private System.Windows.Forms.ComboBox cb_StartTime;
        private System.Windows.Forms.ComboBox cb_PitchType;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button but_Book;
        private System.Windows.Forms.Button but_Service;
        private System.Windows.Forms.Button but_SeeAllPitch;
        private System.Windows.Forms.Button but_YourPitch;
        private System.Windows.Forms.DataGridView dgv;
    }
}
