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
    
    public partial class WV_Dashboard_Controls_CCC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WV_Dashboard_Controls_CCC()
        {
            this.WV_Dashboard_Highlight_CCC = new HashSet<WV_Dashboard_Highlight_CCC>();
            this.WV_Dashboard_PeriodRange_CCC = new HashSet<WV_Dashboard_PeriodRange_CCC>();
        }
    
        public System.Guid WV_Dashboard_Controls_CCCID { get; set; }
        public System.Guid WV_Dashboard { get; set; }
        public string Description { get; set; }
        public byte WIPAsHours { get; set; }
        public byte BudgetAsHours { get; set; }
        public string CurrencyType { get; set; }
        public Nullable<System.Guid> WorkHoursObj { get; set; }
        public Nullable<System.Guid> YTDBudgetType { get; set; }
        public Nullable<System.Guid> WorkAmtObj { get; set; }
        public Nullable<System.Guid> CollAmtObj { get; set; }
        public Nullable<System.Guid> BillAmtObj { get; set; }
        public Nullable<System.Guid> CombinedObj { get; set; }
        public byte AllowParameterSave { get; set; }
        public byte UseTransactionMonth { get; set; }
        public byte UseTransactionMonthWorkValues { get; set; }
        public Nullable<System.Guid> AgingScheme { get; set; }
        public System.Guid Widget1 { get; set; }
        public System.Guid Widget2 { get; set; }
        public System.Guid Widget3 { get; set; }
        public System.Guid Widget4 { get; set; }
        public System.Guid Widget5 { get; set; }
        public System.Guid Widget6 { get; set; }
        public System.Guid Widget7 { get; set; }
        public System.Guid Widget8 { get; set; }
        public Nullable<int> BudgetYears { get; set; }
        public Nullable<System.Guid> SecurityRole { get; set; }
        public byte CombinedObjectives { get; set; }
        public string RateType { get; set; }
        public byte DefaultPriorPeriod { get; set; }
        public byte AutoRefreshData { get; set; }
        public Nullable<System.Guid> InqDashboard { get; set; }
        public byte IncUnallocated { get; set; }
        public byte Enable28Features { get; set; }
        public byte EnableResp { get; set; }
        public byte EnableSupv { get; set; }
        public byte EnableOrg { get; set; }
        public byte EnablePro { get; set; }
        public byte EnableCliMatSwitch { get; set; }
        public byte CacheFirmOffice { get; set; }
        public byte CacheFirmDept { get; set; }
        public byte CacheFirmSect { get; set; }
        public byte CacheFirmPG { get; set; }
        public byte CacheFirmBTK { get; set; }
        public byte CacheFirmData { get; set; }
        public byte CacheWtkpr { get; set; }
        public byte CacheMtkprBtkpr { get; set; }
        public byte IncInactiveCards { get; set; }
        public byte IsHRCostRate { get; set; }
        public string PrftReportCostGroup { get; set; }
        public byte IsTkprSecDefault { get; set; }
        public byte IsTkprSecOffice { get; set; }
        public byte IsTkprSecDepartment { get; set; }
        public byte IsTkprSecSection { get; set; }
        public byte IsTkprSecPractice { get; set; }
        public Nullable<System.Guid> TkprSecRole { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual AgingScheme AgingScheme1 { get; set; }
        public virtual NxFWKAppObject NxFWKAppObject { get; set; }
        public virtual NxFWKAppObject NxFWKAppObject1 { get; set; }
        public virtual NxMetric NxMetric { get; set; }
        public virtual NxMetric NxMetric1 { get; set; }
        public virtual NxMetric NxMetric2 { get; set; }
        public virtual NxMetric NxMetric3 { get; set; }
        public virtual NxMetric NxMetric4 { get; set; }
        public virtual NxRole NxRole { get; set; }
        public virtual NxRole NxRole1 { get; set; }
        public virtual WV_Dashboard_BudgetType_CCC WV_Dashboard_BudgetType_CCC { get; set; }
        public virtual WV_Dashboard_Widgets_CCC WV_Dashboard_Widgets_CCC { get; set; }
        public virtual WV_Dashboard_Widgets_CCC WV_Dashboard_Widgets_CCC1 { get; set; }
        public virtual WV_Dashboard_Widgets_CCC WV_Dashboard_Widgets_CCC2 { get; set; }
        public virtual WV_Dashboard_Widgets_CCC WV_Dashboard_Widgets_CCC3 { get; set; }
        public virtual WV_Dashboard_Widgets_CCC WV_Dashboard_Widgets_CCC4 { get; set; }
        public virtual WV_Dashboard_Widgets_CCC WV_Dashboard_Widgets_CCC5 { get; set; }
        public virtual WV_Dashboard_Widgets_CCC WV_Dashboard_Widgets_CCC6 { get; set; }
        public virtual WV_Dashboard_Widgets_CCC WV_Dashboard_Widgets_CCC7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WV_Dashboard_Highlight_CCC> WV_Dashboard_Highlight_CCC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WV_Dashboard_PeriodRange_CCC> WV_Dashboard_PeriodRange_CCC { get; set; }
    }
}