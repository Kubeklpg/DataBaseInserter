namespace DataBaseInserter
{
    partial class ShotTerm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmployeComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarDataBaseSource = new System.Windows.Forms.BindingSource(this.components);
            this._Car_Rental_v1_0DataSet1 = new DataBaseInserter._Car_Rental_v1_0DataSet();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.UserSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarComboBox = new System.Windows.Forms.ComboBox();
            this.CarSource = new System.Windows.Forms.BindingSource(this.components);
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Cal = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.employeTableAdapter1 = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.EmployeTableAdapter();
            this.usersTableAdapter1 = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.UsersTableAdapter();
            this.carTableAdapter1 = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.CarTableAdapter();
            this.shortTermTableAdapter1 = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.ShortTermTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDataBaseSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Car_Rental_v1_0DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of end";
            // 
            // EmployeComboBox
            // 
            this.EmployeComboBox.DataSource = this.EmployeSource;
            this.EmployeComboBox.DisplayMember = "Surname";
            this.EmployeComboBox.FormattingEnabled = true;
            this.EmployeComboBox.Location = new System.Drawing.Point(324, 115);
            this.EmployeComboBox.Name = "EmployeComboBox";
            this.EmployeComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmployeComboBox.TabIndex = 6;
            this.EmployeComboBox.ValueMember = "id";
            // 
            // EmployeSource
            // 
            this.EmployeSource.DataMember = "Employe";
            this.EmployeSource.DataSource = this.CarDataBaseSource;
            // 
            // CarDataBaseSource
            // 
            this.CarDataBaseSource.DataSource = this._Car_Rental_v1_0DataSet1;
            this.CarDataBaseSource.Position = 0;
            // 
            // _Car_Rental_v1_0DataSet1
            // 
            this._Car_Rental_v1_0DataSet1.DataSetName = "_Car_Rental_v1_0DataSet";
            this._Car_Rental_v1_0DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.DataSource = this.UserSource;
            this.CustomerComboBox.DisplayMember = "loginName";
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(324, 143);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(121, 21);
            this.CustomerComboBox.TabIndex = 7;
            this.CustomerComboBox.ValueMember = "id";
            // 
            // UserSource
            // 
            this.UserSource.DataMember = "Users";
            this.UserSource.DataSource = this.CarDataBaseSource;
            // 
            // CarComboBox
            // 
            this.CarComboBox.DataSource = this.CarSource;
            this.CarComboBox.DisplayMember = "Model";
            this.CarComboBox.FormattingEnabled = true;
            this.CarComboBox.Location = new System.Drawing.Point(324, 171);
            this.CarComboBox.Name = "CarComboBox";
            this.CarComboBox.Size = new System.Drawing.Size(121, 21);
            this.CarComboBox.TabIndex = 8;
            this.CarComboBox.ValueMember = "id";
            // 
            // CarSource
            // 
            this.CarSource.DataMember = "Car";
            this.CarSource.DataSource = this.CarDataBaseSource;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(324, 199);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.PriceTextBox.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(324, 233);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Cal
            // 
            this.Cal.Location = new System.Drawing.Point(324, 259);
            this.Cal.Name = "Cal";
            this.Cal.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeTableAdapter1
            // 
            this.employeTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // carTableAdapter1
            // 
            this.carTableAdapter1.ClearBeforeFill = true;
            // 
            // shortTermTableAdapter1
            // 
            this.shortTermTableAdapter1.ClearBeforeFill = true;
            // 
            // ShotTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cal);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.CarComboBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.EmployeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShotTerm";
            this.Text = "ShotTerm";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDataBaseSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Car_Rental_v1_0DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EmployeComboBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MonthCalendar Cal;
        private System.Windows.Forms.Button button1;
        private _Car_Rental_v1_0DataSet _Car_Rental_v1_0DataSet1;
        private System.Windows.Forms.BindingSource EmployeSource;
        private System.Windows.Forms.BindingSource CarDataBaseSource;
        private System.Windows.Forms.BindingSource UserSource;
        private System.Windows.Forms.BindingSource CarSource;
        private _Car_Rental_v1_0DataSetTableAdapters.EmployeTableAdapter employeTableAdapter1;
        private _Car_Rental_v1_0DataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private _Car_Rental_v1_0DataSetTableAdapters.CarTableAdapter carTableAdapter1;
        private System.Windows.Forms.ComboBox CarComboBox;
        private _Car_Rental_v1_0DataSetTableAdapters.ShortTermTableAdapter shortTermTableAdapter1;
    }
}