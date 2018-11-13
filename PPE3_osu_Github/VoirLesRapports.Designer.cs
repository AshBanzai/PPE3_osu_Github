namespace PPE3_osu_Github
{
    partial class VoirLesRapports
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
            this.lblMedecinsSuivis = new System.Windows.Forms.Label();
            this.cboMedecinsSuivis = new System.Windows.Forms.ComboBox();
            this.lblNuméro = new System.Windows.Forms.Label();
            this.lblListeDesRapports = new System.Windows.Forms.Label();
            this.dgvListeDesRapports = new System.Windows.Forms.DataGridView();
            this.lblDateDeVisite = new System.Windows.Forms.Label();
            this.bsMedecinsSuivis = new System.Windows.Forms.BindingSource(this.components);
            this.txtDateDeVisite = new System.Windows.Forms.TextBox();
            this.txtNuméro = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblLesMedicamentsPrescrits = new System.Windows.Forms.Label();
            this.bsListeDesRapports = new System.Windows.Forms.BindingSource(this.components);
            this.bsMedicamentsPrescris = new System.Windows.Forms.BindingSource(this.components);
            this.dgvListeDesMedicaments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDesRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecinsSuivis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeDesRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentsPrescris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDesMedicaments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedecinsSuivis
            // 
            this.lblMedecinsSuivis.AutoSize = true;
            this.lblMedecinsSuivis.Location = new System.Drawing.Point(12, 29);
            this.lblMedecinsSuivis.Name = "lblMedecinsSuivis";
            this.lblMedecinsSuivis.Size = new System.Drawing.Size(88, 13);
            this.lblMedecinsSuivis.TabIndex = 0;
            this.lblMedecinsSuivis.Text = "Médecins suivis :";
            // 
            // cboMedecinsSuivis
            // 
            this.cboMedecinsSuivis.FormattingEnabled = true;
            this.cboMedecinsSuivis.Location = new System.Drawing.Point(106, 26);
            this.cboMedecinsSuivis.Name = "cboMedecinsSuivis";
            this.cboMedecinsSuivis.Size = new System.Drawing.Size(121, 21);
            this.cboMedecinsSuivis.TabIndex = 1;
            // 
            // lblNuméro
            // 
            this.lblNuméro.AutoSize = true;
            this.lblNuméro.Location = new System.Drawing.Point(375, 84);
            this.lblNuméro.Name = "lblNuméro";
            this.lblNuméro.Size = new System.Drawing.Size(50, 13);
            this.lblNuméro.TabIndex = 2;
            this.lblNuméro.Text = "Numéro :";
            // 
            // lblListeDesRapports
            // 
            this.lblListeDesRapports.AutoSize = true;
            this.lblListeDesRapports.Location = new System.Drawing.Point(12, 68);
            this.lblListeDesRapports.Name = "lblListeDesRapports";
            this.lblListeDesRapports.Size = new System.Drawing.Size(143, 13);
            this.lblListeDesRapports.TabIndex = 3;
            this.lblListeDesRapports.Text = "Liste des rapports effectués :";
            // 
            // dgvListeDesRapports
            // 
            this.dgvListeDesRapports.AllowUserToAddRows = false;
            this.dgvListeDesRapports.AllowUserToDeleteRows = false;
            this.dgvListeDesRapports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDesRapports.Location = new System.Drawing.Point(12, 84);
            this.dgvListeDesRapports.Name = "dgvListeDesRapports";
            this.dgvListeDesRapports.ReadOnly = true;
            this.dgvListeDesRapports.Size = new System.Drawing.Size(357, 210);
            this.dgvListeDesRapports.TabIndex = 4;
            // 
            // lblDateDeVisite
            // 
            this.lblDateDeVisite.AutoSize = true;
            this.lblDateDeVisite.Location = new System.Drawing.Point(375, 112);
            this.lblDateDeVisite.Name = "lblDateDeVisite";
            this.lblDateDeVisite.Size = new System.Drawing.Size(78, 13);
            this.lblDateDeVisite.TabIndex = 5;
            this.lblDateDeVisite.Text = "Date de visite :";
            // 
            // txtDateDeVisite
            // 
            this.txtDateDeVisite.Location = new System.Drawing.Point(460, 112);
            this.txtDateDeVisite.Name = "txtDateDeVisite";
            this.txtDateDeVisite.ReadOnly = true;
            this.txtDateDeVisite.Size = new System.Drawing.Size(116, 20);
            this.txtDateDeVisite.TabIndex = 6;
            // 
            // txtNuméro
            // 
            this.txtNuméro.Location = new System.Drawing.Point(460, 86);
            this.txtNuméro.Name = "txtNuméro";
            this.txtNuméro.ReadOnly = true;
            this.txtNuméro.Size = new System.Drawing.Size(116, 20);
            this.txtNuméro.TabIndex = 7;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(375, 139);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 8;
            this.lblMotif.Text = "Motif :";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(460, 139);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.ReadOnly = true;
            this.txtMotif.Size = new System.Drawing.Size(116, 20);
            this.txtMotif.TabIndex = 9;
            // 
            // lblLesMedicamentsPrescrits
            // 
            this.lblLesMedicamentsPrescrits.AutoSize = true;
            this.lblLesMedicamentsPrescrits.Location = new System.Drawing.Point(375, 166);
            this.lblLesMedicamentsPrescrits.Name = "lblLesMedicamentsPrescrits";
            this.lblLesMedicamentsPrescrits.Size = new System.Drawing.Size(137, 13);
            this.lblLesMedicamentsPrescrits.TabIndex = 10;
            this.lblLesMedicamentsPrescrits.Text = "Les médicaments prescrits :";
            // 
            // dgvListeDesMedicaments
            // 
            this.dgvListeDesMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDesMedicaments.Location = new System.Drawing.Point(378, 182);
            this.dgvListeDesMedicaments.Name = "dgvListeDesMedicaments";
            this.dgvListeDesMedicaments.Size = new System.Drawing.Size(283, 112);
            this.dgvListeDesMedicaments.TabIndex = 11;
            // 
            // VoirLesRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 306);
            this.Controls.Add(this.dgvListeDesMedicaments);
            this.Controls.Add(this.lblLesMedicamentsPrescrits);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.txtNuméro);
            this.Controls.Add(this.txtDateDeVisite);
            this.Controls.Add(this.lblDateDeVisite);
            this.Controls.Add(this.dgvListeDesRapports);
            this.Controls.Add(this.lblListeDesRapports);
            this.Controls.Add(this.lblNuméro);
            this.Controls.Add(this.cboMedecinsSuivis);
            this.Controls.Add(this.lblMedecinsSuivis);
            this.Name = "VoirLesRapports";
            this.Text = "VoirLesRapports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VoirLesRapports_FormClosing);
            this.Load += new System.EventHandler(this.VoirLesRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDesRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecinsSuivis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeDesRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentsPrescris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDesMedicaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedecinsSuivis;
        private System.Windows.Forms.ComboBox cboMedecinsSuivis;
        private System.Windows.Forms.Label lblNuméro;
        private System.Windows.Forms.Label lblListeDesRapports;
        private System.Windows.Forms.DataGridView dgvListeDesRapports;
        private System.Windows.Forms.Label lblDateDeVisite;
        private System.Windows.Forms.BindingSource bsMedecinsSuivis;
        private System.Windows.Forms.TextBox txtDateDeVisite;
        private System.Windows.Forms.TextBox txtNuméro;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblLesMedicamentsPrescrits;
        private System.Windows.Forms.BindingSource bsListeDesRapports;
        private System.Windows.Forms.BindingSource bsMedicamentsPrescris;
        private System.Windows.Forms.DataGridView dgvListeDesMedicaments;
    }
}