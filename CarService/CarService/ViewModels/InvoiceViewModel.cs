using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.ViewModels
{
    public class InvoiceViewModel
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public int WorkOrderID { get; set; }
        public int TotalPrice { get; set; }
        public System.DateTime DateTime { get; set; }
    }
}