namespace LP_2
{
    partial class FormGeneral
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
            this.bFindFact = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbIn = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeFact = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bFindFact
            // 
            this.bFindFact.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bFindFact.Dock = System.Windows.Forms.DockStyle.Right;
            this.bFindFact.ForeColor = System.Drawing.Color.Black;
            this.bFindFact.Location = new System.Drawing.Point(678, 3);
            this.bFindFact.Name = "bFindFact";
            this.bFindFact.Size = new System.Drawing.Size(103, 35);
            this.bFindFact.TabIndex = 0;
            this.bFindFact.Text = "Извлечь факты";
            this.bFindFact.UseVisualStyleBackColor = false;
            this.bFindFact.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.Settings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить результаты";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.CloseToolStripMenuItem.Text = "Выход";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(79, 20);
            this.Settings.Text = "Настройки";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // rtbIn
            // 
            this.rtbIn.BackColor = System.Drawing.SystemColors.Window;
            this.rtbIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbIn.Location = new System.Drawing.Point(3, 44);
            this.rtbIn.Name = "rtbIn";
            this.rtbIn.Size = new System.Drawing.Size(386, 490);
            this.rtbIn.TabIndex = 3;
            this.rtbIn.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rtbIn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bFindFact, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeFact, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.727273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.27273F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 537);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // treeFact
            // 
            this.treeFact.BackColor = System.Drawing.SystemColors.Window;
            this.treeFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeFact.Location = new System.Drawing.Point(395, 44);
            this.treeFact.Name = "treeFact";
            this.treeFact.Size = new System.Drawing.Size(386, 490);
            this.treeFact.TabIndex = 4;
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGeneral";
            this.Text = "Find your fact";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFindFact;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox rtbIn;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeFact;
    }
}

