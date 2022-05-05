namespace Firefighter_Project.Views
{
    partial class ForgottenPassView
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
            this.TopTxtLbl = new System.Windows.Forms.Label();
            this.SubtextLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopTxtLbl
            // 
            this.TopTxtLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopTxtLbl.AutoSize = true;
            this.TopTxtLbl.Font = new System.Drawing.Font("Sitka Text", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTxtLbl.Location = new System.Drawing.Point(37, 131);
            this.TopTxtLbl.Name = "TopTxtLbl";
            this.TopTxtLbl.Size = new System.Drawing.Size(342, 45);
            this.TopTxtLbl.TabIndex = 0;
            this.TopTxtLbl.Text = "Forgotten Password?";
            this.TopTxtLbl.Click += new System.EventHandler(this.TopTxtLbl_Click);
            // 
            // SubtextLbl
            // 
            this.SubtextLbl.AutoSize = true;
            this.SubtextLbl.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtextLbl.Location = new System.Drawing.Point(50, 176);
            this.SubtextLbl.Name = "SubtextLbl";
            this.SubtextLbl.Size = new System.Drawing.Size(308, 105);
            this.SubtextLbl.TabIndex = 1;
            this.SubtextLbl.Text = "Please enter your E-Mail,\r\nso we can send you a\r\npassword change request.\r\n";
            this.SubtextLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SubtextLbl.Click += new System.EventHandler(this.SubtextLbl_Click);
            // 
            // EmailLbl
            // 
            this.EmailLbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmailLbl.Location = new System.Drawing.Point(56, 284);
            this.EmailLbl.Multiline = true;
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(298, 30);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailLbl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(56, 320);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(138, 37);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Nevermind";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.Location = new System.Drawing.Point(216, 320);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(138, 37);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send it!";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.Transparent;
            this.LogoPic.Image = global::Firefighter_Project.Properties.Resources.icon;
            this.LogoPic.Location = new System.Drawing.Point(139, 12);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(132, 96);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 5;
            this.LogoPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Firefighter_Project.Properties.Resources.redline;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Firefighter_Project.Properties.Resources.redline;
            this.pictureBox2.Location = new System.Drawing.Point(-20, 363);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(457, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(362, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(40, 31);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ForgottenPassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 407);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.SubtextLbl);
            this.Controls.Add(this.TopTxtLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgottenPassView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgottenPassView";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopTxtLbl;
        private System.Windows.Forms.Label SubtextLbl;
        private System.Windows.Forms.TextBox EmailLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ExitBtn;
    }
}