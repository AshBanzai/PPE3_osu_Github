using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_osu_Github
{
    public partial class VoirLesRapports : Form
    {
        string idVisiteur;
        private bool fermeture = false;
        public VoirLesRapports(string unIdVisiteur)
        {
            this.idVisiteur = unIdVisiteur;
            InitializeComponent();
        }

        private void VoirLesRapports_Load(object sender, EventArgs e)
        {
            cboMedecinsSuivis.ValueMember = "idMedecin";
            cboMedecinsSuivis.DisplayMember = "nom_prenom";
            bsMedecinsSuivis.DataSource = Modele2.Suivi(idVisiteur);
            cboMedecinsSuivis.DataSource = bsMedecinsSuivis;
        }

        private void bsMedecinsSuivis_CurrentChanged(object sender, EventArgs e)
        {
            if (fermeture) return;
            bsListeDesRapports.DataSource = Modele2.ListeRapport(idVisiteur);
            dgvListeDesRapports.DataSource = bsListeDesRapports;

            dgvListeDesRapports.Columns["idRapport"].HeaderText = "Numéro";
            dgvListeDesRapports.Columns["idRapport"].Width = 30;
            dgvListeDesRapports.Columns["dateRapport"].HeaderText = "Date";
            dgvListeDesRapports.Columns["dateRapport"].Width = 70;
            dgvListeDesRapports.Columns["libMotif"].HeaderText = "Motif";
            dgvListeDesRapports.Columns["libMotif"].Width = 200;
            dgvListeDesRapports.Columns["bilan"].HeaderText = "Bilan";
            dgvListeDesRapports.Columns["bilan"].Width = 250;
        }

        private void VoirLesRapports_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
        }
    }
}
