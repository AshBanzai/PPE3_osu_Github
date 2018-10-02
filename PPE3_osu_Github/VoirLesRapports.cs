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
    public partial class VoirLesRapports : Form
    {
        private bool fermeture = false;
        public VoirLesRapports()
        {
            InitializeComponent();
            #region Temporaire
            
            #endregion
        }

        private void VoirLesRapports_Load(object sender, EventArgs e)
        {

        }

        private void VoirLesRapports_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
    }
    }
}
