//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KischEbilling
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaxCode
    {
        public System.Guid TaxCodeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte IsAP { get; set; }
        public string TaxRndBasisList { get; set; }
        public Nullable<System.Guid> GLNatural1 { get; set; }
        public Nullable<System.Guid> GLNatural2 { get; set; }
        public Nullable<System.Guid> GLNatural3 { get; set; }
        public byte IsOverrideDefault { get; set; }
        public byte IsNoTax { get; set; }
        public Nullable<decimal> BillDisplayTaxRate { get; set; }
        public byte IsRateBillDate { get; set; }
        public string TaxTypeList { get; set; }
    
        public virtual GLNatural GLNatural { get; set; }
        public virtual GLNatural GLNatural4 { get; set; }
        public virtual GLNatural GLNatural5 { get; set; }
    }
}