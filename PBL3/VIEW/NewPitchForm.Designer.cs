namespace PBL3.VIEW
{
    partial class NewPitchForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Pitchname = new System.Windows.Forms.TextBox();
            this.txt_Pitchstatus = new System.Windows.Forms.TextBox();
            this.txt_Pitchprice = new System.Windows.Forms.TextBox();
            this.cbb_Pitchtype = new System.Windows.Forms.ComboBox();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Sân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tình Trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // txt_Pitchname
            // 
            this.txt_Pitchname.Location = new System.Drawing.Point(213, 34);
            this.txt_Pitchname.Name = "txt_Pitchname";
            this.txt_Pitchname.Size = new System.Drawing.Size(182, 22);
            this.txt_Pitchname.TabIndex = 1;
            // 
            // txt_Pitchstatus
            // 
            this.txt_Pitchstatus.Location = new System.Drawing.Point(213, 76);
            this.txt_Pitchstatus.Name = "txt_Pitchstatus";
            this.txt_Pitchstatus.Size = new System.Drawing.Size(182, 22);
            this.txt_Pitchstatus.TabIndex = 1;
            // 
            // txt_Pitchprice
            // 
            this.txt_Pitchprice.Location = new System.Drawing.Point(213, 116);
            this.txt_Pitchprice.Name = "txt_Pitchprice";
            this.txt_Pitchprice.Size = new System.Drawing.Size(182, 22);
            this.txt_Pitchprice.TabIndex = 1;
            // 
            // cbb_Pitchtype
            // 
            this.cbb_Pitchtype.FormattingEnabled = true;
            this.cbb_Pitchtype.Items.AddRange(new object[] {
            "5",
            "7",
            "11"});
            this.cbb_Pitchtype.Location = new System.Drawing.Point(213, 159);
            this.cbb_Pitchtype.Name = "cbb_Pitchtype";
            this.cbb_Pitchtype.Size = new System.Drawing.Size(182, 24);
            this.cbb_Pitchtype.TabIndex = 2;
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(272, 218);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(75, 23);
            this.but_cancel.TabIndex = 3;
            this.but_cancel.Text = "Huỷ";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(97, 218);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 3;
            this.but_add.Text = "Thêm";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // NewPitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.cbb_Pitchtype);
            this.Controls.Add(this.txt_Pitchprice);
            this.Controls.Add(this.txt_Pitchstatus);
            this.Controls.Add(this.txt_Pitchname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewPitchForm";
            this.Text = "NewPitchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Pitchname;
        private System.Windows.Forms.TextBox txt_Pitchstatus;
        private System.Windows.Forms.TextBox txt_Pitchprice;
        private System.Windows.Forms.ComboBox cbb_Pitchtype;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_add;
    }
}