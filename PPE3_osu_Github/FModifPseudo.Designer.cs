namespace PPE3_osu_Github
{
    partial class FModifPseudo
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "nv pseudo :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(399, 136);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(39, 13);
            this.lblPseudo.TabIndex = 8;
            this.lblPseudo.Text = "labe45";
            this.lblPseudo.Click += new System.EventHandler(this.lblPseudo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pseudo actuel :";
            // 
            // FModifPseudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Name = "FModifPseudo";
            this.Text = "FModifPseudo";
            this.Load += new System.EventHandler(this.FModifPseudo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label label1;
    }
}