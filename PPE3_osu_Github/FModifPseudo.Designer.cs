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
            this.txtNvId = new System.Windows.Forms.TextBox();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerif = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nouvelle Identifiant :";
            // 
            // txtNvId
            // 
            this.txtNvId.Location = new System.Drawing.Point(377, 166);
            this.txtNvId.Name = "txtNvId";
            this.txtNvId.Size = new System.Drawing.Size(111, 20);
            this.txtNvId.TabIndex = 5;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(397, 116);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(39, 13);
            this.lblPseudo.TabIndex = 8;
            this.lblPseudo.Text = "labe45";
            this.lblPseudo.Click += new System.EventHandler(this.lblPseudo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Identifiant actuel :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Valider le Changement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Verification du nouvelle identifiant :";
            // 
            // txtVerif
            // 
            this.txtVerif.Location = new System.Drawing.Point(377, 219);
            this.txtVerif.Name = "txtVerif";
            this.txtVerif.Size = new System.Drawing.Size(111, 20);
            this.txtVerif.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "CHANGER L\'IDENTIFIANT";
            // 
            // FModifPseudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtVerif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNvId);
            this.Name = "FModifPseudo";
            this.Text = "FModifPseudo";
            this.Load += new System.EventHandler(this.FModifPseudo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNvId;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerif;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}