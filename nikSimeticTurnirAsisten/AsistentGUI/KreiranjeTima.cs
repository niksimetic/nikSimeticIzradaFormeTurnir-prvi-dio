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
    public partial class KreiranjeTima : Form
    {
        private List<OsobaModel> availabaleTeamMembers = GlobalConfig.Connection.GetOsoba_All();
        private List<OsobaModel> selectedTeamMembers = new List<OsobaModel>();

        public object PersoneModel { get; private set; }

        public KreiranjeTima()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpList();
        }
       

        private void CreateSampleData()
        {

            availabaleTeamMembers.Add(new OsobaModel { Ime = "Tim", Prezime = "Corey" });
            availabaleTeamMembers.Add(new OsobaModel { Ime = "Sue", Prezime = "Storm" });

            selectedTeamMembers.Add(new OsobaModel { Ime = "Jane", Prezime = "Smith" });
            selectedTeamMembers.Add(new OsobaModel { Ime = "Bill", Prezime = "Jones" });
        }
        private void WireUpList()
        {
            cmbNoviIgrac.DataSource = null;
            cmbNoviIgrac.DataSource = availabaleTeamMembers;
            cmbNoviIgrac.DisplayMember = "FullName";

            lstIgraca.DataSource = null;
            lstIgraca.DataSource = selectedTeamMembers;
            lstIgraca.DisplayMember = "FullName";

            
        }
        private void KreiranjeTima_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajIgrac_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                OsobaModel p = new OsobaModel();

                p.Ime = txtIme.Text;
                p.Prezime = txtPrezime.Text;
                p.EmailAdresa = txtEmail.Text;
                p.BrojMobitela = txtBroj.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpList();

                txtIme.Text = "";
                txtPrezime.Text = "";
                txtEmail.Text = "";
                txtBroj.Text = ""; 
            }
            else
            {
                MessageBox.Show("Ispuni svba polja");
            }
        }

        private bool ValidateForm()
        {
            if (txtIme.Text.Length == 0)
            {
                return false;
            }

            if (txtPrezime .Text.Length == 0)
            {
                return false;
            }

            if (txtEmail.Text.Length == 0)
            {
                return false;
            }

            if (txtBroj.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OsobaModel p = (OsobaModel)cmbNoviIgrac.SelectedItem;
            if (p != null)
            {
                availabaleTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpList();
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            OsobaModel p = (OsobaModel)lstIgraca.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availabaleTeamMembers.Add(p);
                WireUpList();
            } 
        }

        private void btnKreirajTim_Click(object sender, EventArgs e)
        {
            EkipaModel t = new EkipaModel();
            t.ImeEkipe = txtImeTima.Text;
            t.ClanoviEkipe = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);
            

        }
    }
}
