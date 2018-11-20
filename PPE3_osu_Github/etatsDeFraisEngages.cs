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
        string idVisiteur="a13";
        private bool fermeture = false;
        private OSUppe3Entities1 maConnexion;
        public etatsDeFraisEngages(string unIdVisiteur)
        {
            
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
          
            bsVisiteur.DataSource = Modele3.listefrais(idVisiteur);
            bsAutresFrais.DataSource = Modele3.listeautresfrais(idVisiteur);
            bsTotal.DataSource = Modele3.totalfrais(idVisiteur);
            lblNomPrenom.Text = Modele3.RenvoyerNomVisiteur(idVisiteur);
            DateTime thisDay = DateTime.Today;
            lblDateMois.Text = thisDay.ToString("D");
            



            bsVisiteur.DataSource = Modele3.listefrais(idVisiteur);
            dgvFraisForfait.DataSource = bsVisiteur;
            dgvFraisForfait.Columns["libelle"].HeaderText = "libelle";
            dgvFraisForfait.Columns["libelle"].Width = 250;
            dgvFraisForfait.Columns["quantite"].HeaderText = "quantite";
            dgvFraisForfait.Columns["quantite"].Width = 50;
            dgvFraisForfait.Columns["montant"].HeaderText = "montant";
            dgvFraisForfait.Columns["montant"].Width = 50;
            dgvFraisForfait.Columns["total"].HeaderText = "total";
            dgvFraisForfait.Columns["total"].Width = 50;


            bsAutresFrais.DataSource = Modele3.listeautresfrais(idVisiteur);
            dgvFraisHForfait.DataSource = bsAutresFrais;
            dgvFraisHForfait.Columns["libelle"].HeaderText = "libelle";
            dgvFraisHForfait.Columns["libelle"].Width = 250;
            dgvFraisHForfait.Columns["date"].HeaderText = "date";
            dgvFraisHForfait.Columns["date"].Width = 70;
            dgvFraisHForfait.Columns["montant"].HeaderText = "montant";
            dgvFraisHForfait.Columns["montant"].Width = 60;

            bsTotal.DataSource = Modele3.totalfrais(idVisiteur);
            dgvTotal.DataSource = bsTotal;
            dgvTotal.Columns["total1"].HeaderText = "Total";
            dgvTotal.Columns["total1"].Width = 60;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            
        }

        private void cboVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fermeture) return;              
                               
                
            


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
