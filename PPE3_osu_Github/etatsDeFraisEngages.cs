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
    public partial class etatsDeFraisEngages : Form
    {
        string idVisiteur;
        private bool fermeture = false;
        private OSUppe3Entities1 maConnexion;
        public etatsDeFraisEngages(string unIdVisiteur)
        {
            this.idVisiteur = unIdVisiteur;
            InitializeComponent();
            maConnexion = new OSUppe3Entities1();            
            //change le label mois par le mois de la demande
            //lblMatricule.Text = Modele3.DonneNomVisiteur("uipol");
           
        }
               private void label1_Click(object sender, EventArgs e)
        {
        }
        private void etatsDeFraisEngages_Load(object sender, EventArgs e)
        {
            cboVisiteur.ValueMember = "idVisiteur";
            cboVisiteur.DisplayMember = "libelle";
            bsVisiteur.DataSource = Modele3.listefrais(idVisiteur);
            cboVisiteur.DataSource = bsVisiteur;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            
        }

        private void cboVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fermeture) return;              
                               
                bsVisiteur.DataSource = Modele3.listefrais(idVisiteur);
                dgvFraisForfais.DataSource = bsVisiteur;
                dgvFraisForfais.Columns["libelle"].HeaderText = "libelle";
                dgvFraisForfais.Columns["libelle"].Width = 30;
                dgvFraisForfais.Columns["quantite"].HeaderText = "quantite";
                dgvFraisForfais.Columns["quantite"].Width = 70;
                dgvFraisForfais.Columns["montant"].HeaderText = "montant";
                dgvFraisForfais.Columns["montant"].Width = 200;
                dgvFraisForfais.Columns["total"].HeaderText = "total";
                dgvFraisForfais.Columns["total"].Width = 250;

        }
    }
}
