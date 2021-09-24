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
            // TODO: This line of code loads data into the 'inventoryDatabaseDataSet.InventoryList' table. You can move, or remove it, as needed.
            this.inventoryListTableAdapter.Fill(this.inventoryDatabaseDataSet.InventoryList);
            this.inventoryListDataGridView.ReadOnly = true;
            this.brickDetailedTableAdapter.Fill(this.inventoryDatabaseDataSet.BrickDetailed);
            System.Diagnostics.Debug.WriteLine("Test");
        }

        private void brickDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventoryListDataGridView_SelectionChanged(Object sender, EventArgs e)
        {
            if (inventoryListDataGridView.CurrentRow != null)
            {
                int elementID = Int32.Parse(inventoryListDataGridView.CurrentRow.Cells[4].Value.ToString());
                System.Diagnostics.Debug.WriteLine("{0}", inventoryListDataGridView.CurrentRow.Cells[4].Value.ToString());

                var brickDataSet = brickDetailedTableAdapter.GetData();
                var foundBrick = brickDataSet.FindByBrickElementID(elementID);

                brickNameTextBox.Text = foundBrick.BrickName;
                brickIDTextBox.Text = foundBrick.BrickID.ToString();
                brickElementIDTextBox.Text = foundBrick.BrickElementID.ToString();
                colorNameTextBox.Text = foundBrick.ColorName;
                typeNameTextBox.Text = foundBrick.TypeName;
                quantityTextBox.Text = foundBrick.Quantity.ToString();
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
    }
}
