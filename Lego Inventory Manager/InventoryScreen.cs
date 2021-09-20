using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lego_Inventory_Manager
{
    public partial class InventoryScreen : Form
    {
        public InventoryScreen()
        {
            InitializeComponent();
        }

        private void brickBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brickBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDatabaseDataSet);

        }

        private void InventoryScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDatabaseDataSet.Brick' table. You can move, or remove it, as needed.
            this.brickTableAdapter.Fill(this.inventoryDatabaseDataSet.Brick);

        }

        private void brickDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
