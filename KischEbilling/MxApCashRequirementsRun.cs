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
    
    public partial class MxApCashRequirementsRun
    {
        public System.Guid MxApCashRequirementsRunID { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyType { get; set; }
        public string CurrencyDate { get; set; }
        public string ReqVendors { get; set; }
        public Nullable<System.DateTime> CurrencyAsOfDate { get; set; }
        public Nullable<byte> IsNoCurrencyConversion { get; set; }
        public Nullable<byte> IsUseReportingCurrencies { get; set; }
        public string PayeePred { get; set; }
    }
}