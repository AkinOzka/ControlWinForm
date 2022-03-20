using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var allPeople = SeedPeople.GetPeople();
            IEnumerable<Person> allPeople = SeedPeople.GetPeople();

            //1.Yol
            foreach (var item in allPeople)
            {
                lstAllPeople.Items.Add(item);
            }

            //2.Yol

            //lstAllPeople.DataSource = allPeople;

            IEnumerable<Country> allCountries = SeedCountry.GetCountries();
            foreach (var item in allCountries)
            {
                lstAllCountries.Items.Add(item);
            }

            IEnumerable<Country> allCountriesVoorComboBox = SeedCountry.Countries;
            foreach (var item in allCountriesVoorComboBox)
            {
                cmbCountry.Items.Add(item);
            }

        }

        private void btnFilterByAge_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Person> listPerAge = SeedPeople.People.Where(x => x.Age == Convert.ToInt32(txtFilter.Text)).ToList();
                lstDemo.DataSource = listPerAge;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilterByCountry_Click(object sender, EventArgs e)
        {
            //lstDemo.Items.Clear();

            //    Traditional Way
            //    IEnumerable<Person> allPeople = SeedPeople.People;
            //    foreach (var item in allPeople)
            //    {
            //    if (item.Country==Convert.ToInt32(txtFilter.Text))
            //    {
            //        lstDemo.Items.Add(item);
            //    }
            //    }

            // With Lambda

            try
            {
                IEnumerable<Person> list = SeedPeople.People.Where(x => x.Country == Convert.ToInt32(txtFilter.Text)).ToList();
                lstDemo.DataSource = list;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            txtFilter.Text = String.Empty;
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //     With Lambda
            //     int selected = cmbCountry.SelectedIndex + 1;
            //     IEnumerable<Person> list = SeedPeople.People.Where(x => x.Country == selected).ToList();
            //     lstDemo.DataSource = list;

            //      Classic Way

            lstDemo.Items.Clear();
                    int selected = cmbCountry.SelectedIndex + 1;
            IEnumerable<Person> people = SeedPeople.People;
            foreach (var item in people)
            {
                if (item.Country==selected)
                {
                    lstDemo.Items.Add(item);
                }
            }

        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {

            var findPerson = SeedPeople.People.Find(x=>x.Id==Convert.ToInt32(txtFilter.Text));
            lstDemo.Items.Add(findPerson);

        }
    }
}
