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
            this.SuspendLayout();
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(529, 403);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(75, 23);
            this.SaveChanges.TabIndex = 0;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // rtbGramm
            // 
            this.rtbGramm.Location = new System.Drawing.Point(12, 25);
            this.rtbGramm.Name = "rtbGramm";
            this.rtbGramm.Size = new System.Drawing.Size(311, 341);
            this.rtbGramm.TabIndex = 1;
            this.rtbGramm.Text = "";
            // 
            // rtbFact
            // 
            this.rtbFact.Location = new System.Drawing.Point(336, 25);
            this.rtbFact.Name = "rtbFact";
            this.rtbFact.Size = new System.Drawing.Size(268, 341);
            this.rtbFact.TabIndex = 2;
            this.rtbFact.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Грамматика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Факты";
            // 
            // OpenGramm
            // 
            this.OpenGramm.Location = new System.Drawing.Point(15, 372);
            this.OpenGramm.Name = "OpenGramm";
            this.OpenGramm.Size = new System.Drawing.Size(75, 23);
            this.OpenGramm.TabIndex = 5;
            this.OpenGramm.Text = "Открыть";
            this.OpenGramm.UseVisualStyleBackColor = true;
            this.OpenGramm.Click += new System.EventHandler(this.OpenGramm_Click);
            // 
            // OpenFact
            // 
            this.OpenFact.Location = new System.Drawing.Point(336, 372);
            this.OpenFact.Name = "OpenFact";
            this.OpenFact.Size = new System.Drawing.Size(75, 23);
            this.OpenFact.TabIndex = 6;
            this.OpenFact.Text = "Открыть";
            this.OpenFact.UseVisualStyleBackColor = true;
            this.OpenFact.Click += new System.EventHandler(this.OpenFact_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 439);
            this.Controls.Add(this.OpenFact);
            this.Controls.Add(this.OpenGramm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbFact);
            this.Controls.Add(this.rtbGramm);
            this.Controls.Add(this.SaveChanges);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.RichTextBox rtbGramm;
        private System.Windows.Forms.RichTextBox rtbFact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenGramm;
        private System.Windows.Forms.Button OpenFact;
    }
}