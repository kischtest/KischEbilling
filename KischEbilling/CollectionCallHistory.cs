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
    
    public partial class CollectionCallHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CollectionCallHistory()
        {
            this.CollectionPromises = new HashSet<CollectionPromise>();
            this.FollowUpCollectionActions = new HashSet<FollowUpCollectionAction>();
        }
    
        public System.Guid CollectionCallHistoryID { get; set; }
        public int CollectionItem { get; set; }
        public System.Guid FirmRepresentative { get; set; }
        public System.DateTime CallDate { get; set; }
        public byte IsCallInitiatedByFirm { get; set; }
        public int Payor { get; set; }
        public string Correspondent { get; set; }
        public string CorrespondentPhone { get; set; }
        public string CorrespondentEmail { get; set; }
        public string Reason { get; set; }
        public string ConversationText { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxUser NxUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionPromise> CollectionPromises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FollowUpCollectionAction> FollowUpCollectionActions { get; set; }
    }
}