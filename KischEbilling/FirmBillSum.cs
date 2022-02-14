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
    
    public partial class FirmBillSum
    {
        public System.Guid FirmBillSumID { get; set; }
        public Nullable<int> Matter { get; set; }
        public Nullable<int> BillMatter { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public string WorkType { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public Nullable<System.Guid> WorkMattEffDateWork { get; set; }
        public Nullable<System.Guid> BillMattEffDateWork { get; set; }
        public Nullable<System.Guid> TkprEffDateWork { get; set; }
        public Nullable<System.Guid> WorkMattEffDateBill { get; set; }
        public Nullable<System.Guid> BillMattEffDateBill { get; set; }
        public Nullable<System.Guid> TkprEffDateBill { get; set; }
        public Nullable<System.Guid> WorkMattEffDateRcpt { get; set; }
        public Nullable<System.Guid> BillMattEffDateRcpt { get; set; }
        public Nullable<System.Guid> TkprEffDateRcpt { get; set; }
        public string WorkTranMonth { get; set; }
        public string BillTranMonth { get; set; }
        public string RcptTranMonth { get; set; }
        public string WorkAcctPeriod { get; set; }
        public string BillAcctPeriod { get; set; }
        public string RcptAcctPeriod { get; set; }
        public Nullable<decimal> OrigFees { get; set; }
        public Nullable<decimal> OrigStd { get; set; }
        public Nullable<decimal> OrigHrs { get; set; }
        public Nullable<decimal> OrigSco { get; set; }
        public Nullable<decimal> OrigHco { get; set; }
        public Nullable<decimal> OrigTax { get; set; }
        public Nullable<decimal> OrigInt { get; set; }
        public Nullable<decimal> OrigBOA { get; set; }
        public Nullable<decimal> OrigOth { get; set; }
        public Nullable<decimal> WorkFees { get; set; }
        public Nullable<decimal> WorkStd { get; set; }
        public Nullable<decimal> WorkHrs { get; set; }
        public Nullable<decimal> WorkSCo { get; set; }
        public Nullable<decimal> WorkHCo { get; set; }
        public Nullable<decimal> WorkTax { get; set; }
        public Nullable<decimal> WorkInt { get; set; }
        public Nullable<decimal> WorkBOA { get; set; }
        public Nullable<decimal> WorkOth { get; set; }
        public Nullable<decimal> NonBillFees { get; set; }
        public Nullable<decimal> NonBillStd { get; set; }
        public Nullable<decimal> NonBillHrs { get; set; }
        public Nullable<decimal> NonBillSCo { get; set; }
        public Nullable<decimal> NonBillHCo { get; set; }
        public Nullable<decimal> NonBillTax { get; set; }
        public Nullable<decimal> NonBillInt { get; set; }
        public Nullable<decimal> NonBillBOA { get; set; }
        public Nullable<decimal> NonBillOth { get; set; }
        public Nullable<decimal> WUFees { get; set; }
        public Nullable<decimal> WUStd { get; set; }
        public Nullable<decimal> WUHrs { get; set; }
        public Nullable<decimal> WUSCo { get; set; }
        public Nullable<decimal> WUHCo { get; set; }
        public Nullable<decimal> WUTax { get; set; }
        public Nullable<decimal> WUInt { get; set; }
        public Nullable<decimal> WUBOA { get; set; }
        public Nullable<decimal> WUOth { get; set; }
        public Nullable<decimal> WDFees { get; set; }
        public Nullable<decimal> WDStd { get; set; }
        public Nullable<decimal> WDHrs { get; set; }
        public Nullable<decimal> WDSCo { get; set; }
        public Nullable<decimal> WDHCo { get; set; }
        public Nullable<decimal> WDTax { get; set; }
        public Nullable<decimal> WDInt { get; set; }
        public Nullable<decimal> WDBOA { get; set; }
        public Nullable<decimal> WDOth { get; set; }
        public Nullable<decimal> BillFees { get; set; }
        public Nullable<decimal> BillStd { get; set; }
        public Nullable<decimal> BillHrs { get; set; }
        public Nullable<decimal> BillSCo { get; set; }
        public Nullable<decimal> BillHCo { get; set; }
        public Nullable<decimal> BillTax { get; set; }
        public Nullable<decimal> BillInt { get; set; }
        public Nullable<decimal> BillBOA { get; set; }
        public Nullable<decimal> BillOth { get; set; }
        public Nullable<decimal> ColFees { get; set; }
        public Nullable<decimal> ColStd { get; set; }
        public Nullable<decimal> ColHrs { get; set; }
        public Nullable<decimal> ColSCo { get; set; }
        public Nullable<decimal> ColHCo { get; set; }
        public Nullable<decimal> ColTax { get; set; }
        public Nullable<decimal> ColInt { get; set; }
        public Nullable<decimal> ColBOA { get; set; }
        public Nullable<decimal> ColOth { get; set; }
        public Nullable<decimal> WOFees { get; set; }
        public Nullable<decimal> WOStd { get; set; }
        public Nullable<decimal> WOHrs { get; set; }
        public Nullable<decimal> WOSCo { get; set; }
        public Nullable<decimal> WOHCo { get; set; }
        public Nullable<decimal> WOTax { get; set; }
        public Nullable<decimal> WOInt { get; set; }
        public Nullable<decimal> WOBOA { get; set; }
        public Nullable<decimal> WOOth { get; set; }
        public Nullable<decimal> RefFees { get; set; }
        public Nullable<decimal> RefSCo { get; set; }
        public Nullable<decimal> RefHCo { get; set; }
        public Nullable<decimal> WIPFees { get; set; }
        public Nullable<decimal> WIPStd { get; set; }
        public Nullable<decimal> WIPHrs { get; set; }
        public Nullable<decimal> WIPSCo { get; set; }
        public Nullable<decimal> WIPHCO { get; set; }
        public Nullable<decimal> WIPTax { get; set; }
        public Nullable<decimal> WIPInt { get; set; }
        public Nullable<decimal> WIPBOA { get; set; }
        public Nullable<decimal> WIPOth { get; set; }
        public int FirmBillSumIndex { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual MattDate MattDate { get; set; }
        public virtual MattDate MattDate1 { get; set; }
        public virtual MattDate MattDate2 { get; set; }
        public virtual MattDate MattDate3 { get; set; }
        public virtual MattDate MattDate4 { get; set; }
        public virtual MattDate MattDate5 { get; set; }
        public virtual TkprDate TkprDate { get; set; }
        public virtual TkprDate TkprDate1 { get; set; }
        public virtual TkprDate TkprDate2 { get; set; }
    }
}