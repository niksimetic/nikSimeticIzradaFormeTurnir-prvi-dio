using nikSimeticTurnirAsisten;
using nikSimeticTurnirAsisten.DataAccess;
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
    public partial class KreiranjeNagrade : Form
    {
        public KreiranjeNagrade()
        {
            InitializeComponent();
        }

        private void btnUnesiNagradu_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                NagradaModel model = new NagradaModel(
                    txtNazivNagrade.Text, 
                    txtOsvojenoMjesto.Text, 
                    txtIznosNagrade.Text, 
                    txtPostotakNagrade.Text);
                
                
            GlobalConfig.Connection.CreatePrize(model);

                txtNazivNagrade.Text = "";
                txtOsvojenoMjesto.Text = "";
                txtIznosNagrade.Text = "0";
                txtPostotakNagrade.Text = "0";  

                
            }
             else
            {
                MessageBox.Show("this form  has invalid information please chek it and try again");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(txtOsvojenoMjesto.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            } 
            if (placeNumber < 1)
            {
                output = false;
            }

            if (txtNazivNagrade.Text.Length == 0)
            {
                output = false;
            }
            decimal prizeAmount = 0;
            int prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(txtIznosNagrade.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(txtPostotakNagrade.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;

            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            return output;

        }

        private void KreiranjeNagrade_Load(object sender, EventArgs e)
        {

        }
    }
}
