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
    public partial class History : Form
    {
        int shortTermToDelete;
        int CarToUpdate;
        public History()
        {
            InitializeComponent();
        }

        private void shortTermBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shortTermBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Car_Rental_v1_0DataSet);

        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_Car_Rental_v1_0DataSet.ShortTerm' . Możesz go przenieść lub usunąć.
            this.shortTermTableAdapter.Fill(this._Car_Rental_v1_0DataSet.ShortTerm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carTableAdapter1.SetAvailableTrue(CarToUpdate);
            shortTermTableAdapter.DeleteQuery(shortTermToDelete);
            historyTableAdapter1.Insert(shortTermToDelete);
        }

        private void shortTermDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void shortTermDataGridView_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void shortTermDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int rowIndex = shortTermDataGridView.CurrentCell.RowIndex;

                shortTermToDelete =(int) shortTermDataGridView.Rows[rowIndex].Cells[0].Value;
                try
                {
                    CarToUpdate = (int)shortTermDataGridView.Rows[rowIndex].Cells[3].Value;
                }
                catch
                {

                }
                
        }
    }
}
