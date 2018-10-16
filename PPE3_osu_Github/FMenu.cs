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
        public FMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoirLesRapports f = new VoirLesRapports();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FConnexion f = new FConnexion();
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
    }
}
