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
    
    public partial class RMBaseFilePhas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RMBaseFilePhas()
        {
            this.RMRetRvwCtrFiles = new HashSet<RMRetRvwCtrFile>();
        }
    
        public System.Guid RMBaseFilePhasesID { get; set; }
        public int RMBaseFile { get; set; }
        public string RMRetActionList { get; set; }
        public Nullable<System.DateTime> SchedActionDate { get; set; }
        public Nullable<System.Guid> NxUser { get; set; }
        public Nullable<System.Guid> RMRetPhase { get; set; }
        public string RetComment { get; set; }
        public string RMRetDecisionInit { get; set; }
        public Nullable<int> RMEntityRetRvwr { get; set; }
        public Nullable<int> RMEntityRecordsAnalyst { get; set; }
        public string RMRetDecisionFinal { get; set; }
        public Nullable<int> RMEntityFinalApprover { get; set; }
        public Nullable<System.DateTime> RetNotifyDate { get; set; }
        public Nullable<int> NotifyCount { get; set; }
        public Nullable<System.DateTime> CompleteDate { get; set; }
        public int RMBaseFilePhasesIndex { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxUser NxUser1 { get; set; }
        public virtual RMRetPhase RMRetPhase1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RMRetRvwCtrFile> RMRetRvwCtrFiles { get; set; }
    }
}