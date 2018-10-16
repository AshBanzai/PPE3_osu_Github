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
            cboMedecinsSuivis.ValueMember = "idMedecin";
            cboMedecinsSuivis.DisplayMember = "nom";
            bsMedecinsSuivis.DataSource = Modele2.MedecinsSuivis();     //MedecinsSuivis();
            cboMedecinsSuivis.DataSource = bsMedecinsSuivis;
        }



        private void VoirLesRapports_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermeture = true;
        }

        /*if (fermeture) return;

            bsListeDesRapports.DataSource = ((MEDECIN) bsMedecinsSuivis.Current).RAPPORT.ToList().Where(x => x.idVisiteur == "a13").OrderBy(x => x.idRapport);
        dgvListeDesRapports.DataSource = bsListeDesRapports;
            for (int i = 0; i<dgvListeDesRapports.ColumnCount; i++)
            {
                dgvListeDesRapports.Columns[i].Visible = false;
            }
    dgvListeDesRapports.Columns["idRapport"].Visible = true;
            dgvListeDesRapports.Columns["dateRapport"].Visible = true;*/
    }
}
