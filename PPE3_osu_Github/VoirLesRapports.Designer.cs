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
            this.lblListeDesRapports = new System.Windows.Forms.Label();
            this.dgvListeDesRapports = new System.Windows.Forms.DataGridView();
            this.bsMedecinsSuivis = new System.Windows.Forms.BindingSource(this.components);
            this.lblLesMedicamentsPrescrits = new System.Windows.Forms.Label();
            this.bsListeDesRapports = new System.Windows.Forms.BindingSource(this.components);
            this.dgvListeDesMedicaments = new System.Windows.Forms.DataGridView();
            this.lblCboVide = new System.Windows.Forms.Label();
            this.bsMedicamentsPrescris = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDesRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecinsSuivis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeDesRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDesMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentsPrescris)).BeginInit();
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
            this.cboMedecinsSuivis.Location = new System.Drawing.Point(106, 29);
            this.cboMedecinsSuivis.Name = "cboMedecinsSuivis";
            this.cboMedecinsSuivis.Size = new System.Drawing.Size(121, 21);
            this.cboMedecinsSuivis.TabIndex = 1;
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
            this.dgvListeDesRapports.Size = new System.Drawing.Size(611, 210);
            this.dgvListeDesRapports.TabIndex = 4;
            // 
            // bsMedecinsSuivis
            // 
            this.bsMedecinsSuivis.CurrentChanged += new System.EventHandler(this.bsMedecinsSuivis_CurrentChanged);
            // 
            // lblLesMedicamentsPrescrits
            // 
            this.lblLesMedicamentsPrescrits.AutoSize = true;
            this.lblLesMedicamentsPrescrits.Location = new System.Drawing.Point(9, 297);
            this.lblLesMedicamentsPrescrits.Name = "lblLesMedicamentsPrescrits";
            this.lblLesMedicamentsPrescrits.Size = new System.Drawing.Size(137, 13);
            this.lblLesMedicamentsPrescrits.TabIndex = 10;
            this.lblLesMedicamentsPrescrits.Text = "Les médicaments prescrits :";
            // 
            // bsListeDesRapports
            // 
            this.bsListeDesRapports.CurrentChanged += new System.EventHandler(this.bsListeDesRapports_CurrentChanged);
            // 
            // dgvListeDesMedicaments
            // 
            this.dgvListeDesMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDesMedicaments.Location = new System.Drawing.Point(12, 313);
            this.dgvListeDesMedicaments.Name = "dgvListeDesMedicaments";
            this.dgvListeDesMedicaments.Size = new System.Drawing.Size(611, 124);
            this.dgvListeDesMedicaments.TabIndex = 11;
            // 
            // lblCboVide
            // 
            this.lblCboVide.AutoSize = true;
            this.lblCboVide.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCboVide.Location = new System.Drawing.Point(233, 32);
            this.lblCboVide.Name = "lblCboVide";
            this.lblCboVide.Size = new System.Drawing.Size(57, 13);
            this.lblCboVide.TabIndex = 12;
            this.lblCboVide.Text = "lblCboVide";
            // 
            // VoirLesRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 468);
            this.Controls.Add(this.lblCboVide);
            this.Controls.Add(this.dgvListeDesMedicaments);
            this.Controls.Add(this.lblLesMedicamentsPrescrits);
            this.Controls.Add(this.dgvListeDesRapports);
            this.Controls.Add(this.lblListeDesRapports);
            this.Controls.Add(this.cboMedecinsSuivis);
            this.Controls.Add(this.lblMedecinsSuivis);
            this.Name = "VoirLesRapports";
            this.Text = "VoirLesRapports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VoirLesRapports_FormClosing);
            this.Load += new System.EventHandler(this.VoirLesRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDesRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecinsSuivis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeDesRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDesMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicamentsPrescris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedecinsSuivis;
        private System.Windows.Forms.ComboBox cboMedecinsSuivis;
        private System.Windows.Forms.Label lblListeDesRapports;
        private System.Windows.Forms.DataGridView dgvListeDesRapports;
        private System.Windows.Forms.BindingSource bsMedecinsSuivis;
        private System.Windows.Forms.Label lblLesMedicamentsPrescrits;
        private System.Windows.Forms.BindingSource bsListeDesRapports;
        private System.Windows.Forms.DataGridView dgvListeDesMedicaments;
        private System.Windows.Forms.Label lblCboVide;
        private System.Windows.Forms.BindingSource bsMedicamentsPrescris;
    }
}