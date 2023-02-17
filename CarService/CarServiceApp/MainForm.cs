using CarService.ViewModels;
using CarServiceApp.UserControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class CarServiceForm : Form
    {
        NavigationControl navigationControl;

        public CarServiceForm()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {new CustomerAddNew(), new CustomerSearchAndEdit(), new VehicleSearchAndEdit(), new EmployeeAddNew(), new EmployeeSearchAndEdit(), new ServiceAddNew(), new ServiceSearchAndEdit(), new WorkOrderAddNew(), new InvoiceAddNew()};

            navigationControl = new NavigationControl(userControls, panelMain);
            navigationControl.Display(0);
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void buttonSearchEditCustomer_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void buttonSearchEditVehicle_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }

        private void buttonAddNewEmployee_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
        }

        private void buttonSearchEditEmployee_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
        }

        private void buttonCreateNewService_Click(object sender, EventArgs e)
        {
            navigationControl.Display(5);
        }

        private void buttonSearchEditService_Click(object sender, EventArgs e)
        {
            navigationControl.Display(6);
        }

        private void CarServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            navigationControl.Display(7);
        }

        private void buttonCreateNewInvoice_Click(object sender, EventArgs e)
        {
            navigationControl.Display(8);
        }
    }
}

    
            
            
        
    
    
    

    

