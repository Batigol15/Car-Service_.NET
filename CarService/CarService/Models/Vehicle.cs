//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        public Vehicle()
        {
            this.WorkOrders = new HashSet<WorkOrder>();
        }
    
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int CompanyID { get; set; }
        public string Plate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int IsActive { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
