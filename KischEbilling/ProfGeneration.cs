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
    
    public partial class ProfGeneration
    {
        public System.Guid ProfGenerationID { get; set; }
        public Nullable<int> BillingTkpr { get; set; }
        public string BillingGroup { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<int> Matter { get; set; }
        public string TkprTeam { get; set; }
        public string Office { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public string PracticeGroup { get; set; }
        public string Arrangement { get; set; }
        public string BillingFrequency { get; set; }
        public System.Guid ProfGenerationRun { get; set; }
        public byte IsCreateNoTrans { get; set; }
        public string MatterPredicate { get; set; }
        public byte IsTrustBal { get; set; }
        public byte IsUnallocatedBal { get; set; }
        public byte IsBOABal { get; set; }
        public byte IsARBal { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual ProfGenerationRun ProfGenerationRun1 { get; set; }
    }
}