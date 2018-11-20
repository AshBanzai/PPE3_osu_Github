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
    public partial class FProfil : Form
    {
        string identifiant;
        public FProfil(string unIdentifiant)
        {
            InitializeComponent();
            this.identifiant = unIdentifiant;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        
    }

        private void FProfil_Load(object sender, EventArgs e)
        {
            lblPseudo.Text = identifiant;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FModifPseudo f = new FModifPseudo(identifiant);
            f.Show();
        }

        private void lblPseudo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
