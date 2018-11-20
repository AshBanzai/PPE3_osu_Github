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
    public partial class FModifMDP : Form
    {
        string mdp, identifiant;
        public FModifMDP(string unId, string unMdp)
        {
            InitializeComponent();
            this.identifiant = unId;
            this.mdp = unMdp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = identifiant;
            string mdp = txtVerifMDP.Text;
            bool test = Modele.valideConnexion(id, mdp);
            if (test == true)
            {
                if (txtNvId.Text != mdp)
                {
                    if (txtNvId.Text == txtVerif.Text)
                    {
                        MessageBox.Show(" Maintenant faut faire la requête ");
                    }
                    else
                    {
                        MessageBox.Show("  Veuillez vérifier qu'il n'y a pas d'erreur dans votre nouveau mot de passe.\n Vous devez avoir le même identifiant entrer dans 'Nouveau mot de passe' et 'Verification du nouveau mots de passe.' ");
                    }
                }
                else
                {
                    MessageBox.Show("  Erreur ! \n Veuillez entrer un mot de passe différent de l'ancien. ");
                }
            }
            else
            {
                MessageBox.Show(" Le mot de passe est incorrect !");
            }
 
        }
    }
}
