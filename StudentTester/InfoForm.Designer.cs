namespace StudentTester
{
    partial class InfoForm
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
            this.AppInfoLabel = new System.Windows.Forms.Label();
            this.creatorLink = new System.Windows.Forms.LinkLabel();
            this.creatorInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppInfoLabel
            // 
            this.AppInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppInfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AppInfoLabel.Location = new System.Drawing.Point(15, 15);
            this.AppInfoLabel.Margin = new System.Windows.Forms.Padding(6);
            this.AppInfoLabel.Name = "AppInfoLabel";
            this.AppInfoLabel.Size = new System.Drawing.Size(338, 86);
            this.AppInfoLabel.TabIndex = 0;
            this.AppInfoLabel.Text = "Программа оценивания\r\n успеваемости студентов \r\n\"Student Tester\"";
            this.AppInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppInfoLabel.Click += new System.EventHandler(this.AppInfoLabel_Click);
            // 
            // creatorLink
            // 
            this.creatorLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creatorLink.LinkColor = System.Drawing.SystemColors.Highlight;
            this.creatorLink.Location = new System.Drawing.Point(15, 165);
            this.creatorLink.Margin = new System.Windows.Forms.Padding(6);
            this.creatorLink.Name = "creatorLink";
            this.creatorLink.Size = new System.Drawing.Size(339, 25);
            this.creatorLink.TabIndex = 2;
            this.creatorLink.TabStop = true;
            this.creatorLink.Text = "https://vk.com/nikolol";
            this.creatorLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.creatorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.СreatorLink_LinkClicked);
            // 
            // creatorInfo
            // 
            this.creatorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creatorInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.creatorInfo.Location = new System.Drawing.Point(16, 130);
            this.creatorInfo.Margin = new System.Windows.Forms.Padding(6);
            this.creatorInfo.Name = "creatorInfo";
            this.creatorInfo.Size = new System.Drawing.Size(338, 23);
            this.creatorInfo.TabIndex = 3;
            this.creatorInfo.Text = "Крютченко Никита 2019 (с) ИФМИТ ЛНУ";
            this.creatorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.creatorInfo.Click += new System.EventHandler(this.CreatorInfo_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(365, 213);
            this.Controls.Add(this.creatorInfo);
            this.Controls.Add(this.creatorLink);
            this.Controls.Add(this.AppInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.Click += new System.EventHandler(this.InfoForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AppInfoLabel;
        private System.Windows.Forms.LinkLabel creatorLink;
        private System.Windows.Forms.Label creatorInfo;
    }
}