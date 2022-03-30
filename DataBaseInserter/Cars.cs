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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double PriceHr = Convert.ToDouble(PriceHrTextBox.Text);
            double PriceMonth = Convert.ToDouble(PriceMonthTextBox.Text);
            double Insurance = Convert.ToDouble(InsuranceTextBox.Text);
            if (!OtherCheckBox.Checked)
            {
                carTableAdapter.Insert(Brands.Text, ModelTextBox.Text, YearTextBox.Text, PriceHr, PriceMonth, Insurance, 1, ColorTextBox.Text, 1);
                MessageBox.Show("Udało dodać się auto!");
            }
            else
            {
                carTableAdapter.Insert(OtherTextBox.Text, ModelTextBox.Text, YearTextBox.Text, PriceHr, PriceMonth, Insurance, 1, ColorTextBox.Text, 1);
                MessageBox.Show("Udało dodać się auto!");
            }
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_Car_Rental_v1_0DataSet.Car' . Możesz go przenieść lub usunąć.
            this.carTableAdapter.Fill(this._Car_Rental_v1_0DataSet.Car);

        }

        private void OtherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OtherTextBox.Visible = !OtherTextBox.Visible;
            Brands.Enabled = !Brands.Enabled;
        }
    }
}
