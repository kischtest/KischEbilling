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
    
    public partial class RMDeedsUdtk
    {
        public System.Guid RMDeedsUdtksID { get; set; }
        public int DeedsUdtksIndex { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Entity { get; set; }
        public string Comments { get; set; }
        public string Comments_UnformattedText { get; set; }
        public Nullable<int> RMDeeds { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}