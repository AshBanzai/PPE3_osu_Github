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
            Application.Run(new FMenu());
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
        
            string id = txtIdentifiant.ToString();
            string mdp = txtPasswd.ToString();
            bool test = Modele.validConnexion(id, mdp);
            if ( test == true)
            {
                MessageBox.Show("OouuuuuuuuuuuuiiiiiiiiiiiiiiiiiiiiiiiIIii!");
            }
            else
            {
                MessageBox.Show("non!");
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
    }
}
