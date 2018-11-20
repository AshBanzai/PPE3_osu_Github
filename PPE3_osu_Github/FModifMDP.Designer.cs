namespace PPE3_osu_Github
{
    partial class FModifMDP
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtVerif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNvId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVerifMDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 45);
            this.button2.TabIndex = 20;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtVerif
            // 
            this.txtVerif.Location = new System.Drawing.Point(412, 233);
            this.txtVerif.Name = "txtVerif";
            this.txtVerif.Size = new System.Drawing.Size(111, 20);
            this.txtVerif.TabIndex = 19;
            this.txtVerif.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Verification du mot de passe :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Valider le Changement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nouveau mot de passe :";
            // 
            // txtNvId
            // 
            this.txtNvId.Location = new System.Drawing.Point(412, 180);
            this.txtNvId.Name = "txtNvId";
            this.txtNvId.Size = new System.Drawing.Size(111, 20);
            this.txtNvId.TabIndex = 13;
            this.txtNvId.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "CHANGER LE MOT DE PASSE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Entrer votre mot de passe :";
            // 
            // txtVerifMDP
            // 
            this.txtVerifMDP.Location = new System.Drawing.Point(412, 142);
            this.txtVerifMDP.Name = "txtVerifMDP";
            this.txtVerifMDP.Size = new System.Drawing.Size(111, 20);
            this.txtVerifMDP.TabIndex = 23;
            this.txtVerifMDP.UseSystemPasswordChar = true;
            // 
            // FModifMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVerifMDP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtVerif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNvId);
            this.Name = "FModifMDP";
            this.Text = "FModifMDP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtVerif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNvId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVerifMDP;
    }
}