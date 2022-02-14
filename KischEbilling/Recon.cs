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
    
    public partial class Recon
    {
        public System.Guid ReconID { get; set; }
        public int ReconIndex { get; set; }
        public System.DateTime ReconDate { get; set; }
        public string Description { get; set; }
        public string Description_UnformattedText { get; set; }
        public Nullable<int> BankStmt { get; set; }
        public byte IsReversed { get; set; }
        public Nullable<System.DateTime> ReverseDate { get; set; }
        public Nullable<System.Guid> BankRecWorkHdr { get; set; }
        public string ReverseReason { get; set; }
        public byte IsOpenWorksheet { get; set; }
        public Nullable<System.Guid> MoveToWorksheet { get; set; }
        public byte IsRemoveWorksheet { get; set; }
        public string UnreconReason { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual BankRecWorkHdr BankRecWorkHdr1 { get; set; }
        public virtual BankRecWorkHdr BankRecWorkHdr2 { get; set; }
    }
}