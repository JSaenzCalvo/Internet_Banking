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
    
    public partial class Deposito_Plazo
    {
        public int Codigo { get; set; }
        public Nullable<int> Cuenta { get; set; }
        public Nullable<int> Plazo { get; set; }
        public Nullable<int> Monto_min { get; set; }
        public Nullable<int> Tasa { get; set; }
        public Nullable<int> Moneda { get; set; }
    
        public virtual Cuenta Cuenta1 { get; set; }
        public virtual Moneda Moneda1 { get; set; }
    }
}
