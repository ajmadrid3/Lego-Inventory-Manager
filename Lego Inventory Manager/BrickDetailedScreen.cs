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
    public partial class BrickDetailedScreen : Form
    {

        InventoryDatabaseDataSet.BrickDetailedRow brick;
        InventoryScreen inventory;
        bool quantityChaged = false;
        int quantity;

        public BrickDetailedScreen(InventoryDatabaseDataSet.BrickDetailedRow sentBrick, InventoryScreen mainScreen)
        {
            InitializeComponent();
            brick = sentBrick;
            inventory = mainScreen;
        }

        private void BrickDetailedScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDatabaseDataSet.BrickDetailed' table. You can move, or remove it, as needed.
            this.brickDetailedTableAdapter.FillByBrickElementID(this.inventoryDatabaseDataSet.BrickDetailed, brick.BrickElementID);
        }


        private void quantityTextBox1_TextChanged(object sender, EventArgs e)
        {
            quantityChaged = true;
            quantity = Int16.Parse(quantityTextBox.Text);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(quantityChaged)
            {
                System.Diagnostics.Debug.WriteLine("{0}", quantityChaged);
                try
                {
                    this.Validate();
                    this.brickDetailedBindingSource.EndEdit();
                    this.brickDetailedTableAdapter.UpdateQuantity(quantity, brick.BrickElementID);
                    MessageBox.Show("Quantity Updated");
                    inventory.refreshInventoryScreen();
                    this.Close();

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update Failed");
                }
            }
            
        }


    }
}
