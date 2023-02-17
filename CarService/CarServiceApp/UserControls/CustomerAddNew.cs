using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService.ViewModels;
using Newtonsoft.Json;
using System.Net;

namespace CarServiceApp.UserControls
{
    public partial class CustomerAddNew : UserControl
    {
        private string urlClassCustomerInsert = "Customer/Insert";
        private string urlClassVehicleInsert = "Vehicle/Insert";

        public CustomerAddNew()
        {
            InitializeComponent();
            GetAllCustomers();
        }

        private void buttonSaveAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputCustomerName.Text == "" || inputCustomerSurname.Text == "" || inputCustomerAddress.Text == "" || inputCustomerCity.Text == "" || inputCustomerContact.Text == "" || inputCustomerOIB.Text == "" || inputCustomerEmail.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SaveAddCustomer();
                    MessageBox.Show("Customer added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAddCustomer();
                    GetAllCustomers();
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
        private void buttonSaveAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputCustomerID.Text == "" || inputVehiclePlate.Text == "" || inputVehicleMake.Text == "" || inputVehicleModel.Text == "" || inputVehicleColour.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                    SaveAddVehicle();
                    MessageBox.Show("Vehicle added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAddVehicle();
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
            catch (WebException e)
            {
                throw;
            }


        }
        private void SaveAddCustomer()
        {
            CustomerViewModel newCustomer = new CustomerViewModel()
            {
                CompanyID = int.Parse("2002"), //HARDCODE rjesit sa Login-om!!!
                Name = inputCustomerName.Text.Trim(),
                Surname = inputCustomerSurname.Text.Trim(),
                Address = inputCustomerAddress.Text.Trim(),
                City = inputCustomerCity.Text.Trim(),
                OIB = long.Parse(inputCustomerOIB.Text.ToString()),
                Contact = inputCustomerContact.Text.Trim(),
                Email = inputCustomerEmail.Text.Trim()
            };

            var data = JsonConvert.SerializeObject(newCustomer);
            Util.POST(urlClassCustomerInsert, data);
        }
        private void ClearAddCustomer()
        {
            inputCustomerName.Text = "";
            inputCustomerSurname.Text = "";
            inputCustomerAddress.Text = "";
            inputCustomerCity.Text = "";
            inputCustomerOIB.Text = "";
            inputCustomerContact.Text = "";
            inputCustomerEmail.Text = "";
        }

        private void SaveAddVehicle()
        {
            VehicleViewModel newVehicle = new VehicleViewModel()
            {
                CustomerID = int.Parse(inputCustomerID.Text.Trim()),
                CompanyID = int.Parse("2002"), //HARDCODE rjesit sa Login-om!!!
                Plate = inputVehiclePlate.Text.Trim(),
                Make = inputVehicleMake.Text.Trim(),
                Model = inputVehicleModel.Text.Trim(),
                Colour = inputVehicleColour.Text.Trim()

            };

            var data = JsonConvert.SerializeObject(newVehicle);
            Util.POST(urlClassVehicleInsert, data);
        }

        private void ClearAddVehicle()
        {
            inputVehiclePlate.Text = "";
            inputVehicleMake.Text = "";
            inputVehicleModel.Text = "";
            inputVehicleColour.Text = "";
            inputCustomerID.Text = "";
        }

        private void resetAddCustomer(object sender, EventArgs e)
        {
            ClearAddCustomer();
        }

        private void resetAddVehicle(object sender, EventArgs e)
        {
            ClearAddVehicle();
        }

       
    }
}
