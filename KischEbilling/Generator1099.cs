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
    
    public partial class Generator1099
    {
        public System.Guid Generator1099ID { get; set; }
        public int GenIndex { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public byte IsIncludeAP { get; set; }
        public byte IsIncludeTrust { get; set; }
        public byte IsIncludeDeferComp { get; set; }
        public byte IsOnlyNon1099Payee { get; set; }
        public byte IsUseAddrOrgName { get; set; }
        public byte IsUsePayeeTypeForComp { get; set; }
        public string CompMapTo { get; set; }
        public string PayeePred { get; set; }
        public string NxUnit { get; set; }
        public byte IsSumByTaxID { get; set; }
        public byte IsSumByVendor { get; set; }
        public byte IsSumByPayee { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}