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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.addresTableAdapter1.FillBy1(this._Car_Rental_v1_0DataSet.Addres);
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_Car_Rental_v1_0DataSet2.Addres' . Możesz go przenieść lub usunąć.
            this.addresTableAdapter1.Fill(this._Car_Rental_v1_0DataSet2.Addres);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdAdr = (int)addresTableAdapter1.IdByCity(comboBox1.Text);
            usersTableAdapter1.Insert(IdAdr,LoginTextBox.Text,PasswordTextBox.Text,NameTextBox.Text,SurnameTextBox.Text,CardTextBox.Text,PhoneTextBox.Text);
            MessageBox.Show("Inserted Customer");
        }
    }
}
