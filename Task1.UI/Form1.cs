using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Task1.BusinessLogic.Dtos;
using Task1.BusinessLogic.ExtractorsControl;

namespace Task1.UI
{
    public partial class Form1 : Form
    {
        Encoding utf8 = Encoding.UTF8;
        Encoding utf16 = Encoding.Unicode;

        List<PersonDto> peopleFromMemory = new List<PersonDto>();
        List<PersonDto> filtredData = new List<PersonDto>();

        string path = String.Empty;

        bool hasDbBeenLoaded = false;
        bool hasFileBeenLoaded = false;
        bool isNewFile = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCsvFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                try
                {
                    var people = Controller.GetPeopleFromCsvFile(path);
                    peopleFromMemory = people.ToList();
                    filtredData = peopleFromMemory;
                    dataGridViewPeople.DataSource = peopleFromMemory;
                    hasDbBeenLoaded = false;
                    isNewFile = false;
                    hasFileBeenLoaded = true;
                    AddDataToDbButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    isNewFile = true;
                    AddDataToDbButton.Enabled = false;
                    dataGridViewPeople.DataSource = null;
                    filtredData.Clear();
                    peopleFromMemory.Clear();
                    ErrorLabel.Text = $"Error! {ex.Message}";
                }
            }
        }

        private void LoadDbButton_Click(object sender, EventArgs e)
        {
            peopleFromMemory.Clear();
            peopleFromMemory = Controller.GetPeopleFromDatabase().ToList();
            filtredData = peopleFromMemory;
            dataGridViewPeople.DataSource = peopleFromMemory;

            ClearButton_Click(null, null);
            DateFilterTextBox_TextChanged(null, null);
            hasFileBeenLoaded = false;
            isNewFile = false;
            hasDbBeenLoaded = true;
            AddDataToDbButton.Enabled = false;
        }

        private void AddDataToDbButton_Click(object sender, EventArgs e)
        {
            foreach (var p in filtredData)
            {
                Controller.AddPersonToDatabase(p);
            }
            LoadDbButton_Click(null, null);
            AddDataToDbButton.Enabled = false;
        }

        private void dataGridViewPeople_SelectionChanged(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewPeople.CurrentRow.Index;
            if (rowIndex >= 0 && filtredData.Count > 0 && rowIndex < filtredData.Count)
            {
                var person = filtredData[rowIndex];
                textBoxData.Text = $"{person.Date.ToShortDateString()}";
                textBoxLastName.Text = person.LastName;
                textBoxFirstName.Text = person.FirstName;
                textBoxMiddleName.Text = person.MiddleName;
                textBoxCity.Text = person.City;
                textBoxCountry.Text = person.Country;
            }
            if(rowIndex >= 0 && dataGridViewPeople.SelectedCells.Count > 0)
            {
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
            else
            {
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dataGridViewPeople.ClearSelection();
            textBoxData.Text = String.Empty;
            textBoxLastName.Text = String.Empty;
            textBoxFirstName.Text = String.Empty;
            textBoxMiddleName.Text = String.Empty;
            textBoxCity.Text = String.Empty;
            textBoxCountry.Text = String.Empty;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(hasDbBeenLoaded)
                {
                    var person = new PersonDto();
                    FillPersonFromForms(person);
                    Controller.AddPersonToDatabase(person);
                    LoadDbButton_Click(null, null);
                }
                else if(isNewFile || hasFileBeenLoaded)
                {
                    var person = new PersonDto();
                    FillPersonFromForms(person);
                    peopleFromMemory.Add(person);
                    AddDataToDbButton.Enabled = true;
                    dataGridViewPeople.DataSource = null;
                    dataGridViewPeople.DataSource = peopleFromMemory;
                    DateFilterTextBox_TextChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = $"Error! {ex.Message}.";
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rowIndex = dataGridViewPeople.CurrentRow.Index;
                if (hasDbBeenLoaded)
                {
                    int id = (int)dataGridViewPeople[0, rowIndex].Value;
                    var UpdatedPerson = new PersonDto();
                    FillPersonFromForms(UpdatedPerson);
                    Controller.UpdatePersonFromDatabase(id, UpdatedPerson);                    
                    LoadDbButton_Click(null, null);
                }
                else if (isNewFile || hasFileBeenLoaded)
                {
                    var selectedPerson = peopleFromMemory[rowIndex];
                    FillPersonFromForms(selectedPerson);
                    dataGridViewPeople.DataSource = null;
                    dataGridViewPeople.DataSource = peopleFromMemory;
                }
            }
            catch(Exception ex)
            {
                ErrorLabel.Text = $"Error! {ex.Message}";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewPeople.CurrentRow.Index;
            if (hasDbBeenLoaded)
            {
                int id = (int)dataGridViewPeople[0, rowIndex].Value;
                Controller.DeletePersonFromDatabase(id);
                LoadDbButton_Click(null, null);
            }
            if(isNewFile || hasFileBeenLoaded)
            {
                peopleFromMemory.Remove(peopleFromMemory[rowIndex]);
                dataGridViewPeople.DataSource = null;
                dataGridViewPeople.DataSource = peopleFromMemory;
            }
            DateFilterTextBox_TextChanged(null, null);
        }

        private void FillPersonFromForms(PersonDto newPersonObj)
        {
            if (!DateTime.TryParse(textBoxData.Text, out DateTime date))
            {
                throw new Exception("Date entered incorrectly.");
            }
            newPersonObj.Date = date;
            newPersonObj.LastName = textBoxLastName.Text;
            newPersonObj.FirstName = textBoxFirstName.Text;
            newPersonObj.MiddleName = textBoxMiddleName.Text;
            newPersonObj.City = textBoxCity.Text;
            newPersonObj.Country = textBoxCountry.Text;
        }

        private void DateFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filtredData = Controller.ToFilterPeople(peopleFromMemory, DateFilterTextBox.Text, LastNameFilterTextBox.Text,
                              FirstNameFilterTextBox.Text, MiddleNameFilterTextBox.Text, 
                              CityFilterTextBox.Text, CountryFilterTextBox.Text).ToList();
                dataGridViewPeople.DataSource = null;
                dataGridViewPeople.DataSource = filtredData;
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = $"Error! {ex.Message}";
            }
        }

        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            DateFilterTextBox.Text = String.Empty;
            LastNameFilterTextBox.Text = String.Empty;
            FirstNameFilterTextBox.Text = String.Empty;
            MiddleNameFilterTextBox.Text = String.Empty;
            CityFilterTextBox.Text = String.Empty;
            CountryFilterTextBox.Text = String.Empty;

            filtredData = peopleFromMemory;

            if (!hasDbBeenLoaded)
            {
                dataGridViewPeople.DataSource = peopleFromMemory;
            }
        }

        private void PrintToExcelButton_Click(object sender, EventArgs e)
        {
            var sfd = saveFileDialog;
            sfd.FileName = "People";
            sfd.Filter = "Xlsx files (*.xlsx)|*.xlsx";
            sfd.RestoreDirectory = true;
            sfd.ShowDialog();

            var path = $@"{sfd.FileName}";
            try
            {
                //Controller.PrintPeopleToExcel(path, peopleFromMemory);
                Controller.PrintPeopleToExcel(path, filtredData);
            }
            catch(Exception ex)
            {
                ErrorLabel.Text = $"Error! {ex.Message}";
            }
        }

        private void dataGridViewPeople_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ErrorLabel.Text = String.Empty;
            if (dataGridViewPeople.Rows.Count > 0)
            {
                PrintToExcelButton.Enabled = true;
            }
        }

        private void dataGridViewPeople_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ErrorLabel.Text = String.Empty;
            if (dataGridViewPeople.Rows.Count <= 0)
            {
                PrintToExcelButton.Enabled = false;
            }
        }
    }
}