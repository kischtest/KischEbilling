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
    
    public partial class WorkCalendar
    {
        public System.Guid WorkCalendarID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> HoursPerMonth { get; set; }
        public Nullable<decimal> HoursPerWeek { get; set; }
        public Nullable<decimal> HoursMonday { get; set; }
        public Nullable<decimal> HoursTuesday { get; set; }
        public Nullable<decimal> HoursWednesday { get; set; }
        public Nullable<decimal> HoursThursday { get; set; }
        public Nullable<decimal> HoursFriday { get; set; }
        public Nullable<decimal> HoursSaturday { get; set; }
        public Nullable<decimal> HoursSunday { get; set; }
    }
}