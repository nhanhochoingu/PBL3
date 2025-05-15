namespace PBL3.VIEW
{
    partial class SelectPitchForm
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
            this.cbPitchList = new System.Windows.Forms.ComboBox();
            this.but_Chon = new System.Windows.Forms.Button();
            this.but_Huy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPitchList
            // 
            this.cbPitchList.FormattingEnabled = true;
            this.cbPitchList.Location = new System.Drawing.Point(94, 76);
            this.cbPitchList.Name = "cbPitchList";
            this.cbPitchList.Size = new System.Drawing.Size(121, 24);
            this.cbPitchList.TabIndex = 0;
            // 
            // but_Chon
            // 
            this.but_Chon.Location = new System.Drawing.Point(27, 218);
            this.but_Chon.Name = "but_Chon";
            this.but_Chon.Size = new System.Drawing.Size(75, 23);
            this.but_Chon.TabIndex = 1;
            this.but_Chon.Text = "Chọn";
            this.but_Chon.UseVisualStyleBackColor = true;
            this.but_Chon.Click += new System.EventHandler(this.but_Chon_Click);
            // 
            // but_Huy
            // 
            this.but_Huy.Location = new System.Drawing.Point(178, 218);
            this.but_Huy.Name = "but_Huy";
            this.but_Huy.Size = new System.Drawing.Size(75, 23);
            this.but_Huy.TabIndex = 1;
            this.but_Huy.Text = "Huỷ";
            this.but_Huy.UseVisualStyleBackColor = true;
            this.but_Huy.Click += new System.EventHandler(this.but_Huy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sân trống";
            // 
            // SelectPitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Huy);
            this.Controls.Add(this.but_Chon);
            this.Controls.Add(this.cbPitchList);
            this.Name = "SelectPitchForm";
            this.Text = "SelectPitchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPitchList;
        private System.Windows.Forms.Button but_Chon;
        private System.Windows.Forms.Button but_Huy;
        private System.Windows.Forms.Label label1;
    }
}