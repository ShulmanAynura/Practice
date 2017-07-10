namespace LP_2
{
    partial class FormSettings
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
            this.SaveChanges = new System.Windows.Forms.Button();
            this.rtbGramm = new System.Windows.Forms.RichTextBox();
            this.rtbFact = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenGramm = new System.Windows.Forms.Button();
            this.OpenFact = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveChanges
            // 
            this.SaveChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveChanges.Location = new System.Drawing.Point(706, 531);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(75, 27);
            this.SaveChanges.TabIndex = 0;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // rtbGramm
            // 
            this.rtbGramm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbGramm.Location = new System.Drawing.Point(3, 27);
            this.rtbGramm.Name = "rtbGramm";
            this.rtbGramm.Size = new System.Drawing.Size(386, 468);
            this.rtbGramm.TabIndex = 1;
            this.rtbGramm.Text = "";
            // 
            // rtbFact
            // 
            this.rtbFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFact.Location = new System.Drawing.Point(395, 27);
            this.rtbFact.Name = "rtbFact";
            this.rtbFact.Size = new System.Drawing.Size(386, 468);
            this.rtbFact.TabIndex = 2;
            this.rtbFact.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Грамматика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(395, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Факты";
            // 
            // OpenGramm
            // 
            this.OpenGramm.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpenGramm.Location = new System.Drawing.Point(314, 501);
            this.OpenGramm.Name = "OpenGramm";
            this.OpenGramm.Size = new System.Drawing.Size(75, 24);
            this.OpenGramm.TabIndex = 5;
            this.OpenGramm.Text = "Открыть";
            this.OpenGramm.UseVisualStyleBackColor = true;
            this.OpenGramm.Click += new System.EventHandler(this.OpenGramm_Click);
            // 
            // OpenFact
            // 
            this.OpenFact.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpenFact.Location = new System.Drawing.Point(706, 501);
            this.OpenFact.Name = "OpenFact";
            this.OpenFact.Size = new System.Drawing.Size(75, 24);
            this.OpenFact.TabIndex = 6;
            this.OpenFact.Text = "Открыть";
            this.OpenFact.UseVisualStyleBackColor = true;
            this.OpenFact.Click += new System.EventHandler(this.OpenFact_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveChanges, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OpenGramm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbFact, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbGramm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenFact, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.819277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.18073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.RichTextBox rtbGramm;
        private System.Windows.Forms.RichTextBox rtbFact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenGramm;
        private System.Windows.Forms.Button OpenFact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}