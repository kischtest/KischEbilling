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
    
    public partial class MxGLSummaryRun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MxGLSummaryRun()
        {
            this.MxGLSummaryRunDets = new HashSet<MxGLSummaryRunDet>();
        }
    
        public System.Guid MxGLSummaryRunID { get; set; }
        public string GLBook { get; set; }
        public Nullable<int> FiscalYear { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyType { get; set; }
        public string CurrencyCalcDate { get; set; }
        public Nullable<System.Guid> GLNaturalLow { get; set; }
        public Nullable<System.Guid> GLNaturalHigh { get; set; }
        public Nullable<System.Guid> GLUnitLow { get; set; }
        public Nullable<System.Guid> GLUnitHigh { get; set; }
        public Nullable<System.Guid> GLDepartmentLow { get; set; }
        public Nullable<System.Guid> GLDepartmentHigh { get; set; }
        public Nullable<System.Guid> GLTimekeeperLow { get; set; }
        public Nullable<System.Guid> GLTimekeeperHigh { get; set; }
        public Nullable<System.Guid> GLArrangementLow { get; set; }
        public Nullable<System.Guid> GLArrangementHigh { get; set; }
        public Nullable<System.Guid> GLPracticeGroupLow { get; set; }
        public Nullable<System.Guid> GLPracticeGroupHigh { get; set; }
        public Nullable<System.Guid> GLSectionLow { get; set; }
        public Nullable<System.Guid> GLSectionHigh { get; set; }
        public Nullable<System.Guid> GLTitleLow { get; set; }
        public Nullable<System.Guid> GLTitleHigh { get; set; }
        public Nullable<System.Guid> GLWorkTypeLow { get; set; }
        public Nullable<System.Guid> GLWorkTypeHigh { get; set; }
        public Nullable<System.Guid> GLUnitLocalLow { get; set; }
        public Nullable<System.Guid> GLUnitLocalHigh { get; set; }
        public Nullable<System.Guid> GLOfficeLow { get; set; }
        public Nullable<System.Guid> GLOfficeHigh { get; set; }
        public string GLTypeFilter { get; set; }
        public Nullable<int> ToPeriod { get; set; }
        public byte IsExcludeZeroRows { get; set; }
        public Nullable<System.Guid> GLSummaryList { get; set; }
        public string GLNaturalValueLow { get; set; }
        public string GLNaturalValueHigh { get; set; }
        public string GLUnitValueLow { get; set; }
        public string GLUnitValueHigh { get; set; }
        public string GLTimekeeperValueLow { get; set; }
        public string GLTimekeeperValueHigh { get; set; }
        public string GLDepartmentValueLow { get; set; }
        public string GLDepartmentValueHigh { get; set; }
        public string GLArrangementValueLow { get; set; }
        public string GLArrangementValueHigh { get; set; }
        public string GLPracticeGroupValueLow { get; set; }
        public string GLPracticeGroupValueHigh { get; set; }
        public string GLSectionValueLow { get; set; }
        public string GLSectionValueHigh { get; set; }
        public string GLOfficeValueLow { get; set; }
        public string GLOfficeValueHigh { get; set; }
        public string GLTitleValueLow { get; set; }
        public string GLTitleValueHigh { get; set; }
        public string GLWorkTypeValueLow { get; set; }
        public string GLWorkTypeValueHigh { get; set; }
        public string GLUnitLocalValueLow { get; set; }
        public string GLUnitLocalValueHigh { get; set; }
        public byte IsIncludeNoActivity { get; set; }
        public byte IsIncludeNoActivityInactive { get; set; }
        public string GLActivityValueLow { get; set; }
        public string GLActivityValueHigh { get; set; }
    
        public virtual GLArrangement GLArrangement { get; set; }
        public virtual GLArrangement GLArrangement1 { get; set; }
        public virtual GLDepartment GLDepartment { get; set; }
        public virtual GLDepartment GLDepartment1 { get; set; }
        public virtual GLNatural GLNatural { get; set; }
        public virtual GLNatural GLNatural1 { get; set; }
        public virtual GLOffice GLOffice { get; set; }
        public virtual GLOffice GLOffice1 { get; set; }
        public virtual GLPracticeGroup GLPracticeGroup { get; set; }
        public virtual GLPracticeGroup GLPracticeGroup1 { get; set; }
        public virtual GLSection GLSection { get; set; }
        public virtual GLSection GLSection1 { get; set; }
        public virtual GLSummaryList GLSummaryList1 { get; set; }
        public virtual GLTimekeeper GLTimekeeper { get; set; }
        public virtual GLTimekeeper GLTimekeeper1 { get; set; }
        public virtual GLTitle GLTitle { get; set; }
        public virtual GLTitle GLTitle1 { get; set; }
        public virtual GLUnit GLUnit { get; set; }
        public virtual GLUnit GLUnit1 { get; set; }
        public virtual GLUnitLocal GLUnitLocal { get; set; }
        public virtual GLUnitLocal GLUnitLocal1 { get; set; }
        public virtual GLWorkType GLWorkType { get; set; }
        public virtual GLWorkType GLWorkType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLSummaryRunDet> MxGLSummaryRunDets { get; set; }
    }
}