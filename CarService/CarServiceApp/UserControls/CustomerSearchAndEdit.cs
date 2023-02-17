using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService.ViewModels;
using Newtonsoft.Json;
using System.Net;

namespace CarServiceApp.UserControls
{
    public partial class CustomerSearchAndEdit : UserControl
    {
        private string urlClassCustomerUpdate = "Customer/Update";
        private string urlClassCustomerDelete= "Customer/DeleteByID?id=";
        public CustomerSearchAndEdit()
        {
            InitializeComponent();
            GetAllCustomers();
        }
        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(inputCustomerID.Text.Trim());
                Util.DELETE(urlClassCustomerDelete, id);

                ClearUpdateCustomer();
                GetAllCustomers();
            }

            catch (WebException)
            {
                MessageBox.Show("Customer can not be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
        }
        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputCustomerName.Text == "" || inputCustomerSurname.Text == "" || inputCustomerAddress.Text == "" || inputCustomerCity.Text == "" || inputCustomerContact.Text == "" || inputCustomerOIB.Text == "" || inputCustomerEmail.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    UpdateCustomer();
                    MessageBox.Show("Customer updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllCustomers();
                    ClearUpdateCustomer();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void GetAllCustomers()
        {
            try
            {
                WebClient client = new WebClient();
                string json = client.DownloadString("http://localhost:55555/api/Customer");
                List<CustomerViewModel> customers = JsonConvert.DeserializeObject<List<CustomerViewModel>>(json);
                dataGridViewCustomer.DataSource = customers;

            }
            catch (WebException)
            {
                throw;
            }
        }
        private void UpdateCustomer()
        {
            if (!inputCustomerIsActive.Checked)
            {
                inputCustomerIsActive.Text = "0";
            }

            if (inputCustomerIsActive.Checked)
            {
                inputCustomerIsActive.Text = "1";
            }

            CustomerViewModel customerUpdate = new CustomerViewModel()
            {
                ID = int.Parse(inputCustomerID.Text.Trim()),
                CompanyID = int.Parse(inputCompanyID.Text.Trim()),
                Name = inputCustomerName.Text.Trim(),
                Surname = inputCustomerSurname.Text.Trim(),
                Address = inputCustomerAddress.Text.Trim(),
                City = inputCustomerCity.Text.Trim(),
                OIB = long.Parse(inputCustomerOIB.Text.Trim()),
                Contact = inputCustomerContact.Text.Trim(),
                Email = inputCustomerEmail.Text.Trim(),
                IsActive = int.Parse(inputCustomerIsActive.Text.Trim())
            };

            

            var data = JsonConvert.SerializeObject(customerUpdate);
            Util.PUT(urlClassCustomerUpdate, data);
        }

        private void ClearUpdateCustomer()
        {
            inputCustomerID.Text = "";
            inputCustomerName.Text = "";
            inputCustomerSurname.Text = "";
            inputCustomerAddress.Text = "";
            inputCustomerCity.Text = "";
            inputCustomerOIB.Text = "";
            inputCustomerContact.Text = "";
            inputCustomerEmail.Text = "";
            inputCustomerIsActive.Text = "";
            inputCustomerIsActive.Checked = false;
        }

        private void dataGridViewCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            inputCustomerID.Text = Convert.ToString(dataGridViewCustomer[0, row].Value);
            inputCompanyID.Text = Convert.ToString(dataGridViewCustomer[1, row].Value);
            inputCustomerName.Text = Convert.ToString(dataGridViewCustomer[2, row].Value);
            inputCustomerSurname.Text = Convert.ToString(dataGridViewCustomer[3, row].Value);
            inputCustomerAddress.Text = Convert.ToString(dataGridViewCustomer[4, row].Value);
            inputCustomerCity.Text = Convert.ToString(dataGridViewCustomer[5, row].Value);
            inputCustomerOIB.Text = Convert.ToString(dataGridViewCustomer[6, row].Value);
            inputCustomerContact.Text = Convert.ToString(dataGridViewCustomer[7, row].Value);
            inputCustomerEmail.Text = Convert.ToString(dataGridViewCustomer[8, row].Value);
            inputCustomerSince.Text = Convert.ToString(dataGridViewCustomer[9, row].Value);

            if (Convert.ToString(dataGridViewCustomer[10, row].Value) == "1")
            {
                inputCustomerIsActive.Checked = true;
            }
            if (Convert.ToString(dataGridViewCustomer[10, row].Value) == "0")
            {
                inputCustomerIsActive.Checked = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string id = inputSearch.Text.Trim();

            if (id == null || id =="")
            {
                MessageBox.Show("Search must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        
            
            WebClient client = new WebClient();

            try
            {
                string json_try = client.DownloadString("http://localhost:55555/api/Customer/GetByID?id=" + id);
            }

            catch(WebException)
            {
                MessageBox.Show("Customer not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string json = client.DownloadString("http://localhost:55555/api/Customer/GetByID?id=" + id);

            var customers = JsonConvert.DeserializeObject<List<CustomerViewModel>>(json);
            var customer = customers.Find(x => x.ID == int.Parse(id));

            inputCustomerID.Text = Convert.ToString(customer.ID);
            inputCompanyID.Text = Convert.ToString(customer.CompanyID);
            inputCustomerName.Text = Convert.ToString(customer.Name);
            inputCustomerSurname.Text = Convert.ToString(customer.Surname);
            inputCustomerAddress.Text = Convert.ToString(customer.Address);
            inputCustomerCity.Text = Convert.ToString(customer.City);
            inputCustomerOIB.Text = Convert.ToString(customer.OIB);
            inputCustomerContact.Text = Convert.ToString(customer.Contact);
            inputCustomerEmail.Text = Convert.ToString(customer.Email);
            inputCustomerSince.Text = Convert.ToString(customer.Since);

            if (Convert.ToString(customer.IsActive) == "1")
            {
                inputCustomerIsActive.Checked = true;
            }
            if (Convert.ToString(customer.IsActive) == "0")
            {
                inputCustomerIsActive.Checked = false;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }
    }
}
