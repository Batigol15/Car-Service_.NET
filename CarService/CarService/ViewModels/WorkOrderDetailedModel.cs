using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.ViewModels
{
    public class WorkOrderDetailedModel
    {
        public int ID { get; set; }
        public int WorkOrderID { get; set; }
        public int ServiceID { get; set; }
        public int ServiceQuantity { get; set; }
    }
}