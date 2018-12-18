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
        private string idVisiteur;
        private bool result = false;
        private bool fermeture = false;
        private bool enChargement = true;
        private bool enChargement2 = true;
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
            lblCboVide.Text = "";
            result = testCboMedecinVide();
            enChargement = false;
        }

        private void bsMedecinsSuivis_CurrentChanged(object sender, EventArgs e)
        {
            if (fermeture || result || enChargement) return;
            string idMed = cboMedecinsSuivis.SelectedValue.ToString();
            int idMedecin = Convert.ToInt32(idMed);
            bsListeDesRapports.DataSource = Modele2.ListeRapport(idVisiteur, idMedecin);
            dgvListeDesRapports.DataSource = bsListeDesRapports;
            dgvListeDesRapports.Columns["idRapport"].HeaderText = "Numéro";
            dgvListeDesRapports.Columns["idRapport"].Width = 30;
            dgvListeDesRapports.Columns["dateRapport"].HeaderText = "Date";
            dgvListeDesRapports.Columns["dateRapport"].Width = 70;
            dgvListeDesRapports.Columns["libMotif"].HeaderText = "Motif";
            dgvListeDesRapports.Columns["libMotif"].Width = 200;
            dgvListeDesRapports.Columns["bilan"].HeaderText = "Bilan";
            dgvListeDesRapports.Columns["bilan"].Width = 250;
            enChargement2 = false;

        }


        private void VoirLesRapports_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
        }

        public bool testCboMedecinVide()
        {
            bool vretour = false;
            if(cboMedecinsSuivis.SelectedIndex == -1)
            {
                lblCboVide.Text = "Ce visiteur ne suit aucun médecin pour le moment !";
                vretour = true;
            }
            return vretour;
        }

        private void bsListeDesRapports_CurrentChanged(object sender, EventArgs e)
        {
            if (fermeture || result || enChargement2) return;
            string idRapp = dgvListeDesRapports.CurrentRow.Cells["idRapport"].Value.ToString();
            int idRapport = Convert.ToInt32(idRapp);
            bsMedicamentsPrescris.DataSource = Modele2.ListeMedicament(idRapport);
            dgvListeDesMedicaments.DataSource = bsMedicamentsPrescris;
            dgvListeDesMedicaments.Columns["idMedicament"].HeaderText = "Numéro";
            dgvListeDesMedicaments.Columns["idMedicament"].Width = 30;
            dgvListeDesMedicaments.Columns["nomCommercial"].HeaderText = "Nom";
            dgvListeDesMedicaments.Columns["nomCommercial"].Width = 70;
            dgvListeDesMedicaments.Columns["composition"].HeaderText = "Composition";
            dgvListeDesMedicaments.Columns["composition"].Width = 150;
            dgvListeDesMedicaments.Columns["effet"].HeaderText = "Effet";
            dgvListeDesMedicaments.Columns["effet"].Width = 200;
            dgvListeDesMedicaments.Columns["contreIndications"].HeaderText = "Effet";
            dgvListeDesMedicaments.Columns["contreIndications"].Width = 100;
        }
    }
}
