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
    
    public partial class FADeprHist
    {
        public System.Guid FADeprHistID { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<int> AssetBook { get; set; }
        public string Period { get; set; }
        public string TranType { get; set; }
        public Nullable<decimal> CurrMoDepr { get; set; }
        public Nullable<decimal> CatchUpDepr { get; set; }
        public Nullable<decimal> TotalDepr { get; set; }
        public Nullable<byte> IsClosed { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}