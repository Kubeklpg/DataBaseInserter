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
    public partial class Employes : Form
    {
        public Employes()
        {
            InitializeComponent();
        }

        private void Employes_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_Car_Rental_v1_0DataSet1.Position' . Możesz go przenieść lub usunąć.
            this.positionTableAdapter1.Fill(this._Car_Rental_v1_0DataSet1.Position);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_Car_Rental_v1_0DataSet1.Addres' . Możesz go przenieść lub usunąć.
            this.addresTableAdapter.Fill(this._Car_Rental_v1_0DataSet1.Addres);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPos = (int)positionTableAdapter1.IdFromName(comboBox2.Text);
            int idAdr = (int)addresTableAdapter.IdByCity(comboBox1.Text);
            employeTableAdapter1.Insert(idPos, LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text, SurnameTextBox.Text, PhoneNumberTextBox.Text, idAdr);
            MessageBox.Show("Inserted an Employe");
        }
    }
}
