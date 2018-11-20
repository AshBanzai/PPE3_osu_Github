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
    public partial class FMenu : Form
    {
        string identifiant;
        public FMenu(string unIdentifiant)
        {
            this.identifiant = unIdentifiant;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoirLesRapports f = new VoirLesRapports(this.identifiant);
            f.Show();
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            etatsDeFraisEngages f = new etatsDeFraisEngages();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
