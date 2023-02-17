using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.ViewModels
{
    public class ServiceViewModel
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int IsActive { get; set; }
    }
}