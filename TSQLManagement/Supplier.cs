
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace TSQLManagement
{

using System;
    using System.Collections.Generic;
    
public partial class Supplier
{

    public Supplier()
    {

        this.Products = new HashSet<Product>();

    }


    public int supplierid { get; set; }

    public string companyname { get; set; }

    public string contactname { get; set; }

    public string contacttitle { get; set; }

    public string address { get; set; }

    public string city { get; set; }

    public string region { get; set; }

    public string postalcode { get; set; }

    public string country { get; set; }

    public string phone { get; set; }

    public string fax { get; set; }



    public virtual ICollection<Product> Products { get; set; }

}

}
