using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.ViewModels
{
    public class CustomerViewModel
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long OIB { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public System.DateTime Since { get; set; }
        public int IsActive { get; set; }
    }
}