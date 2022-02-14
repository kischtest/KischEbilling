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
    
    public partial class CollectionStep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CollectionStep()
        {
            this.ScheduledCollectionActions = new HashSet<ScheduledCollectionAction>();
        }
    
        public System.Guid CollectionStepID { get; set; }
        public int StepNumber { get; set; }
        public int CollectionItem { get; set; }
        public string Action { get; set; }
        public Nullable<System.Guid> Collector { get; set; }
        public Nullable<int> ActionPriority { get; set; }
        public byte IsDoneIfInvIsPaid { get; set; }
        public byte IsDoneImmediately { get; set; }
        public int DaysAfter { get; set; }
        public string DateSourceTypeList { get; set; }
        public Nullable<System.DateTime> ScheduledDate { get; set; }
        public Nullable<byte> IsStepRepeated { get; set; }
        public string ActionByTypeList { get; set; }
        public Nullable<System.Guid> PrinterTemplate { get; set; }
        public string Comments { get; set; }
        public Nullable<byte> IsCompleted { get; set; }
        public Nullable<System.Guid> CompletedBy { get; set; }
        public string CollectionActorList { get; set; }
        public string EmailAddr { get; set; }
        public string EmailSubject { get; set; }
        public string EmailFromAddress { get; set; }
        public string EmailCCAddress { get; set; }
        public string EmailBCCAddress { get; set; }
        public string BillingOffice { get; set; }
        public Nullable<int> MatterLanguage { get; set; }
        public string CollectionOffice { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual Collector Collector1 { get; set; }
        public virtual NxPrinterTemplate NxPrinterTemplate { get; set; }
        public virtual NxUser NxUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduledCollectionAction> ScheduledCollectionActions { get; set; }
    }
}