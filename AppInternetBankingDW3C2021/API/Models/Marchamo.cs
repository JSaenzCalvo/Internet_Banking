//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Marchamo
    {
        public int Codigo { get; set; }
        public Nullable<int> Cuenta { get; set; }
        public Nullable<int> Monto { get; set; }
        public Nullable<System.DateTime> FechaExp { get; set; }
        public string Estado { get; set; }
    
        public virtual Cuenta Cuenta1 { get; set; }
    }
}
