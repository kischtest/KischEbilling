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
    
    public partial class AVRReportToUserSubscription
    {
        public System.Guid AVRReportToUserSubscriptionsID { get; set; }
        public int AVRReportToUserSubIndex { get; set; }
        public System.Guid AVRReportSubscriptions { get; set; }
        public Nullable<System.Guid> NxBaseUser { get; set; }
        public Nullable<byte> IsBrowserRole { get; set; }
        public Nullable<byte> IsContentManagerRole { get; set; }
        public Nullable<byte> IsMyReportsRole { get; set; }
        public Nullable<byte> IsPublisherRole { get; set; }
        public Nullable<byte> IsReportBuilderRole { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual AVRReportSubscription AVRReportSubscription { get; set; }
        public virtual NxBaseUser NxBaseUser1 { get; set; }
    }
}