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
    
    public partial class CftSearchGenAttrSetup
    {
        public System.Guid CftSearchGenAttrSetupID { get; set; }
        public string Archetype { get; set; }
        public string Attribute { get; set; }
        public string Caption { get; set; }
        public string ProcessID { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<System.Guid> CftSearchGenArchSetup { get; set; }
        public byte IsHideIfSecured { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual CftSearchGenArchSetup CftSearchGenArchSetup1 { get; set; }
    }
}