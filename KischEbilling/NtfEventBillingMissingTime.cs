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
    
    public partial class NtfEventBillingMissingTime
    {
        public System.Guid NtfEventBillingMissingTimeID { get; set; }
        public string NtfDetermineDatesUsingList { get; set; }
        public int GraceDays { get; set; }
        public Nullable<int> DaysToCheck { get; set; }
        public Nullable<System.DateTime> StartingDate { get; set; }
        public Nullable<byte> IncludeUnfinalizedTime { get; set; }
        public Nullable<decimal> MinimumHours { get; set; }
        public Nullable<int> MinimumMissingDays { get; set; }
        public Nullable<int> TotalHoursToCheck { get; set; }
        public string MissingTimePredicate { get; set; }
    }
}