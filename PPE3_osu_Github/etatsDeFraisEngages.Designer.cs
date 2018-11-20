namespace PPE3_osu_Github
{
    partial class etatsDeFraisEngages
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateMois = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFraisForfait = new System.Windows.Forms.DataGridView();
            this.dgvFraisHForfait = new System.Windows.Forms.DataGridView();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bsAutresFrais = new System.Windows.Forms.BindingSource(this.components);
            this.bsTotal = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutresFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(340, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ETAT DE FRAIS ENGAGES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(177, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "A retourner, accompagné des justificatifs au plus tard le 10 du moi qui suit l\'en" +
    "gagement des frais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(43, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Visiteur";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PPE3_osu_Github.Properties.Resources.Signature;
            this.pictureBox2.Location = new System.Drawing.Point(635, 619);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 119);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_osu_Github.Properties.Resources.petit_logo;
            this.pictureBox1.Location = new System.Drawing.Point(395, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 92);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblDateMois
            // 
            this.lblDateMois.AutoSize = true;
            this.lblDateMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateMois.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDateMois.Location = new System.Drawing.Point(58, 86);
            this.lblDateMois.Name = "lblDateMois";
            this.lblDateMois.Size = new System.Drawing.Size(41, 18);
            this.lblDateMois.TabIndex = 8;
            this.lblDateMois.Text = "Mois";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(328, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Autres frais";
            // 
            // dgvFraisForfait
            // 
            this.dgvFraisForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisForfait.Location = new System.Drawing.Point(202, 284);
            this.dgvFraisForfait.Name = "dgvFraisForfait";
            this.dgvFraisForfait.Size = new System.Drawing.Size(443, 146);
            this.dgvFraisForfait.TabIndex = 11;
            // 
            // dgvFraisHForfait
            // 
            this.dgvFraisHForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisHForfait.Location = new System.Drawing.Point(162, 526);
            this.dgvFraisHForfait.Name = "dgvFraisHForfait";
            this.dgvFraisHForfait.Size = new System.Drawing.Size(423, 150);
            this.dgvFraisHForfait.TabIndex = 12;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(46, 488);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // dgvTotal
            // 
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Location = new System.Drawing.Point(748, 546);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.Size = new System.Drawing.Size(103, 45);
            this.dgvTotal.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(366, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Frais forfaitaires";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(779, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNomPrenom.Location = new System.Drawing.Point(134, 200);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(41, 18);
            this.lblNomPrenom.TabIndex = 19;
            this.lblNomPrenom.Text = "Mois";
            // 
            // etatsDeFraisEngages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 750);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTotal);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.dgvFraisHForfait);
            this.Controls.Add(this.dgvFraisForfait);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDateMois);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "etatsDeFraisEngages";
            this.Text = "etatsDeFraisEngages";
            this.Load += new System.EventHandler(this.etatsDeFraisEngages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutresFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDateMois;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvFraisForfait;
        private System.Windows.Forms.DataGridView dgvFraisHForfait;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.BindingSource bsAutresFrais;
        private System.Windows.Forms.BindingSource bsTotal;
        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNomPrenom;
    }
}