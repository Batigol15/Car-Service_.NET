using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService.ViewModels;
using Newtonsoft.Json;
using System.Net;
namespace CarServiceApp.UserControls
{
    public partial class ServiceSearchAndEdit : UserControl
    {

        private string urlClassServiceUpdate = "Service/Update";
        public ServiceSearchAndEdit()
        {
            InitializeComponent();
            GetAllServices();
        }

        private void buttonUpdateService_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputServiceName.Text == "" || inputServicePrice.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    UpdateService();
                    MessageBox.Show("Service updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearUpdateService();
                    GetAllServices();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GetAllServices()
        {
            try
            {
                WebClient client = new WebClient();
                string json = client.DownloadString("http://localhost:55555/api/Service");
                List<ServiceViewModel> services = JsonConvert.DeserializeObject<List<ServiceViewModel>>(json);
                dataGridViewService.DataSource = services;
            }
            catch (WebException)
            {
                throw;
            }
        }

        public void UpdateService()
        {
            ServiceViewModel serviceUpdate = new ServiceViewModel()
            {
                ID = int.Parse(inputServiceID.Text.Trim()),
                CompanyID = int.Parse(inputCompanyID.Text.Trim()),
                Name = inputServiceName.Text.Trim(),
                Price = int.Parse(inputServicePrice.Text.Trim()),
            };

            var data = JsonConvert.SerializeObject(serviceUpdate);
            Util.PUT(urlClassServiceUpdate, data);
        }

        public void ClearUpdateService()
        {
            inputServiceID.Text = "";
            inputServiceName.Text = "";
            inputServicePrice.Text = "";
            inputCompanyID.Text = "";
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
                string json_try = client.DownloadString("http://localhost:55555/api/Service/GetByID?id=" + id);
            }

            catch (WebException)
            {
                MessageBox.Show("Service not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string json = client.DownloadString("http://localhost:55555/api/Service/GetByID?id=" + id);

            var services = JsonConvert.DeserializeObject<List<ServiceViewModel>>(json);
            var service = services.Find(x => x.ID == int.Parse(id));

            inputServiceID.Text = Convert.ToString(service.ID);
            inputServiceName.Text = Convert.ToString(service.Name);
            inputServicePrice.Text = Convert.ToString(service.Price);
            inputCompanyID.Text = Convert.ToString(service.CompanyID);
        }

        private void dataGridViewService_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            inputServiceID.Text = Convert.ToString(dataGridViewService[0, row].Value);
            inputCompanyID.Text = Convert.ToString(dataGridViewService[1, row].Value);
            inputServiceName.Text = Convert.ToString(dataGridViewService[2, row].Value);
            inputServicePrice.Text = Convert.ToString(dataGridViewService[3, row].Value);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetAllServices();
        }

    }
}
