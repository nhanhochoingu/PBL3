namespace PBL3.VIEW
{
    partial class Invoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.but_Close = new System.Windows.Forms.Button();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lbl_Pitch = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_PitchPrice = new System.Windows.Forms.Label();
            this.lbl_DrinkPrice = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.but_pdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOÁ ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(15, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nước";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 21);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(443, 149);
            this.dgv.TabIndex = 0;
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(259, 492);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(82, 27);
            this.but_Close.TabIndex = 5;
            this.but_Close.Text = "Đóng";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Location = new System.Drawing.Point(143, 94);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(0, 16);
            this.lblPitch.TabIndex = 6;
            // 
            // lbl_Pitch
            // 
            this.lbl_Pitch.AutoSize = true;
            this.lbl_Pitch.Location = new System.Drawing.Point(18, 78);
            this.lbl_Pitch.Name = "lbl_Pitch";
            this.lbl_Pitch.Size = new System.Drawing.Size(44, 16);
            this.lbl_Pitch.TabIndex = 7;
            this.lbl_Pitch.Text = "label8";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(18, 119);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(44, 16);
            this.lbl_Date.TabIndex = 7;
            this.lbl_Date.Text = "label8";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(18, 164);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(44, 16);
            this.lbl_Time.TabIndex = 7;
            this.lbl_Time.Text = "label8";
            // 
            // lbl_PitchPrice
            // 
            this.lbl_PitchPrice.AutoSize = true;
            this.lbl_PitchPrice.Location = new System.Drawing.Point(18, 205);
            this.lbl_PitchPrice.Name = "lbl_PitchPrice";
            this.lbl_PitchPrice.Size = new System.Drawing.Size(44, 16);
            this.lbl_PitchPrice.TabIndex = 7;
            this.lbl_PitchPrice.Text = "label8";
            // 
            // lbl_DrinkPrice
            // 
            this.lbl_DrinkPrice.AutoSize = true;
            this.lbl_DrinkPrice.Location = new System.Drawing.Point(18, 441);
            this.lbl_DrinkPrice.Name = "lbl_DrinkPrice";
            this.lbl_DrinkPrice.Size = new System.Drawing.Size(44, 16);
            this.lbl_DrinkPrice.TabIndex = 7;
            this.lbl_DrinkPrice.Text = "label8";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(18, 472);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(44, 16);
            this.lbl_Total.TabIndex = 7;
            this.lbl_Total.Text = "label8";
            // 
            // but_pdf
            // 
            this.but_pdf.Location = new System.Drawing.Point(109, 492);
            this.but_pdf.Name = "but_pdf";
            this.but_pdf.Size = new System.Drawing.Size(82, 27);
            this.but_pdf.TabIndex = 5;
            this.but_pdf.Text = "Xuất PDF";
            this.but_pdf.UseVisualStyleBackColor = true;
            this.but_pdf.Click += new System.EventHandler(this.but_pdf_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_DrinkPrice);
            this.Controls.Add(this.lbl_PitchPrice);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Pitch);
            this.Controls.Add(this.lblPitch);
            this.Controls.Add(this.but_pdf);
            this.Controls.Add(this.but_Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label lbl_Pitch;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_PitchPrice;
        private System.Windows.Forms.Label lbl_DrinkPrice;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button but_pdf;
    }
}