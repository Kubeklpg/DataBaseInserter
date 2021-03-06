namespace DataBaseInserter
{
    partial class Cars
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
            this.label1 = new System.Windows.Forms.Label();
            this.Brands = new System.Windows.Forms.ComboBox();
            this.OtherCheckBox = new System.Windows.Forms.CheckBox();
            this.OtherTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.PriceHrTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceMonthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InsuranceTextBox = new System.Windows.Forms.TextBox();
            this.Insurance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._Car_Rental_v1_0DataSet = new DataBaseInserter._Car_Rental_v1_0DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.TableAdapterManager();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.CarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Car_Rental_v1_0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            // 
            // Brands
            // 
            this.Brands.FormattingEnabled = true;
            this.Brands.Items.AddRange(new object[] {
            "Mazda",
            "BWM",
            "Audi",
            "Toyota"});
            this.Brands.Location = new System.Drawing.Point(116, 22);
            this.Brands.Name = "Brands";
            this.Brands.Size = new System.Drawing.Size(121, 21);
            this.Brands.TabIndex = 1;
            // 
            // OtherCheckBox
            // 
            this.OtherCheckBox.AutoSize = true;
            this.OtherCheckBox.Location = new System.Drawing.Point(244, 25);
            this.OtherCheckBox.Name = "OtherCheckBox";
            this.OtherCheckBox.Size = new System.Drawing.Size(52, 17);
            this.OtherCheckBox.TabIndex = 2;
            this.OtherCheckBox.Text = "Other";
            this.OtherCheckBox.UseVisualStyleBackColor = true;
            this.OtherCheckBox.CheckedChanged += new System.EventHandler(this.OtherCheckBox_CheckedChanged);
            // 
            // OtherTextBox
            // 
            this.OtherTextBox.Location = new System.Drawing.Point(293, 22);
            this.OtherTextBox.Name = "OtherTextBox";
            this.OtherTextBox.Size = new System.Drawing.Size(100, 20);
            this.OtherTextBox.TabIndex = 3;
            this.OtherTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(116, 49);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(120, 20);
            this.ModelTextBox.TabIndex = 5;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(116, 75);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(120, 20);
            this.YearTextBox.TabIndex = 7;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(81, 78);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 6;
            this.Year.Text = "Year";
            // 
            // PriceHrTextBox
            // 
            this.PriceHrTextBox.Location = new System.Drawing.Point(117, 101);
            this.PriceHrTextBox.Name = "PriceHrTextBox";
            this.PriceHrTextBox.Size = new System.Drawing.Size(120, 20);
            this.PriceHrTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price/hr";
            // 
            // PriceMonthTextBox
            // 
            this.PriceMonthTextBox.Location = new System.Drawing.Point(117, 127);
            this.PriceMonthTextBox.Name = "PriceMonthTextBox";
            this.PriceMonthTextBox.Size = new System.Drawing.Size(120, 20);
            this.PriceMonthTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price/month";
            // 
            // InsuranceTextBox
            // 
            this.InsuranceTextBox.Location = new System.Drawing.Point(117, 153);
            this.InsuranceTextBox.Name = "InsuranceTextBox";
            this.InsuranceTextBox.Size = new System.Drawing.Size(120, 20);
            this.InsuranceTextBox.TabIndex = 12;
            // 
            // Insurance
            // 
            this.Insurance.AutoSize = true;
            this.Insurance.Location = new System.Drawing.Point(57, 156);
            this.Insurance.Name = "Insurance";
            this.Insurance.Size = new System.Drawing.Size(54, 13);
            this.Insurance.TabIndex = 13;
            this.Insurance.Text = "Insurance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Color";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(117, 179);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(120, 20);
            this.ColorTextBox.TabIndex = 14;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this._Car_Rental_v1_0DataSet;
            this.bindingSource1.Position = 0;
            // 
            // _Car_Rental_v1_0DataSet
            // 
            this._Car_Rental_v1_0DataSet.DataSetName = "_Car_Rental_v1_0DataSet";
            this._Car_Rental_v1_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this._Car_Rental_v1_0DataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeTableAdapter = null;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.ShortTermTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.Insurance);
            this.Controls.Add(this.InsuranceTextBox);
            this.Controls.Add(this.PriceMonthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceHrTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OtherTextBox);
            this.Controls.Add(this.OtherCheckBox);
            this.Controls.Add(this.Brands);
            this.Controls.Add(this.label1);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Car_Rental_v1_0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Brands;
        private System.Windows.Forms.CheckBox OtherCheckBox;
        private System.Windows.Forms.TextBox OtherTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.TextBox PriceHrTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceMonthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InsuranceTextBox;
        private System.Windows.Forms.Label Insurance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Button button1;
        private _Car_Rental_v1_0DataSet _Car_Rental_v1_0DataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private _Car_Rental_v1_0DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private _Car_Rental_v1_0DataSetTableAdapters.CarTableAdapter carTableAdapter;
    }
}