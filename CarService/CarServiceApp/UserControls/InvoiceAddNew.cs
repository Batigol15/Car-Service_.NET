using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService.ViewModels;
using Newtonsoft.Json;
using System.Net;


namespace CarServiceApp.UserControls
{
    public partial class InvoiceAddNew : UserControl
    {

        private string urlClassServiceInsert = "Invoice/Insert";
        public InvoiceAddNew()
        {
            InitializeComponent();
        }

        private void buttonSaveAddInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputWorkOrderID.Text == "" || inputTotalPrice.Text == "")
                {
                    MessageBox.Show("Please, populate all fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SaveAddInvoice();
                    MessageBox.Show("Invoice added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAddInvoice();
                    GetAllInvoices();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void GetAllInvoices()
        {
            try
            {
                WebClient client = new WebClient();
                string json = client.DownloadString("http://localhost:55555/api/Invoice");
                List<InvoiceViewModel> invoices = JsonConvert.DeserializeObject<List<InvoiceViewModel>>(json);
                dataGridViewInvoice.DataSource = invoices;

            }
            catch (WebException)
            {
                throw;
            }
        }

        public void SaveAddInvoice()
        {
            InvoiceViewModel newInvoice = new InvoiceViewModel()
            {
                CompanyID = int.Parse("2002"),
                WorkOrderID = int.Parse(inputWorkOrderID.Text.Trim()),
                TotalPrice = int.Parse(inputTotalPrice.Text.ToString()),
            };

            var data = JsonConvert.SerializeObject(newInvoice);
            Util.POST(urlClassServiceInsert, data);
        }

        public void ClearAddInvoice()
        {
            inputWorkOrderID.Text = "";
            inputTotalPrice.Text = "";
        }

        private void resetAddInvoice(object sender, EventArgs e)
        {
            ClearAddInvoice();
        }

       
    }
}
