namespace Task1.UI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrintToExcelButton = new System.Windows.Forms.Button();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LoadCsvFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoadDbButton = new System.Windows.Forms.Button();
            this.AddDataToDbButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateFilterTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LastNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MiddleNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CityFilterTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CountryFilterTextBox = new System.Windows.Forms.TextBox();
            this.ClearFilterButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FirstNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintToExcelButton
            // 
            this.PrintToExcelButton.Enabled = false;
            this.PrintToExcelButton.Location = new System.Drawing.Point(167, 34);
            this.PrintToExcelButton.Name = "PrintToExcelButton";
            this.PrintToExcelButton.Size = new System.Drawing.Size(149, 23);
            this.PrintToExcelButton.TabIndex = 0;
            this.PrintToExcelButton.Text = "Print to Excel";
            this.PrintToExcelButton.UseVisualStyleBackColor = true;
            this.PrintToExcelButton.Click += new System.EventHandler(this.PrintToExcelButton_Click);
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.Size = new System.Drawing.Size(667, 361);
            this.dataGridViewPeople.TabIndex = 1;
            this.dataGridViewPeople.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewPeople_RowsAdded);
            this.dataGridViewPeople.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewPeople_RowsRemoved);
            this.dataGridViewPeople.SelectionChanged += new System.EventHandler(this.dataGridViewPeople_SelectionChanged);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(688, 79);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(100, 20);
            this.textBoxData.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(688, 162);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(688, 123);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(688, 201);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddleName.TabIndex = 5;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(688, 284);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 6;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(688, 245);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountry.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date (dd.mm.yyyy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Middle Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Country";
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Location = new System.Drawing.Point(694, 44);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(82, 13);
            this.ChangeLabel.TabIndex = 14;
            this.ChangeLabel.Text = "Change records";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(688, 310);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 24);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Location = new System.Drawing.Point(688, 340);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(100, 23);
            this.UpdateButton.TabIndex = 19;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(688, 369);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LoadCsvFileButton
            // 
            this.LoadCsvFileButton.Location = new System.Drawing.Point(12, 5);
            this.LoadCsvFileButton.Name = "LoadCsvFileButton";
            this.LoadCsvFileButton.Size = new System.Drawing.Size(149, 23);
            this.LoadCsvFileButton.TabIndex = 21;
            this.LoadCsvFileButton.Text = "Load .csv File";
            this.LoadCsvFileButton.UseVisualStyleBackColor = true;
            this.LoadCsvFileButton.Click += new System.EventHandler(this.LoadCsvFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Data files|*.csv";
            // 
            // LoadDbButton
            // 
            this.LoadDbButton.Location = new System.Drawing.Point(167, 5);
            this.LoadDbButton.Name = "LoadDbButton";
            this.LoadDbButton.Size = new System.Drawing.Size(149, 23);
            this.LoadDbButton.TabIndex = 22;
            this.LoadDbButton.Text = "Load Database";
            this.LoadDbButton.UseVisualStyleBackColor = true;
            this.LoadDbButton.Click += new System.EventHandler(this.LoadDbButton_Click);
            // 
            // AddDataToDbButton
            // 
            this.AddDataToDbButton.Enabled = false;
            this.AddDataToDbButton.Location = new System.Drawing.Point(12, 34);
            this.AddDataToDbButton.Name = "AddDataToDbButton";
            this.AddDataToDbButton.Size = new System.Drawing.Size(149, 23);
            this.AddDataToDbButton.TabIndex = 23;
            this.AddDataToDbButton.Text = "Add Data to Database";
            this.AddDataToDbButton.UseVisualStyleBackColor = true;
            this.AddDataToDbButton.Click += new System.EventHandler(this.AddDataToDbButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(685, 398);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(103, 26);
            this.ClearButton.TabIndex = 24;
            this.ClearButton.Text = "Clear Text Boxes";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(13, 488);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 25;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(13, 431);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(69, 13);
            this.FilterLabel.TabIndex = 26;
            this.FilterLabel.Text = "Data Filtering";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Date";
            // 
            // DateFilterTextBox
            // 
            this.DateFilterTextBox.Location = new System.Drawing.Point(16, 466);
            this.DateFilterTextBox.Name = "DateFilterTextBox";
            this.DateFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateFilterTextBox.TabIndex = 27;
            this.DateFilterTextBox.TextChanged += new System.EventHandler(this.DateFilterTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Last Name";
            // 
            // LastNameFilterTextBox
            // 
            this.LastNameFilterTextBox.Location = new System.Drawing.Point(228, 467);
            this.LastNameFilterTextBox.Name = "LastNameFilterTextBox";
            this.LastNameFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameFilterTextBox.TabIndex = 29;
            this.LastNameFilterTextBox.TextChanged += new System.EventHandler(this.DateFilterTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Middle Name";
            // 
            // MiddleNameFilterTextBox
            // 
            this.MiddleNameFilterTextBox.Location = new System.Drawing.Point(334, 466);
            this.MiddleNameFilterTextBox.Name = "MiddleNameFilterTextBox";
            this.MiddleNameFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleNameFilterTextBox.TabIndex = 33;
            this.MiddleNameFilterTextBox.TextChanged += new System.EventHandler(this.DateFilterTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "City";
            // 
            // CityFilterTextBox
            // 
            this.CityFilterTextBox.Location = new System.Drawing.Point(546, 466);
            this.CityFilterTextBox.Name = "CityFilterTextBox";
            this.CityFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityFilterTextBox.TabIndex = 35;
            this.CityFilterTextBox.TextChanged += new System.EventHandler(this.DateFilterTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Country";
            // 
            // CountryFilterTextBox
            // 
            this.CountryFilterTextBox.Location = new System.Drawing.Point(440, 467);
            this.CountryFilterTextBox.Name = "CountryFilterTextBox";
            this.CountryFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountryFilterTextBox.TabIndex = 37;
            this.CountryFilterTextBox.TextChanged += new System.EventHandler(this.DateFilterTextBox_TextChanged);
            // 
            // ClearFilterButton
            // 
            this.ClearFilterButton.Location = new System.Drawing.Point(652, 464);
            this.ClearFilterButton.Name = "ClearFilterButton";
            this.ClearFilterButton.Size = new System.Drawing.Size(136, 23);
            this.ClearFilterButton.TabIndex = 39;
            this.ClearFilterButton.Text = "Clear Filter Text Boxes";
            this.ClearFilterButton.UseVisualStyleBackColor = true;
            this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
            // 
            // FirstNameFilterTextBox
            // 
            this.FirstNameFilterTextBox.Location = new System.Drawing.Point(122, 467);
            this.FirstNameFilterTextBox.Name = "FirstNameFilterTextBox";
            this.FirstNameFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameFilterTextBox.TabIndex = 31;
            this.FirstNameFilterTextBox.TextChanged += new System.EventHandler(this.DateFilterTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "First Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.ClearFilterButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CountryFilterTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CityFilterTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MiddleNameFilterTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FirstNameFilterTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LastNameFilterTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateFilterTextBox);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddDataToDbButton);
            this.Controls.Add(this.LoadDbButton);
            this.Controls.Add(this.LoadCsvFileButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.dataGridViewPeople);
            this.Controls.Add(this.PrintToExcelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintToExcelButton;
        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button LoadCsvFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button LoadDbButton;
        private System.Windows.Forms.Button AddDataToDbButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DateFilterTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastNameFilterTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MiddleNameFilterTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CityFilterTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CountryFilterTextBox;
        private System.Windows.Forms.Button ClearFilterButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox FirstNameFilterTextBox;
        private System.Windows.Forms.Label label9;
    }
}

