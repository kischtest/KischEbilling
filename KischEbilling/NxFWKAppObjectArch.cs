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
    
    public partial class NxFWKAppObjectArch
    {
        public System.Guid NxFWKAppObjectArchID { get; set; }
        public string InstallDataType { get; set; }
        public string ExtractSQL { get; set; }
        public string MergeAssemblyName { get; set; }
        public string MergeClassName { get; set; }
        public System.Guid AppObjectID { get; set; }
        public byte IsFrameworkArch { get; set; }
        public string ExternalInstallDataType { get; set; }
        public string ExternalExtractSQL { get; set; }
    
        public virtual NxFWKAppObject NxFWKAppObject { get; set; }
    }
}