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
    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
            
        }
        public static void ThreadProc()
        {
            //Application.Run(new FMenu());
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
        
            string id = txtIdentifiant.Text;
            string mdp = txtPasswd.Text;
            bool test = Modele.valideConnexion(id, mdp);
            if ( test == true)
            {
                string unId = Modele2.RenvoyerIdVisiteur(id);
                FMenu f = new FMenu(unId, id);
                f.Show();
            }
            else
            {
                MessageBox.Show(" L'identifiant ou le mots de passe est incorrect !");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
           
            bsTest.DataSource = Modele.TestConnexion();
            dgvTest.DataSource = bsTest;
            dgvTest.Columns[0].HeaderText = "ID";
            dgvTest.Columns[1].HeaderText = "MDP";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
