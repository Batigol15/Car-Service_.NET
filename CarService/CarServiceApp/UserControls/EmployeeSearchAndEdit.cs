using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService.ViewModels;
using Newtonsoft.Json;
using System.Net;


namespace CarServiceApp.UserControls
{
    public partial class EmployeeSearchAndEdit : UserControl
    {
        private string urlClassEmployeeUpdate = "Employee/Update";
        public EmployeeSearchAndEdit()
        {
            InitializeComponent();
            GetAllEmployees();
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputEmployeeName.Text == "" || inputEmployeeSurname.Text == "" || inputEmployeePassword.Text == "" || inputEmployeeContact.Text == "" || inputEmployeeOIB.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    UpdateEmployee();
                    MessageBox.Show("Employee updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllEmployees();
                    ClearUpdateEmployee();
                }
            }
            catch (Exception)
            {
                throw;
            }

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

        private void UpdateEmployee()
        {
            if (!inputEmployeeIsActive.Checked)
            {
                inputEmployeeIsActive.Text = "0";
            }

            if (inputEmployeeIsActive.Checked)
            {
                inputEmployeeIsActive.Text = "1";
            }

            EmployeeViewModel employeeUpdate = new EmployeeViewModel()
            {
                ID = int.Parse(inputEmployeeID.Text.Trim()),
                CompanyID = int.Parse("1"),
                Name = inputEmployeeName.Text.Trim(),
                Surname = inputEmployeeSurname.Text.Trim(),
                Password = inputEmployeePassword.Text.Trim(),
                OIB = long.Parse(inputEmployeeOIB.Text.Trim()),
                Contact = inputEmployeeContact.Text.Trim(),
                IsActive = int.Parse(inputEmployeeIsActive.Text.Trim())
            };

            var data = JsonConvert.SerializeObject(employeeUpdate);
            Util.PUT(urlClassEmployeeUpdate, data);
        }

        private void ClearUpdateEmployee()
        {
            inputEmployeeID.Text = "";
            inputEmployeeName.Text = "";
            inputEmployeeSurname.Text = "";
            inputEmployeePassword.Text = "";
            inputEmployeeOIB.Text = "";
            inputEmployeeContact.Text = "";
            inputEmployeeIsActive.Text = "";
            inputEmployeeIsActive.Checked = false;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string id = inputSearch.Text.Trim();

            if (id == null || id == "")
            {
                MessageBox.Show("Search must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            WebClient client = new WebClient();

            try
            {
                string json_try = client.DownloadString("http://localhost:55555/api/Employee/GetByID?id=" + id);
            }

            catch (WebException)
            {
                MessageBox.Show("Customer not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string json = client.DownloadString("http://localhost:55555/api/Employee/GetByID?id=" + id);

            var employees = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(json);
            var employee = employees.Find(x => x.ID == int.Parse(id));

            inputEmployeeID.Text = Convert.ToString(employee.ID);
            inputEmployeeName.Text = Convert.ToString(employee.Name);
            inputEmployeeSurname.Text = Convert.ToString(employee.Surname);
            inputEmployeePassword.Text = Convert.ToString(employee.Password);
            inputEmployeeOIB.Text = Convert.ToString(employee.OIB);
            inputEmployeeContact.Text = Convert.ToString(employee.Contact);
            inputEmployeeSince.Text = Convert.ToString(employee.Since);

            if (Convert.ToString(employee.IsActive) == "1")
            {
                inputEmployeeIsActive.Checked = true;
            }
            if (Convert.ToString(employee.IsActive) == "0")
            {
                inputEmployeeIsActive.Checked = false;
            }
        }

        private void dataGridViewEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            inputEmployeeID.Text = Convert.ToString(dataGridViewEmployee[0, row].Value);
            inputEmployeeName.Text = Convert.ToString(dataGridViewEmployee[2, row].Value);
            inputEmployeeSurname.Text = Convert.ToString(dataGridViewEmployee[3, row].Value);
            inputEmployeePassword.Text = Convert.ToString(dataGridViewEmployee[4, row].Value);
            inputEmployeeOIB.Text = Convert.ToString(dataGridViewEmployee[5, row].Value);
            inputEmployeeContact.Text = Convert.ToString(dataGridViewEmployee[6, row].Value);
            inputEmployeeSince.Text = Convert.ToString(dataGridViewEmployee[7, row].Value);

            if (Convert.ToString(dataGridViewEmployee[8, row].Value) == "1")
            {
                inputEmployeeIsActive.Checked = true;
            }
            if (Convert.ToString(dataGridViewEmployee[8, row].Value) == "0")
            {
                inputEmployeeIsActive.Checked = false;
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetAllEmployees();
        }
    }
}
