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
    
    public partial class NxOptionList
    {
        public System.Guid NxOptionListID { get; set; }
        public string OptionList { get; set; }
        public Nullable<System.Guid> SystemDefault { get; set; }
    
        public virtual NxGenericListItem NxGenericListItem { get; set; }
    }
}