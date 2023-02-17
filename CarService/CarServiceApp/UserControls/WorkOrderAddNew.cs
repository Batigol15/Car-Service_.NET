using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService.ViewModels;
using Newtonsoft.Json;
using System.Net;

namespace CarServiceApp.UserControls
{
    public partial class WorkOrderAddNew : UserControl
    {
        private string urlClassWorkOrderInsert = "WorkOrder/Insert";
        private string urlClassWorkOrderDetailedInsert = "WorkOrderDetailed/Insert";
        public WorkOrderAddNew()
        {
            InitializeComponent();
            GetAllWorkOrders();
           
        }
        private void CreateWorkOrder() //Triba odabire iz dropdowna selektirat da ne bi doslo do pucanja
        {
            WorkOrderViewModel newWorkOrder = new WorkOrderViewModel()
            {
                CompanyID = int.Parse("2002"), //HARDCODE rjesit sa Login-om!!!
                EmployeeID = int.Parse(inputEmployeeID.Text.Trim()),
                VehicleID = int.Parse(inputVehicleID.Text.Trim()),
                VehicleKm = int.Parse(inputVehicleKm.Text.Trim()),
            };

            var data = JsonConvert.SerializeObject(newWorkOrder);
            Util.POST(urlClassWorkOrderInsert, data);
        }

        private void AddWorkOrderService()
        {
            WorkOrderDetailedModel newWorkOrder = new WorkOrderDetailedModel()
            {
                WorkOrderID = int.Parse(inputWorkOrderID.Text.Trim()),
                ServiceID = int.Parse(inputServiceID.Text.Trim()),
                ServiceQuantity = int.Parse(inputQuantity.Text.Trim()),
            };

            var data = JsonConvert.SerializeObject(newWorkOrder);
            Util.POST(urlClassWorkOrderDetailedInsert, data);
        }

        public void GetAllWorkOrders()
        {

            try
            {
                WebClient client = new WebClient();
                string json = client.DownloadString("http://localhost:55555/api/WorkOrder");
                List<WorkOrderViewModel> customers = JsonConvert.DeserializeObject<List<WorkOrderViewModel>>(json);
                dataGridViewWorkOrder.DataSource = customers;

            }
            catch (WebException)
            {
                throw;
            }
        }

        public void GetWorkOrderDetailed()
        {
            string id_check = inputWorkOrderID.Text.Trim();

           

            if (id_check == "" || id_check == null)
            {
                MessageBox.Show("Please populate Work Order ID field correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                int id = int.Parse(inputWorkOrderID.Text.Trim());

                try
                {
                    WebClient client = new WebClient();
                    string json = client.DownloadString("http://localhost:55555/api/WorkOrderDetailed/GetByWorkOrderID?id=" + id);
                    List<WorkOrderDetailedModel> customers = JsonConvert.DeserializeObject<List<WorkOrderDetailedModel>>(json);
                    dataGridViewWorkOrderDetailed.DataSource = customers;

                }
                catch (WebException)
                {
                    MessageBox.Show("Work Order ID or Work Order Details does not exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //throw;
                }

            }

            
        }

        private void buttonCreateWorkOrder_Click(object sender, EventArgs e)
        {

            try
            {
                if (inputEmployeeID.Text == "" || inputVehicleID.Text == "" || inputVehicleKm.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                    CreateWorkOrder(); 
                    MessageBox.Show("Work Order added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllWorkOrders();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {

            try
            {
                if (inputWorkOrderID.Text == "" || inputServiceID.Text == "" || inputQuantity.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                    AddWorkOrderService();
                    MessageBox.Show("Work Order Service added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetWorkOrderDetailed();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please, populate correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void buttonRefreshWorkOrder_Click(object sender, EventArgs e)
        {
            GetAllWorkOrders();
        }

        private void buttonRefreshWorkOrderDetailed_Click(object sender, EventArgs e)
        {
            GetWorkOrderDetailed();
        }
    }
}
