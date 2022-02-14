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
    
    public partial class PrftReportRun
    {
        public System.Guid PrftReportRunID { get; set; }
        public string PrftCostRateType { get; set; }
        public byte IsIncludeWIP { get; set; }
        public byte IsIncludeAR { get; set; }
        public string MatterFilter { get; set; }
        public string TkprFilter { get; set; }
        public string TimecardFilter { get; set; }
        public byte IsExpenseCategoryDetail { get; set; }
        public byte IsExpenseCategoryGroupDetail { get; set; }
        public byte IsMatterDetail { get; set; }
        public byte IsClientDetail { get; set; }
        public byte IsTimekeeperDetail { get; set; }
        public string PrftReportCostGroup { get; set; }
        public Nullable<System.DateTime> WIPStartDate { get; set; }
        public Nullable<System.DateTime> WIPEndDate { get; set; }
        public Nullable<decimal> WIPPercent { get; set; }
        public Nullable<decimal> WIPAmount { get; set; }
        public Nullable<System.DateTime> ARStartDate { get; set; }
        public Nullable<System.DateTime> AREndDate { get; set; }
        public Nullable<decimal> ARPercent { get; set; }
        public Nullable<decimal> ARAmount { get; set; }
        public Nullable<byte> UseProjectionsOnly { get; set; }
        public Nullable<decimal> ProjPercent { get; set; }
        public Nullable<decimal> ProjAmount { get; set; }
        public Nullable<decimal> WIPOverride { get; set; }
        public Nullable<decimal> AROverride { get; set; }
        public Nullable<decimal> ProjOverride { get; set; }
        public Nullable<decimal> ReportFactor1 { get; set; }
        public Nullable<decimal> ReportFactor2 { get; set; }
        public Nullable<decimal> ReportFactor3 { get; set; }
        public Nullable<decimal> ReportFactor4 { get; set; }
        public Nullable<decimal> ReportFactor5 { get; set; }
        public Nullable<int> Matter { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<int> RelatedClient { get; set; }
        public Nullable<int> WorkingTimekeeper { get; set; }
        public Nullable<int> BillingTimekeeper { get; set; }
        public byte UseWorkDateForCurrConv { get; set; }
        public byte UseExpenseDateForCurrConv { get; set; }
        public string MetricTkprSplitList { get; set; }
        public string MattDateFilter { get; set; }
        public string TkprDateFilter { get; set; }
        public Nullable<byte> IsUseRevPeriodForCostRate { get; set; }
        public Nullable<byte> IsIncludeCostWriteUpDowns { get; set; }
        public Nullable<byte> IsIncludePeriodDetails { get; set; }
        public string PrftReportCostGroupDetail { get; set; }
        public byte IsIncludeNB { get; set; }
    }
}