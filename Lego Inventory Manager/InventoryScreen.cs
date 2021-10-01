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

        static InventoryDatabaseDataSet.BrickDetailedDataTable brickDataSet;
        InventoryDatabaseDataSet.BrickDetailedRow currentBrick;

        public InventoryScreen()
        {
            InitializeComponent();
            brickDataSet = brickDetailedTableAdapter.GetData();
        }

        private void brickBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brickBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDatabaseDataSet);

        }

        private void InventoryScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDatabaseDataSet.InventoryList' table. You can move, or remove it, as needed.
            this.inventoryListTableAdapter.Fill(this.inventoryDatabaseDataSet.InventoryList);
            this.inventoryListDataGridView.ReadOnly = true;
            this.brickDetailedTableAdapter.Fill(this.inventoryDatabaseDataSet.BrickDetailed);
            currentBrick = brickDataSet.FindByBrickElementID(this.inventoryDatabaseDataSet.BrickDetailed[0].BrickElementID);
        }

        private void brickDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventoryListDataGridView_SelectionChanged(Object sender, EventArgs e)
        {
            if (inventoryListDataGridView.CurrentRow != null)
            {
                int elementID = Int32.Parse(inventoryListDataGridView.CurrentRow.Cells[4].Value.ToString());
                currentBrick = brickDataSet.FindByBrickElementID(elementID);
                this.brickDetailedTableAdapter.FillByBrickElementID(this.inventoryDatabaseDataSet.BrickDetailed, elementID);
            }
        }

        private void brickNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void brickElementIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void brickIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void brickIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void brickElementIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void brickNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void colorNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void colorNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void typeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form brickDetailedScreen = new BrickDetailedScreen(currentBrick, this);
            brickDetailedScreen.Show();
        }

        public void refreshInventoryScreen()
        {
            this.inventoryListTableAdapter.Fill(this.inventoryDatabaseDataSet.InventoryList);
            this.brickDetailedTableAdapter.Fill(this.inventoryDatabaseDataSet.BrickDetailed);
            this.Refresh();

        }
    }
}
