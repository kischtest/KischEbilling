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
    
    public partial class GLType
    {
        public System.Guid GLTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Nullable<byte> IsFirmAccess { get; set; }
        public string GLTypeFuncList { get; set; }
        public byte IsPersist { get; set; }
        public string UnitCalendar { get; set; }
        public Nullable<int> FuturePeriod { get; set; }
        public string RelatedGLType { get; set; }
        public Nullable<byte> IsUseReceiptMultiCurrency { get; set; }
        public Nullable<byte> IsUseTaxClearing { get; set; }
        public byte IsMaskingOnly { get; set; }
        public byte IsDirectGLOnly { get; set; }
    }
}