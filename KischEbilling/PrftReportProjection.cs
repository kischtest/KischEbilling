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
    
    public partial class PrftReportProjection
    {
        public System.Guid PrftReportProjectionsID { get; set; }
        public System.Guid PrftReport { get; set; }
        public int Timekeeper { get; set; }
        public int Matter { get; set; }
        public decimal Hours { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual PrftReport PrftReport1 { get; set; }
    }
}