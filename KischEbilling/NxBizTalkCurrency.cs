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
    
    public partial class NxBizTalkCurrency
    {
        public System.Guid NxBizTalkCurrencyID { get; set; }
        public string BaseCurrency { get; set; }
        public Nullable<System.Guid> FileformatRelation { get; set; }
        public string CurrencyTypeSection { get; set; }
        public string CurrencyForSelectedRateSection { get; set; }
        public Nullable<byte> IsNewCurrencyFormat { get; set; }
    
        public virtual NxIntegrationImport NxIntegrationImport { get; set; }
    }
}