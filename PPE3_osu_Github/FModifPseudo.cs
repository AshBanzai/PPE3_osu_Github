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
    public partial class FModifPseudo : Form
    {
        string identifiant;
        public FModifPseudo(string unIdentifiant)
        {
            InitializeComponent();
            this.identifiant = unIdentifiant;
        }

        private void lblPseudo_Click(object sender, EventArgs e)
        {

        }

        private void FModifPseudo_Load(object sender, EventArgs e)
        {
            lblPseudo.Text = identifiant;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNvId.Text != identifiant)
            {
                if (txtNvId.Text == txtVerif.Text)
                {
                    MessageBox.Show(" Maintenant faut faire la requête ");
                }
                else
                {
                    MessageBox.Show("  Veuillez vérifier qu'il n'y a pas d'erreur dans votre nouvelle identifiant.\n Vous devez avoir le même identifiant entrer dans 'Nouvelle identifiant' et 'Verification nouvelle identifiant.' ");
                }
            }
            else
            {
                MessageBox.Show("  Erreur ! \n Veuillez entrer un identifiant différent de l'ancien. ");
            }
            
        }
    }
}
