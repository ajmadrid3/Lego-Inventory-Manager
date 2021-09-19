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

        legoinventorymanagerEntities brickEntities;
        public InventoryScreen()
        {
            InitializeComponent();
        }

        private void brickDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            brickEntities = new legoinventorymanagerEntities();
            brickBindingSource.DataSource = brickEntities.brick.ToList();
        }

        private void brickBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            brickEntities.SaveChanges();
        }
    }
}
