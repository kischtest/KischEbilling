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
    
    public partial class NxOptionValue
    {
        public System.Guid NxOptionValueID { get; set; }
        public string NxOptionID { get; set; }
        public string OverrideType { get; set; }
        public string NxUnit { get; set; }
        public Nullable<System.Guid> NxRole { get; set; }
        public Nullable<System.Guid> NxUser { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxFWKUser NxFWKUser { get; set; }
        public virtual NxRole NxRole1 { get; set; }
    }
}