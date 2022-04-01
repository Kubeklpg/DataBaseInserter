using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseInserter
{
    public partial class Adresses : Form
    {
        public Adresses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addresTableAdapter1.Insert(CountryTextBox.Text, CityTextBox.Text, StreetTextBox.Text,ProvinceTextBox.Text, ZipCodeTextBox.Text);
            MessageBox.Show("Succeffully added addres");
        }
    }
}
