using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.ViewModels
{
    public class VehicleViewModel
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int CompanyID { get; set; }
        public string Plate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int IsActive { get; set; }
    }
}