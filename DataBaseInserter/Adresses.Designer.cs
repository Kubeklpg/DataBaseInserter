namespace DataBaseInserter
{
    partial class Adresses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.ProvinceTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.addresTableAdapter1 = new DataBaseInserter._Car_Rental_v1_0DataSetTableAdapters.AddresTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Province";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip Code";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(103, 49);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountryTextBox.TabIndex = 5;
            // 
            // ProvinceTextBox
            // 
            this.ProvinceTextBox.Location = new System.Drawing.Point(103, 76);
            this.ProvinceTextBox.Name = "ProvinceTextBox";
            this.ProvinceTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProvinceTextBox.TabIndex = 6;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(103, 102);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 7;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(103, 128);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.StreetTextBox.TabIndex = 8;
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(103, 154);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZipCodeTextBox.TabIndex = 9;
            // 
            // addresTableAdapter1
            // 
            this.addresTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ZipCodeTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ProvinceTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Adresses";
            this.Text = "Adresses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox ProvinceTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private _Car_Rental_v1_0DataSetTableAdapters.AddresTableAdapter addresTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}