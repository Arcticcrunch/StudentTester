namespace StudentTesterApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TestSelector = new System.Windows.Forms.ListBox();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestSelectorLabel = new System.Windows.Forms.Label();
            this.TestPanelHolder = new System.Windows.Forms.Panel();
            this.Question = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.previousTestButton = new System.Windows.Forms.Button();
            this.nextTestButton = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestSelector
            // 
            this.TestSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.TestSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TestSelector.FormattingEnabled = true;
            this.TestSelector.ItemHeight = 16;
            this.TestSelector.Location = new System.Drawing.Point(22, 115);
            this.TestSelector.Name = "TestSelector";
            this.TestSelector.Size = new System.Drawing.Size(236, 532);
            this.TestSelector.TabIndex = 2;
            this.TestSelector.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TestSelector_DrawItem);
            this.TestSelector.SelectedIndexChanged += new System.EventHandler(this.TestSelector_SelectedIndexChanged);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1019, 24);
            this.MainMenuStrip.TabIndex = 3;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TestSelectorLabel
            // 
            this.TestSelectorLabel.AutoSize = true;
            this.TestSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestSelectorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TestSelectorLabel.Location = new System.Drawing.Point(23, 38);
            this.TestSelectorLabel.Name = "TestSelectorLabel";
            this.TestSelectorLabel.Size = new System.Drawing.Size(235, 55);
            this.TestSelectorLabel.TabIndex = 4;
            this.TestSelectorLabel.Text = "Вопросы:";
            // 
            // TestPanelHolder
            // 
            this.TestPanelHolder.Location = new System.Drawing.Point(281, 115);
            this.TestPanelHolder.Margin = new System.Windows.Forms.Padding(20);
            this.TestPanelHolder.Name = "TestPanelHolder";
            this.TestPanelHolder.Size = new System.Drawing.Size(709, 461);
            this.TestPanelHolder.TabIndex = 5;
            // 
            // Question
            // 
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.ForeColor = System.Drawing.SystemColors.Control;
            this.Question.Location = new System.Drawing.Point(281, 38);
            this.Question.Name = "Question";
            this.Question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Question.Size = new System.Drawing.Size(709, 70);
            this.Question.TabIndex = 6;
            this.Question.Text = "Текущий вопрос";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.ForestGreen;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OKButton.Location = new System.Drawing.Point(420, 599);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(431, 48);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "Подтвердить";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // previousTestButton
            // 
            this.previousTestButton.BackColor = System.Drawing.SystemColors.Control;
            this.previousTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousTestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.previousTestButton.Location = new System.Drawing.Point(281, 599);
            this.previousTestButton.Name = "previousTestButton";
            this.previousTestButton.Size = new System.Drawing.Size(133, 48);
            this.previousTestButton.TabIndex = 8;
            this.previousTestButton.Text = "Назад";
            this.previousTestButton.UseVisualStyleBackColor = false;
            this.previousTestButton.Click += new System.EventHandler(this.PreviousTestButton_Click);
            // 
            // nextTestButton
            // 
            this.nextTestButton.BackColor = System.Drawing.SystemColors.Control;
            this.nextTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextTestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextTestButton.Location = new System.Drawing.Point(857, 599);
            this.nextTestButton.Name = "nextTestButton";
            this.nextTestButton.Size = new System.Drawing.Size(133, 48);
            this.nextTestButton.TabIndex = 9;
            this.nextTestButton.Text = "Далее";
            this.nextTestButton.UseVisualStyleBackColor = false;
            this.nextTestButton.Click += new System.EventHandler(this.NextTestButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1019, 674);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.nextTestButton);
            this.Controls.Add(this.previousTestButton);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.TestPanelHolder);
            this.Controls.Add(this.TestSelectorLabel);
            this.Controls.Add(this.TestSelector);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudent Tester";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox TestSelector;
        private new System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label TestSelectorLabel;
        private System.Windows.Forms.Panel TestPanelHolder;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button previousTestButton;
        private System.Windows.Forms.Button nextTestButton;
    }
}

