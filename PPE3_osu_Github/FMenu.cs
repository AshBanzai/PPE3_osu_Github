﻿using System;
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
        string id, identifiant, mdp;
        public FMenu(string unId, string unIdentifiant, string unMDP)
        {
            this.id = unId;
            this.identifiant = unIdentifiant;
            this.mdp = unMDP;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoirLesRapports f = new VoirLesRapports(id);
            f.Show();
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
           MenuFrais f = new MenuFrais(id);
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            FProfil f = new FProfil(identifiant,mdp);
            f.Show();
        }
    }
}
