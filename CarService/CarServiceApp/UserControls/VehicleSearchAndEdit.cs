using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService.ViewModels;
using Newtonsoft.Json;
using System.Net;
namespace CarServiceApp.UserControls
{
    public partial class VehicleSearchAndEdit : UserControl
    {
        private string urlClassVehicleUpdate = "Vehicle/Update";
        public VehicleSearchAndEdit()
        {
            InitializeComponent();
            GetAllVehicles();
        }
        public void GetAllVehicles()
        {
            try
            {
                WebClient client = new WebClient();
                string json = client.DownloadString("http://localhost:55555/api/Vehicle");
                List<VehicleViewModel> vehicles = JsonConvert.DeserializeObject<List<VehicleViewModel>>(json);
                dataGridViewVehicle.DataSource = vehicles;

            }
            catch (WebException)
            {
                throw;
            }
        }

        private void UpdateVehicle()
        {
            if (!inputVehicleIsActive.Checked)
            {
                inputVehicleIsActive.Text = "0";
            }

            if (inputVehicleIsActive.Checked)
            {
                inputVehicleIsActive.Text = "1";
            }

            VehicleViewModel vehicleUpdate = new VehicleViewModel()
            {
                ID = int.Parse(inputVehicleID.Text.Trim()),
                CustomerID = int.Parse(inputCustomerID.Text.Trim()),
                CompanyID = int.Parse(inputCompanyID.Text.Trim()),
                Plate = inputVehiclePlate.Text.Trim(),
                Make = inputVehicleMake.Text.Trim(),
                Model = inputVehicleModel.Text.Trim(),
                Colour = inputVehicleColour.Text.Trim(),
                IsActive = int.Parse(inputVehicleIsActive.Text.Trim())
            };

            var data = JsonConvert.SerializeObject(vehicleUpdate);
            Util.PUT(urlClassVehicleUpdate, data);

        }

        private void ClearUpdateVehicle()
        {
            inputVehicleID.Text = "";
            inputVehiclePlate.Text = "";
            inputVehicleMake.Text = "";
            inputVehicleModel.Text = "";
            inputVehicleColour.Text = "";
            inputVehicleIsActive.Checked = false;
            inputVehicleIsActive.Text = "";

            inputCustomerID.Text = "";
            inputCustomerName.Text = "";
            inputCustomerSurname.Text = "";
            inputCustomerSince.Text = "";
        }

        private void dataGridViewVehicle_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            inputVehicleID.Text = Convert.ToString(dataGridViewVehicle[0, row].Value);
            inputCustomerID.Text = Convert.ToString(dataGridViewVehicle[1, row].Value);
            inputCompanyID.Text = Convert.ToString(dataGridViewVehicle[2, row].Value);
            inputVehiclePlate.Text =  Convert.ToString(dataGridViewVehicle[3, row].Value);
            inputVehicleMake.Text = Convert.ToString(dataGridViewVehicle[4, row].Value);
            inputVehicleModel.Text = Convert.ToString(dataGridViewVehicle[5, row].Value);
            inputVehicleColour.Text = Convert.ToString(dataGridViewVehicle[6, row].Value);

            if (Convert.ToString(dataGridViewVehicle[7, row].Value) == "1")
            {
                inputVehicleIsActive.Checked = true;
            }
            if (Convert.ToString(dataGridViewVehicle[7, row].Value) == "0")
            {
                inputVehicleIsActive.Checked = false;
            }

            WebClient client = new WebClient();
            int customerID = int.Parse(inputCustomerID.Text.Trim()); ;

            string json = client.DownloadString("http://localhost:55555/api/Customer/GetByID?id=" + customerID);

            var customers = JsonConvert.DeserializeObject<List<CustomerViewModel>>(json);
            var customer = customers.Find(x => x.ID == customerID);

            inputCustomerName.Text = Convert.ToString(customer.Name);
            inputCustomerSurname.Text = Convert.ToString(customer.Surname);
            inputCustomerSince.Text = Convert.ToString(customer.Since);
            inputCompanyID.Text = Convert.ToString(customer.CompanyID);
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
                string json_try = client.DownloadString("http://localhost:55555/api/Vehicle/GetByID?id=" + id);
            }

            catch (WebException)
            {
                MessageBox.Show("Vehicle not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string json = client.DownloadString("http://localhost:55555/api/Vehicle/GetByID?id=" + id);

            var vehicles = JsonConvert.DeserializeObject<List<VehicleViewModel>>(json);
            var vehicle = vehicles.Find(x => x.ID == int.Parse(id));

            inputVehicleID.Text = Convert.ToString(vehicle.ID);
            inputCustomerID.Text = Convert.ToString(vehicle.CustomerID);
            inputVehiclePlate.Text = Convert.ToString(vehicle.Plate);
            inputVehicleMake.Text = Convert.ToString(vehicle.Make);
            inputVehicleModel.Text = Convert.ToString(vehicle.Model);
            inputVehicleColour.Text = Convert.ToString(vehicle.Colour);


            if (Convert.ToString(vehicle.IsActive) == "1")
            {
                inputVehicleIsActive.Checked = true;
            }
            if (Convert.ToString(vehicle.IsActive) == "0")
            {
                inputVehicleIsActive.Checked = false;
            }


            int customerID = int.Parse(inputCustomerID.Text.Trim()); ;

            string json2 = client.DownloadString("http://localhost:55555/api/Customer/GetByID?id=" + customerID);

            var customers = JsonConvert.DeserializeObject<List<CustomerViewModel>>(json2);
            var customer = customers.Find(x => x.ID == customerID);

            inputCustomerName.Text = Convert.ToString(customer.Name);
            inputCustomerSurname.Text = Convert.ToString(customer.Surname);
            inputCustomerSince.Text = Convert.ToString(customer.Since);
            inputCompanyID.Text = Convert.ToString(customer.CompanyID);

        }

        private void buttonUpdateVehicle_Click(object sender, EventArgs e)
        {

            try
            {
                if (inputVehiclePlate.Text == "" || inputVehicleMake.Text == "" || inputVehicleModel.Text == "" || inputVehicleColour.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    UpdateVehicle();
                    MessageBox.Show("Vehicle updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllVehicles();
                    ClearUpdateVehicle();
                }
            }
            
        
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetAllVehicles();
        }
    }
}
