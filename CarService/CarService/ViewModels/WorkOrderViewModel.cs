using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.ViewModels
{
    public class WorkOrderViewModel
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public int EmployeeID { get; set; }
        public int VehicleID { get; set; }
        public int VehicleKm { get; set; }
        public System.DateTime DateTime { get; set; }
        public int IsActive { get; set; }
    }
}