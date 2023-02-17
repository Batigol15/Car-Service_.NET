using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService.ViewModels;
using Newtonsoft.Json;
using System.Net;

namespace CarServiceApp.UserControls
{
    public partial class ServiceAddNew : UserControl
    {
        private string urlClassServiceInsert = "Service/Insert";
        public ServiceAddNew()
        {
            InitializeComponent();
            GetAllServices();
        }

        private void buttonSaveAddService_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputServiceName.Text == "" || inputServicePrice.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SaveAddService();
                    MessageBox.Show("Service added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAddService();
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

        public void SaveAddService()
        {
            ServiceViewModel newService = new ServiceViewModel()
            {
                CompanyID = int.Parse("2002"),
                Name = inputServiceName.Text.Trim(),
                Price = int.Parse(inputServicePrice.Text.ToString()),
            };

            var data = JsonConvert.SerializeObject(newService);
            Util.POST(urlClassServiceInsert, data);
        }

        public void ClearAddService()
        {
            inputServiceName.Text = "";
            inputServicePrice.Text = "";
        }

        private void resetAddService(object sender, EventArgs e)
        {
            ClearAddService();
        }

    }
}
