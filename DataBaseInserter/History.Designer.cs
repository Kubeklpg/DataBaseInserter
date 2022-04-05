namespace DataBaseInserter
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this._Car_Rental_v1_0DataSet = new DataBaseInserter._Car_Rental_v1_0DataSet();
            this.shortTermBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shortTermTableAdapter = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.ShortTermTableAdapter();
            this.tableAdapterManager = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.TableAdapterManager();
            this.shortTermBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.shortTermBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.shortTermDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortTermTableAdapter1 = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.ShortTermTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.carTableAdapter1 = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.CarTableAdapter();
            this.historyTableAdapter1 = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.HistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._Car_Rental_v1_0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortTermBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortTermBindingNavigator)).BeginInit();
            this.shortTermBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortTermDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _Car_Rental_v1_0DataSet
            // 
            this._Car_Rental_v1_0DataSet.DataSetName = "_Car_Rental_v1_0DataSet";
            this._Car_Rental_v1_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shortTermBindingSource
            // 
            this.shortTermBindingSource.DataMember = "ShortTerm";
            this.shortTermBindingSource.DataSource = this._Car_Rental_v1_0DataSet;
            // 
            // shortTermTableAdapter
            // 
            this.shortTermTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.EmployeTableAdapter = null;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.ShortTermTableAdapter = this.shortTermTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // shortTermBindingNavigator
            // 
            this.shortTermBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shortTermBindingNavigator.BindingSource = this.shortTermBindingSource;
            this.shortTermBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shortTermBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shortTermBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.shortTermBindingNavigatorSaveItem});
            this.shortTermBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shortTermBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shortTermBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shortTermBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shortTermBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shortTermBindingNavigator.Name = "shortTermBindingNavigator";
            this.shortTermBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shortTermBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.shortTermBindingNavigator.TabIndex = 0;
            this.shortTermBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
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
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // shortTermBindingNavigatorSaveItem
            // 
            this.shortTermBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shortTermBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shortTermBindingNavigatorSaveItem.Image")));
            this.shortTermBindingNavigatorSaveItem.Name = "shortTermBindingNavigatorSaveItem";
            this.shortTermBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.shortTermBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.shortTermBindingNavigatorSaveItem.Click += new System.EventHandler(this.shortTermBindingNavigatorSaveItem_Click);
            // 
            // shortTermDataGridView
            // 
            this.shortTermDataGridView.AutoGenerateColumns = false;
            this.shortTermDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shortTermDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.shortTermDataGridView.DataSource = this.shortTermBindingSource;
            this.shortTermDataGridView.Location = new System.Drawing.Point(0, 28);
            this.shortTermDataGridView.Name = "shortTermDataGridView";
            this.shortTermDataGridView.Size = new System.Drawing.Size(745, 201);
            this.shortTermDataGridView.TabIndex = 1;
            this.shortTermDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shortTermDataGridView_CellClick);
            this.shortTermDataGridView.SelectionChanged += new System.EventHandler(this.shortTermDataGridView_SelectionChanged);
            this.shortTermDataGridView.TabIndexChanged += new System.EventHandler(this.shortTermDataGridView_TabIndexChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Employe_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employe_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Users_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Users_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Car_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Car_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TimeEnd";
            this.dataGridViewTextBoxColumn5.HeaderText = "TimeEnd";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Payed";
            this.dataGridViewTextBoxColumn7.HeaderText = "Payed";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // shortTermTableAdapter1
            // 
            this.shortTermTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add selected row to History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // carTableAdapter1
            // 
            this.carTableAdapter1.ClearBeforeFill = true;
            // 
            // historyTableAdapter1
            // 
            this.historyTableAdapter1.ClearBeforeFill = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shortTermDataGridView);
            this.Controls.Add(this.shortTermBindingNavigator);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Car_Rental_v1_0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortTermBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortTermBindingNavigator)).EndInit();
            this.shortTermBindingNavigator.ResumeLayout(false);
            this.shortTermBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortTermDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Car_Rental_v1_0DataSet _Car_Rental_v1_0DataSet;
        private System.Windows.Forms.BindingSource shortTermBindingSource;
        private _Car_Rental_v1_0DataSetTableAdapters.ShortTermTableAdapter shortTermTableAdapter;
        private _Car_Rental_v1_0DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator shortTermBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton shortTermBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView shortTermDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private _Car_Rental_v1_0DataSetTableAdapters.ShortTermTableAdapter shortTermTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private _Car_Rental_v1_0DataSetTableAdapters.CarTableAdapter carTableAdapter1;
        private _Car_Rental_v1_0DataSetTableAdapters.HistoryTableAdapter historyTableAdapter1;
    }
}