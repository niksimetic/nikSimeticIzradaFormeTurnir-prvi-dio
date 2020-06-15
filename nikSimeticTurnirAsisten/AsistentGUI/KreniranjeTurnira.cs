using nikSimeticTurnirAsisten;
using nikSimeticTurnirAsisten.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistentGUI
{
    public partial class KreniranjeTurnira : Form
    {
        List<EkipaModel> availableTeams = GlobalConfig.Connection.GetEkipa_All();
        List<EkipaModel> selectedTeams = new List<EkipaModel>();
        List<NagradaModel> selectedPrizes = new List<NagradaModel>();
        public KreniranjeTurnira()
        {
            InitializeComponent();

            WireUpLists();
        }
        private void WireUpLists()
        {
            cmbOdaberiTim.DataSource = null;
            cmbOdaberiTim.DataSource = availableTeams;
            cmbOdaberiTim.DisplayMember = "ImeEkipe";

            lstListaTimova.DataSource = null;
            lstListaTimova.DataSource = selectedTeams;
            lstListaTimova.DisplayMember = "ImeEkipe";

            lstNagrada.DataSource = null;
            lstNagrada.DataSource = selectedPrizes;
            lstNagrada.DisplayMember = "NazivMjesta";
        }
        private void btnUcitajTim_Click(object sender, EventArgs e)
        {

        }

        private void cmbOdaberiTim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNapraviTim_Click(object sender, EventArgs e)
        {
            
            EkipaModel t = (EkipaModel)cmbOdaberiTim.SelectedItem;  
            if(t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }
    }
}
