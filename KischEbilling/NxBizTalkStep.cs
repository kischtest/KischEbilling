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
    
    public partial class NxBizTalkStep
    {
        public System.Guid NxBizTalkStepID { get; set; }
        public string StepName { get; set; }
        public System.Guid StepType { get; set; }
        public string StepDescription { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string StepBinary { get; set; }
        public Nullable<int> StepOrderID { get; set; }
        public string SourceSchemaNamespace { get; set; }
        public string MapNamespace { get; set; }
        public string DestinationSchemaNamespace { get; set; }
        public string DestinationSchemaAssemblyName { get; set; }
        public string AlternateStepBinary { get; set; }
    
        public virtual NxBizTalkStepType NxBizTalkStepType { get; set; }
    }
}