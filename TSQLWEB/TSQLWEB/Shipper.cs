//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSQLWEB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shipper
    {
        public Shipper()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int shipperid { get; set; }
        public string companyname { get; set; }
        public string phone { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}