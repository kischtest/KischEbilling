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
    
    public partial class MxICBWHTParamRun
    {
        public System.Guid MxICBWHTParamRunID { get; set; }
        public Nullable<byte> IncInvWithRcpts { get; set; }
        public Nullable<System.DateTime> InvStartDate { get; set; }
        public Nullable<byte> IncRevInvcs { get; set; }
        public Nullable<System.DateTime> InvEndDate { get; set; }
        public Nullable<System.DateTime> RcptStartDate { get; set; }
        public Nullable<System.DateTime> RcptEndDate { get; set; }
        public string WithholdingTaxCode { get; set; }
        public string Matter { get; set; }
        public string UnitDueTo { get; set; }
        public string UnitDueFrom { get; set; }
    }
}