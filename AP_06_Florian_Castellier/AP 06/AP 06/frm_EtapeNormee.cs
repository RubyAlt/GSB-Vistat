using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static AP_06.SQL;

namespace AP_06
{
    public partial class frm_EtapeNormee : Form
    {
        public frm_EtapeNormee()
        {
            InitializeComponent();
        }
        public string num;
        private void frm_EtapeNormee_Load(object sender, EventArgs e)
        {
            Connexion.Open();

            lireLesEtapesNormees();

            foreach (KeyValuePair<string, EtapeNormee> uneEtapeNormee in Global.lesEtapesNormees)
            {
                ListViewItem uneLigne = new ListViewItem { Text = uneEtapeNormee.Key };
                uneLigne.SubItems.Add(uneEtapeNormee.Value.libelle);
                uneLigne.SubItems.Add(uneEtapeNormee.Value.norme);
                uneLigne.SubItems.Add(uneEtapeNormee.Value.dateNorme.ToString());

                lvEtapeNormee.Items.Add(uneLigne);
            }

            Connexion.Close();
        }

        private void lvEtapeNormee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEtapeNormee.SelectedItems.Count == 0) return;
            num = lvEtapeNormee.SelectedItems[0].SubItems[0].Text;
            string norme = lvEtapeNormee.SelectedItems[0].SubItems[2].Text;
            string dateNorme = lvEtapeNormee.SelectedItems[0].SubItems[3].Text;

            tbNorme.Text = norme;
            tbDateNorme.Text = dateNorme;

            btMaj.Enabled = true;
        }

        private void btMaj_Click(object sender, EventArgs e)
        {
            Global.lesEtapesNormees[num].norme = tbNorme.Text;
            Global.lesEtapesNormees[num].dateNorme = DateTime.Parse(tbDateNorme.Text);
        }
    }
}
