//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinancesPersonnelles
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int Type { get; set; }
        public System.DateTime DateTime { get; set; }
        public Nullable<double> Balance { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
    
        public virtual AccountType AccountType { get; set; }
    }
}
