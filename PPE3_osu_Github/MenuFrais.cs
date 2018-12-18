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
    public partial class MenuFrais : Form
    {
        string idVisiteur;
        public MenuFrais(string unIdVisiteur)
        {
            this.idVisiteur = unIdVisiteur;
            InitializeComponent();
        }

        private void btn_visu_Click(object sender, EventArgs e)
        {
            VoirLesFrais f = new VoirLesFrais(idVisiteur);
            f.Show();
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            ModifierLesFrais f = new ModifierLesFrais(idVisiteur);
            f.Show();
        }

        private void btn_creation_Click(object sender, EventArgs e)
        {
            CréerLesFrais f = new CréerLesFrais(idVisiteur);
            f.Show();
        }

        private void MenuFrais_Load(object sender, EventArgs e)
        {

        }
    }
}
