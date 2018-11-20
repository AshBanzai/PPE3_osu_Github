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
    }
}
