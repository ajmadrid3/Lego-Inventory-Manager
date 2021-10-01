
namespace Lego_Inventory_Manager
{
    partial class BrickDetailedScreen
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
            System.Windows.Forms.Label brickElementIDLabel1;
            System.Windows.Forms.Label colorNameLabel1;
            System.Windows.Forms.Label typeNameLabel1;
            System.Windows.Forms.Label quantityLabel1;
            this.inventoryDatabaseDataSet = new Lego_Inventory_Manager.InventoryDatabaseDataSet();
            this.brickDetailedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brickDetailedTableAdapter = new Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.BrickDetailedTableAdapter();
            this.tableAdapterManager = new Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.brickNameTextBox1 = new System.Windows.Forms.TextBox();
            this.brickIDTextBox1 = new System.Windows.Forms.TextBox();
            this.brickElementIDTextBox1 = new System.Windows.Forms.TextBox();
            this.colorNameTextBox1 = new System.Windows.Forms.TextBox();
            this.typeNameTextBox1 = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            brickNameLabel = new System.Windows.Forms.Label();
            brickIDLabel = new System.Windows.Forms.Label();
            brickElementIDLabel1 = new System.Windows.Forms.Label();
            colorNameLabel1 = new System.Windows.Forms.Label();
            typeNameLabel1 = new System.Windows.Forms.Label();
            quantityLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickDetailedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryDatabaseDataSet
            // 
            this.inventoryDatabaseDataSet.DataSetName = "InventoryDatabaseDataSet";
            this.inventoryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brickDetailedBindingSource
            // 
            this.brickDetailedBindingSource.DataMember = "BrickDetailed";
            this.brickDetailedBindingSource.DataSource = this.inventoryDatabaseDataSet;
            // 
            // brickDetailedTableAdapter
            // 
            this.brickDetailedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrickTableAdapter = null;
            this.tableAdapterManager.ColorTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lego_Inventory_Manager.InventoryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Modify the quantity of the brick";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(472, 230);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(174, 64);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // brickNameLabel
            // 
            brickNameLabel.AutoSize = true;
            brickNameLabel.Location = new System.Drawing.Point(127, 181);
            brickNameLabel.Name = "brickNameLabel";
            brickNameLabel.Size = new System.Drawing.Size(65, 13);
            brickNameLabel.TabIndex = 21;
            brickNameLabel.Text = "Brick Name:";
            // 
            // brickNameTextBox1
            // 
            this.brickNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "BrickName", true));
            this.brickNameTextBox1.Location = new System.Drawing.Point(222, 178);
            this.brickNameTextBox1.Name = "brickNameTextBox1";
            this.brickNameTextBox1.ReadOnly = true;
            this.brickNameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.brickNameTextBox1.TabIndex = 22;
            // 
            // brickIDLabel
            // 
            brickIDLabel.AutoSize = true;
            brickIDLabel.Location = new System.Drawing.Point(127, 207);
            brickIDLabel.Name = "brickIDLabel";
            brickIDLabel.Size = new System.Drawing.Size(48, 13);
            brickIDLabel.TabIndex = 23;
            brickIDLabel.Text = "Brick ID:";
            // 
            // brickIDTextBox1
            // 
            this.brickIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "BrickID", true));
            this.brickIDTextBox1.Location = new System.Drawing.Point(222, 204);
            this.brickIDTextBox1.Name = "brickIDTextBox1";
            this.brickIDTextBox1.ReadOnly = true;
            this.brickIDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.brickIDTextBox1.TabIndex = 24;
            // 
            // brickElementIDLabel1
            // 
            brickElementIDLabel1.AutoSize = true;
            brickElementIDLabel1.Location = new System.Drawing.Point(127, 233);
            brickElementIDLabel1.Name = "brickElementIDLabel1";
            brickElementIDLabel1.Size = new System.Drawing.Size(89, 13);
            brickElementIDLabel1.TabIndex = 25;
            brickElementIDLabel1.Text = "Brick Element ID:";
            // 
            // brickElementIDTextBox1
            // 
            this.brickElementIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "BrickElementID", true));
            this.brickElementIDTextBox1.Location = new System.Drawing.Point(222, 230);
            this.brickElementIDTextBox1.Name = "brickElementIDTextBox1";
            this.brickElementIDTextBox1.ReadOnly = true;
            this.brickElementIDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.brickElementIDTextBox1.TabIndex = 26;
            // 
            // colorNameLabel1
            // 
            colorNameLabel1.AutoSize = true;
            colorNameLabel1.Location = new System.Drawing.Point(127, 259);
            colorNameLabel1.Name = "colorNameLabel1";
            colorNameLabel1.Size = new System.Drawing.Size(65, 13);
            colorNameLabel1.TabIndex = 27;
            colorNameLabel1.Text = "Color Name:";
            // 
            // colorNameTextBox1
            // 
            this.colorNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "ColorName", true));
            this.colorNameTextBox1.Location = new System.Drawing.Point(222, 256);
            this.colorNameTextBox1.Name = "colorNameTextBox1";
            this.colorNameTextBox1.ReadOnly = true;
            this.colorNameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.colorNameTextBox1.TabIndex = 28;
            // 
            // typeNameLabel1
            // 
            typeNameLabel1.AutoSize = true;
            typeNameLabel1.Location = new System.Drawing.Point(127, 285);
            typeNameLabel1.Name = "typeNameLabel1";
            typeNameLabel1.Size = new System.Drawing.Size(65, 13);
            typeNameLabel1.TabIndex = 29;
            typeNameLabel1.Text = "Type Name:";
            // 
            // typeNameTextBox1
            // 
            this.typeNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "TypeName", true));
            this.typeNameTextBox1.Location = new System.Drawing.Point(222, 282);
            this.typeNameTextBox1.Name = "typeNameTextBox1";
            this.typeNameTextBox1.ReadOnly = true;
            this.typeNameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.typeNameTextBox1.TabIndex = 30;
            // 
            // quantityLabel1
            // 
            quantityLabel1.AutoSize = true;
            quantityLabel1.Location = new System.Drawing.Point(127, 311);
            quantityLabel1.Name = "quantityLabel1";
            quantityLabel1.Size = new System.Drawing.Size(49, 13);
            quantityLabel1.TabIndex = 31;
            quantityLabel1.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brickDetailedBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(222, 308);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 32;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox1_TextChanged);
            // 
            // BrickDetailedScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(brickNameLabel);
            this.Controls.Add(this.brickNameTextBox1);
            this.Controls.Add(brickIDLabel);
            this.Controls.Add(this.brickIDTextBox1);
            this.Controls.Add(brickElementIDLabel1);
            this.Controls.Add(this.brickElementIDTextBox1);
            this.Controls.Add(colorNameLabel1);
            this.Controls.Add(this.colorNameTextBox1);
            this.Controls.Add(typeNameLabel1);
            this.Controls.Add(this.typeNameTextBox1);
            this.Controls.Add(quantityLabel1);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Name = "BrickDetailedScreen";
            this.Text = "BrickDetailedScreen";
            this.Load += new System.EventHandler(this.BrickDetailedScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickDetailedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventoryDatabaseDataSet inventoryDatabaseDataSet;
        private System.Windows.Forms.BindingSource brickDetailedBindingSource;
        private InventoryDatabaseDataSetTableAdapters.BrickDetailedTableAdapter brickDetailedTableAdapter;
        private InventoryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox brickNameTextBox1;
        private System.Windows.Forms.TextBox brickIDTextBox1;
        private System.Windows.Forms.TextBox brickElementIDTextBox1;
        private System.Windows.Forms.TextBox colorNameTextBox1;
        private System.Windows.Forms.TextBox typeNameTextBox1;
        private System.Windows.Forms.TextBox quantityTextBox;
    }
}