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
    
    public partial class BalHistAR
    {
        public System.Guid BalHistARID { get; set; }
        public string Period { get; set; }
        public string Currency { get; set; }
        public Nullable<int> Matter { get; set; }
        public Nullable<System.Guid> MattDate { get; set; }
        public Nullable<System.Guid> CliDate { get; set; }
        public Nullable<int> ARDetail { get; set; }
        public string TranType { get; set; }
        public string WorkType { get; set; }
        public string TimeType { get; set; }
        public string CostType { get; set; }
        public string ChrgType { get; set; }
        public string WorkOffice { get; set; }
        public Nullable<System.Guid> WorkTkpr { get; set; }
        public string BillOffice { get; set; }
        public Nullable<decimal> Fees { get; set; }
        public Nullable<decimal> HardCosts { get; set; }
        public Nullable<decimal> SoftCosts { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> Interest { get; set; }
        public Nullable<decimal> BOA { get; set; }
        public Nullable<decimal> Other { get; set; }
        public Nullable<decimal> Unallocated { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Doubtful { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual CliDate CliDate1 { get; set; }
        public virtual MattDate MattDate1 { get; set; }
        public virtual TkprDate TkprDate { get; set; }
    }
}