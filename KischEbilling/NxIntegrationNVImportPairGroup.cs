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
    
    public partial class NxIntegrationNVImportPairGroup
    {
        public System.Guid NxIntegrationNVImportPairGroupID { get; set; }
        public System.Guid NxIntegrationImportID { get; set; }
    
        public virtual NxIntegrationImport NxIntegrationImport { get; set; }
    }
}