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
    
    public partial class NxIntegrationExportFileFormatOutputField
    {
        public System.Guid NxIntegrationExportFileFormatOutputFieldID { get; set; }
        public Nullable<System.Guid> FileRel { get; set; }
        public string DataFieldPrefix { get; set; }
        public string DataField { get; set; }
        public string DataFieldPostfix { get; set; }
        public string DataLabel { get; set; }
        public Nullable<System.Guid> DLen { get; set; }
        public string PadCharacter { get; set; }
        public string FixedLength { get; set; }
        public Nullable<System.Guid> RecordDelimiter { get; set; }
        public string CustomDelimitor { get; set; }
        public int OutputSequence { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxIntegrationExpFileConfig NxIntegrationExpFileConfig { get; set; }
        public virtual NxIntExpFileDataLen NxIntExpFileDataLen { get; set; }
        public virtual NxIntExpRecDelimiter NxIntExpRecDelimiter { get; set; }
    }
}