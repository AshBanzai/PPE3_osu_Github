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
        private bool fermeture = false;
        private OSUppe3Entities1 maConnexion;
        public etatsDeFraisEngages()
        {
            InitializeComponent();
            maConnexion = new OSUppe3Entities1();
            //change le label mois par le mois de la demande
            //lblMatricule.Text = Modele3.DonneNomVisiteur("uipol");
            cboVisiteur.ValueMember = "nom";
            cboVisiteur.DisplayMember = "prenom";
            bsVisiteur.DataSource = Modele2.MedecinsSuivis();     //MedecinsSuivis();
            cboVisiteur.DataSource = bsVisiteur;
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void etatsDeFraisEngages_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            
        }

        private void cboVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!fermeture)
            {
                //bsVisiteur.DataSource = Modele3.ListeFraisForfaits(Modele3.DonneIdVisiteur(cboVisiteur.SelectedValue.ToString()));
                dgvFraisForfais.DataSource = bsVisiteur;

                for (int i = 0; i < dgvFraisForfais.ColumnCount; i++)
                {
                    dgvFraisForfais.Columns[i].Visible = false;
                }
                dgvFraisForfais.Columns[0].Visible = true;
                dgvFraisForfais.Columns[0].HeaderText = "NOM";
                dgvFraisForfais.Columns[1].Visible = true;
                dgvFraisForfais.Columns[1].HeaderText = "PRENOM";
                dgvFraisForfais.Columns[2].Visible = true;
                dgvFraisForfais.Columns[2].HeaderText = "STYLE";
                dgvFraisForfais.Columns[3].Visible = true;
                dgvFraisForfais.Columns[3].HeaderText = "Né le";
                dgvFraisForfais.Columns[4].Visible = true;
                dgvFraisForfais.Columns[4].HeaderText = "Mort le";
                dgvFraisForfais.Columns[5].Visible = true;
                dgvFraisForfais.Columns[5].HeaderText = "Informations";
                // dgvCompositeur.Columns[6].Visible = false;

            }
        }
    }
}
