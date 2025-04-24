using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butExit = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturebox
            // 
            this.picturebox.Image = ((System.Drawing.Image)(resources.GetObject("picturebox.Image")));
            this.picturebox.Location = new System.Drawing.Point(-17, -12);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(587, 712);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butExit);
            this.panel1.Controls.Add(this.butLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(573, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 618);
            this.panel1.TabIndex = 1;
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.butExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butExit.Location = new System.Drawing.Point(24, 481);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(466, 65);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "Thoát";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.butLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butLogin.Location = new System.Drawing.Point(24, 385);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(466, 65);
            this.butLogin.TabIndex = 3;
            this.butLogin.Text = "Đăng Nhập";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 106);
            this.panel3.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(201, 24);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(286, 36);
            this.txtPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 102);
            this.panel2.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(201, 24);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(286, 35);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(140, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picturebox);
            this.Name = "Login";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private TextBox txtUsername;
        private Button butExit;
        private Button butLogin;
        private TextBox txtPassword;
    }
}

