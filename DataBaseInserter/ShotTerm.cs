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
    public partial class ShotTerm : Form
    {
        public ShotTerm()
        {
            InitializeComponent();
            this.employeTableAdapter1.FillBy(this._Car_Rental_v1_0DataSet1.Employe);
            this.usersTableAdapter1.FillBy(this._Car_Rental_v1_0DataSet1.Users);
            this.carTableAdapter1.FillBy(this._Car_Rental_v1_0DataSet1.Car);

        }
        private void ShotTerm_Load(object sender, EventArgs e)
        {
            
            
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeTableAdapter1.FillBy(this._Car_Rental_v1_0DataSet1.Employe);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCust = (int)usersTableAdapter1.idByLogin(CustomerComboBox.Text);
            int idCar = (int)carTableAdapter1.IdByModel(CarComboBox.Text);
            int idEmmplo = (int)employeTableAdapter1.IdBySurname(EmployeComboBox.Text);
            int payed = 0;
            string date = Cal.SelectionEnd.ToShortDateString();

            
            double price = Convert.ToDouble(PriceTextBox.Text);
            if (checkBox1.Checked)
            {
                payed = 1;
            }
            shortTermTableAdapter1.Insert(idEmmplo, idCust, idCar,Convert.ToDateTime(date), price, payed);
            carTableAdapter1.UpdateQuery(idCar);
            MessageBox.Show("Created row");
        }
    }
}
