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
    
    public partial class CmSubEvent
    {
        public System.Guid CmSubEventID { get; set; }
        public int CmSubEventIndex { get; set; }
        public Nullable<byte> IsSelected { get; set; }
        public string CmEvSendAsList { get; set; }
        public byte IsCalendar { get; set; }
        public byte IsManaging { get; set; }
        public int CmSubTkpr { get; set; }
        public Nullable<int> CmMasterEvent { get; set; }
        public Nullable<System.DateTime> CompDateTime { get; set; }
        public Nullable<System.DateTime> EndingDate { get; set; }
        public Nullable<byte> IscompletionRequired { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}