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
    
    public partial class MxNonBillableDetailRun
    {
        public System.Guid MxNonBillableDetailRunID { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyType { get; set; }
        public string CurrencyCalcDate { get; set; }
        public Nullable<byte> IsCurrentValues { get; set; }
        public string ReportOnDate { get; set; }
        public string ReportingPeriod { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ReportingPeriod2 { get; set; }
        public Nullable<System.DateTime> StartDate2 { get; set; }
        public Nullable<System.DateTime> EndDate2 { get; set; }
        public string ReportingPeriod3 { get; set; }
        public Nullable<System.DateTime> StartDate3 { get; set; }
        public Nullable<System.DateTime> EndDate3 { get; set; }
        public Nullable<byte> IsIncludeTimeBill { get; set; }
        public Nullable<byte> IsIncludeCostBill { get; set; }
        public Nullable<byte> IsIncludeChargeBill { get; set; }
        public Nullable<byte> IsIncludeAdmin { get; set; }
        public Nullable<byte> IsIncludeProBono { get; set; }
        public string ReqTkprs { get; set; }
        public string ReqCodes { get; set; }
        public string MetricTkprSplitList { get; set; }
        public string ReqTkprDate { get; set; }
        public string ReqMattDate { get; set; }
    }
}