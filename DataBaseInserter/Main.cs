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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars Cars = new Cars();
            Cars.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employes employes = new Employes();
            employes.Show();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adresses adresses = new Adresses(); 
            adresses.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            position.Show();
        }
    }
}
