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
    public partial class Position : Form
    {
        public Position()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double wage = Convert.ToDouble(WageTextBox.Text);
            positionTableAdapter1.Insert(NameTextBox.Text,wage);
            MessageBox.Show("Postion added");
        }
    }
}
