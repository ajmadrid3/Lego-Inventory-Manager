
namespace Lego_Inventory_Manager
{
    partial class InventoryScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label brickNameLabel;
            System.Windows.Forms.Label brickIDLabel;
            System.Windows.Forms.Label brickElementIDLabel;
            System.Windows.Forms.Label colorNameLabel;
            System.Windows.Forms.Label typeNameLabel;
            System.Windows.Forms.Label quantityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryScreen));
            this.brickBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.brickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDatabaseDataSet = new Lego_Inventory_Manager.InventoryDatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.brickBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.brickNameTextBox = new System.Windows.Forms.TextBox();
            this.brickDetailedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brickIDTextBox = new System.Windows.Forms.TextBox();
            this.brickElementIDTextBox = new System.Windows.Forms.TextBox();
            this.colorNameTextBox = new System.Windows.Forms.TextBox();
            this.typeNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.inventoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brickTableAdapter = new Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.BrickTableAdapter();
            this.tableAdapterManager = new Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.brickDetailedTableAdapter = new Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.BrickDetailedTableAdapter();
            this.tableAdapterManager1 = new Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.inventoryListTableAdapter = new Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.InventoryListTableAdapter();
            this.inventoryListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            brickNameLabel = new System.Windows.Forms.Label();
            brickIDLabel = new System.Windows.Forms.Label();
            brickElementIDLabel = new System.Windows.Forms.Label();
            colorNameLabel = new System.Windows.Forms.Label();
            typeNameLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingNavigator)).BeginInit();
            this.brickBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickDetailedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // brickNameLabel
            // 
            brickNameLabel.AutoSize = true;
            brickNameLabel.Location = new System.Drawing.Point(553, 141);
            brickNameLabel.Name = "brickNameLabel";
            brickNameLabel.Size = new System.Drawing.Size(65, 13);
            brickNameLabel.TabIndex = 2;
            brickNameLabel.Text = "Brick Name:";
            brickNameLabel.Click += new System.EventHandler(this.brickNameLabel_Click);
            // 
            // brickIDLabel
            // 
            brickIDLabel.AutoSize = true;
            brickIDLabel.Location = new System.Drawing.Point(553, 167);
            brickIDLabel.Name = "brickIDLabel";
            brickIDLabel.Size = new System.Drawing.Size(48, 13);
            brickIDLabel.TabIndex = 4;
            brickIDLabel.Text = "Brick ID:";
            brickIDLabel.Click += new System.EventHandler(this.brickIDLabel_Click);
            // 
            // brickElementIDLabel
            // 
            brickElementIDLabel.AutoSize = true;
            brickElementIDLabel.Location = new System.Drawing.Point(553, 193);
            brickElementIDLabel.Name = "brickElementIDLabel";
            brickElementIDLabel.Size = new System.Drawing.Size(89, 13);
            brickElementIDLabel.TabIndex = 6;
            brickElementIDLabel.Text = "Brick Element ID:";
            brickElementIDLabel.Click += new System.EventHandler(this.brickElementIDLabel_Click);
            // 
            // colorNameLabel
            // 
            colorNameLabel.AutoSize = true;
            colorNameLabel.Location = new System.Drawing.Point(553, 219);
            colorNameLabel.Name = "colorNameLabel";
            colorNameLabel.Size = new System.Drawing.Size(65, 13);
            colorNameLabel.TabIndex = 8;
            colorNameLabel.Text = "Color Name:";
            colorNameLabel.Click += new System.EventHandler(this.colorNameLabel_Click);
            // 
            // typeNameLabel
            // 
            typeNameLabel.AutoSize = true;
            typeNameLabel.Location = new System.Drawing.Point(553, 245);
            typeNameLabel.Name = "typeNameLabel";
            typeNameLabel.Size = new System.Drawing.Size(65, 13);
            typeNameLabel.TabIndex = 10;
            typeNameLabel.Text = "Type Name:";
            typeNameLabel.Click += new System.EventHandler(this.typeNameLabel_Click);
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(553, 271);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 12;
            quantityLabel.Text = "Quantity:";
            quantityLabel.Click += new System.EventHandler(this.quantityLabel_Click);
            // 
            // brickBindingNavigator
            // 
            this.brickBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.brickBindingNavigator.BindingSource = this.brickBindingSource;
            this.brickBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.brickBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.brickBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.brickBindingNavigatorSaveItem});
            this.brickBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.brickBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.brickBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.brickBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.brickBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.brickBindingNavigator.Name = "brickBindingNavigator";
            this.brickBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.brickBindingNavigator.Size = new System.Drawing.Size(815, 25);
            this.brickBindingNavigator.TabIndex = 0;
            this.brickBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // brickBindingSource
            // 
            this.brickBindingSource.DataMember = "Brick";
            this.brickBindingSource.DataSource = this.inventoryDatabaseDataSet;
            // 
            // inventoryDatabaseDataSet
            // 
            this.inventoryDatabaseDataSet.DataSetName = "InventoryDatabaseDataSet";
            this.inventoryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // brickBindingNavigatorSaveItem
            // 
            this.brickBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brickBindingNavigatorSaveItem.Enabled = false;
            this.brickBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("brickBindingNavigatorSaveItem.Image")));
            this.brickBindingNavigatorSaveItem.Name = "brickBindingNavigatorSaveItem";
            this.brickBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.brickBindingNavigatorSaveItem.Text = "Save Data";
            this.brickBindingNavigatorSaveItem.Click += new System.EventHandler(this.brickBindingNavigatorSaveItem_Click);
            // 
            // brickNameTextBox
            // 
            this.brickNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "BrickName", true));
            this.brickNameTextBox.Location = new System.Drawing.Point(648, 138);
            this.brickNameTextBox.Name = "brickNameTextBox";
            this.brickNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.brickNameTextBox.TabIndex = 3;
            this.brickNameTextBox.TextChanged += new System.EventHandler(this.brickNameTextBox_TextChanged);
            // 
            // brickDetailedBindingSource
            // 
            this.brickDetailedBindingSource.DataMember = "BrickDetailed";
            this.brickDetailedBindingSource.DataSource = this.inventoryDatabaseDataSet;
            // 
            // brickIDTextBox
            // 
            this.brickIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "BrickID", true));
            this.brickIDTextBox.Location = new System.Drawing.Point(648, 164);
            this.brickIDTextBox.Name = "brickIDTextBox";
            this.brickIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.brickIDTextBox.TabIndex = 5;
            this.brickIDTextBox.TextChanged += new System.EventHandler(this.brickIDTextBox_TextChanged);
            // 
            // brickElementIDTextBox
            // 
            this.brickElementIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "BrickElementID", true));
            this.brickElementIDTextBox.Location = new System.Drawing.Point(648, 190);
            this.brickElementIDTextBox.Name = "brickElementIDTextBox";
            this.brickElementIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.brickElementIDTextBox.TabIndex = 7;
            this.brickElementIDTextBox.TextChanged += new System.EventHandler(this.brickElementIDTextBox_TextChanged);
            // 
            // colorNameTextBox
            // 
            this.colorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "ColorName", true));
            this.colorNameTextBox.Location = new System.Drawing.Point(648, 216);
            this.colorNameTextBox.Name = "colorNameTextBox";
            this.colorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorNameTextBox.TabIndex = 9;
            this.colorNameTextBox.TextChanged += new System.EventHandler(this.colorNameTextBox_TextChanged);
            // 
            // typeNameTextBox
            // 
            this.typeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "TypeName", true));
            this.typeNameTextBox.Location = new System.Drawing.Point(648, 242);
            this.typeNameTextBox.Name = "typeNameTextBox";
            this.typeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeNameTextBox.TabIndex = 11;
            this.typeNameTextBox.TextChanged += new System.EventHandler(this.typeNameTextBox_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(648, 268);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 13;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // inventoryListBindingSource
            // 
            this.inventoryListBindingSource.DataMember = "InventoryList";
            this.inventoryListBindingSource.DataSource = this.inventoryDatabaseDataSet;
            // 
            // brickTableAdapter
            // 
            this.brickTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrickTableAdapter = this.brickTableAdapter;
            this.tableAdapterManager.ColorTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // brickDetailedTableAdapter
            // 
            this.brickDetailedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BrickTableAdapter = null;
            this.tableAdapterManager1.ColorTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.TypeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryListTableAdapter
            // 
            this.inventoryListTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryListDataGridView
            // 
            this.inventoryListDataGridView.AutoGenerateColumns = false;
            this.inventoryListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.inventoryListDataGridView.DataSource = this.inventoryListBindingSource;
            this.inventoryListDataGridView.Location = new System.Drawing.Point(38, 122);
            this.inventoryListDataGridView.Name = "inventoryListDataGridView";
            this.inventoryListDataGridView.Size = new System.Drawing.Size(446, 220);
            this.inventoryListDataGridView.TabIndex = 13;
            this.inventoryListDataGridView.SelectionChanged += new System.EventHandler(this.inventoryListDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BrickName";
            this.dataGridViewTextBoxColumn1.HeaderText = "BrickName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ColorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ColorName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn4.HeaderText = "TypeName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BrickElementID";
            this.dataGridViewTextBoxColumn6.HeaderText = "BrickElementID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // InventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 448);
            this.Controls.Add(this.inventoryListDataGridView);
            this.Controls.Add(brickNameLabel);
            this.Controls.Add(this.brickNameTextBox);
            this.Controls.Add(brickIDLabel);
            this.Controls.Add(this.brickIDTextBox);
            this.Controls.Add(brickElementIDLabel);
            this.Controls.Add(this.brickElementIDTextBox);
            this.Controls.Add(colorNameLabel);
            this.Controls.Add(this.colorNameTextBox);
            this.Controls.Add(typeNameLabel);
            this.Controls.Add(this.typeNameTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.brickBindingNavigator);
            this.Name = "InventoryScreen";
            this.Text = "InventoryScreen";
            this.Load += new System.EventHandler(this.InventoryScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingNavigator)).EndInit();
            this.brickBindingNavigator.ResumeLayout(false);
            this.brickBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickDetailedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventoryDatabaseDataSet inventoryDatabaseDataSet;
        private System.Windows.Forms.BindingSource brickBindingSource;
        private InventoryDatabaseDataSetTableAdapters.BrickTableAdapter brickTableAdapter;
        private InventoryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator brickBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton brickBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource brickDetailedBindingSource;
        private InventoryDatabaseDataSetTableAdapters.BrickDetailedTableAdapter brickDetailedTableAdapter;
        private System.Windows.Forms.BindingSource inventoryListBindingSource;
        private System.Windows.Forms.TextBox brickNameTextBox;
        private System.Windows.Forms.TextBox brickIDTextBox;
        private System.Windows.Forms.TextBox brickElementIDTextBox;
        private System.Windows.Forms.TextBox colorNameTextBox;
        private System.Windows.Forms.TextBox typeNameTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private InventoryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private InventoryDatabaseDataSetTableAdapters.InventoryListTableAdapter inventoryListTableAdapter;
        private System.Windows.Forms.DataGridView inventoryListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}