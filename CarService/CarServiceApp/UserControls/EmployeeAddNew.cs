using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService.ViewModels;
using Newtonsoft.Json;
using System.Net;

namespace CarServiceApp.UserControls
{
    public partial class EmployeeAddNew : UserControl
    {

        private string urlClassEmployeeInsert = "Employee/Insert";


        public EmployeeAddNew()
        {
            InitializeComponent();
            GetAllEmployees();
        }


        public void GetAllEmployees()
        {

            try
            {
                WebClient client = new WebClient();
                string json = client.DownloadString("http://localhost:55555/api/Employee");
                List<EmployeeViewModel> employees = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(json);
                dataGridViewEmployee.DataSource = employees;

            }
            catch (WebException)
            {
                throw;
            }


        }
        private void SaveAddEmployee()
        {
            EmployeeViewModel newEmployee = new EmployeeViewModel()
            {
                CompanyID = int.Parse("2002"),
                Name = inputEmployeeName.Text.Trim(),
                Surname = inputEmployeeSurname.Text.Trim(),
                Password = inputEmployeePassword.Text.Trim(),
                OIB = long.Parse(inputEmployeeOIB.Text.ToString()),
                Contact = inputEmployeeContact.Text.Trim(),



            };

            var data = JsonConvert.SerializeObject(newEmployee);
            Util.POST(urlClassEmployeeInsert, data);
        }
        private void ClearAddEmployee()
        {
            inputEmployeeName.Text = "";
            inputEmployeeSurname.Text = "";
            inputEmployeePassword.Text = "";
            inputEmployeeOIB.Text = "";
            inputEmployeeContact.Text = "";
        }

        private void resetAddEmployee(object sender, EventArgs e)
        {
            ClearAddEmployee();
        }

      
        private void buttonSaveAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputEmployeeName.Text == "" || inputEmployeeSurname.Text == "" || inputEmployeePassword.Text == "" || inputEmployeeContact.Text == "" || inputEmployeeOIB.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SaveAddEmployee();
                    MessageBox.Show("Employee added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAddEmployee();
                    GetAllEmployees();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
