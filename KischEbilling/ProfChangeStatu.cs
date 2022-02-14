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
    
    public partial class ProfChangeStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProfChangeStatu()
        {
            this.ProfChangeStatusDetails = new HashSet<ProfChangeStatusDetail>();
            this.ProformaStatusGCEvents = new HashSet<ProformaStatusGCEvent>();
        }
    
        public System.Guid ProfChangeStatusID { get; set; }
        public System.DateTime ChangeDate { get; set; }
        public System.Guid ChangeUser { get; set; }
        public string ToProfStatus { get; set; }
        public string RelProfStatus { get; set; }
        public string Comment { get; set; }
        public Nullable<byte> IsIncludeOtherProforma { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxUser NxUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfChangeStatusDetail> ProfChangeStatusDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProformaStatusGCEvent> ProformaStatusGCEvents { get; set; }
    }
}