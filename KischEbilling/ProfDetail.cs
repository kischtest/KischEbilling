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
    
    public partial class ProfDetail
    {
        public System.Guid ProfDetailID { get; set; }
        public int ProfDetIndex { get; set; }
        public int ProfMaster { get; set; }
        public string ProfDetailArchetype { get; set; }
        public Nullable<System.Guid> ProfMatter { get; set; }
        public Nullable<int> Timecard { get; set; }
        public Nullable<int> CostCard { get; set; }
        public Nullable<int> ChrgCard { get; set; }
        public Nullable<int> ParentCard { get; set; }
        public Nullable<System.Guid> ParentDetail { get; set; }
        public string Currency { get; set; }
        public System.DateTime CurrDate { get; set; }
        public string OrigCurrency { get; set; }
        public string TransactionType { get; set; }
        public byte IsDisplay { get; set; }
        public int WorkMatter { get; set; }
        public System.Guid WorkMattEffDate { get; set; }
        public Nullable<int> BillMatter { get; set; }
        public Nullable<System.Guid> BillMattEffDate { get; set; }
        public Nullable<int> WorkTimekeeper { get; set; }
        public Nullable<System.Guid> WorkTkprEffDate { get; set; }
        public byte IsSplit { get; set; }
        public System.DateTime WorkDate { get; set; }
        public string Office { get; set; }
        public byte IsWorkNoCharge { get; set; }
        public Nullable<decimal> WorkHrs { get; set; }
        public Nullable<decimal> WorkOrigAmt { get; set; }
        public Nullable<decimal> WorkStdAmt { get; set; }
        public decimal WorkAmt { get; set; }
        public Nullable<decimal> WorkQnt { get; set; }
        public Nullable<decimal> WorkRate { get; set; }
        public string WorkTaxJuris { get; set; }
        public Nullable<System.Guid> WorkPhase { get; set; }
        public Nullable<System.Guid> WorkTask { get; set; }
        public Nullable<System.Guid> WorkActivity { get; set; }
        public string WorkTaxCode { get; set; }
        public int WorkLanguage { get; set; }
        public string WorkNarrative { get; set; }
        public string WorkNarrative_UnformattedText { get; set; }
        public Nullable<System.DateTime> WorkStartTime { get; set; }
        public string WorkTimeInterval { get; set; }
        public string WorkEntryUnitType { get; set; }
        public Nullable<int> WorkEntryUnit { get; set; }
        public string WorkTimeType { get; set; }
        public string WorkCostEntryUnitType { get; set; }
        public Nullable<int> WorkCostEntryUnit { get; set; }
        public string WorkCostType { get; set; }
        public string WorkChrgType { get; set; }
        public string WorkWorkType { get; set; }
        public Nullable<decimal> EditHrs { get; set; }
        public Nullable<decimal> EditAmt { get; set; }
        public Nullable<decimal> EditQnt { get; set; }
        public Nullable<decimal> EditRate { get; set; }
        public string EditAllocMethod { get; set; }
        public string EditTranType { get; set; }
        public Nullable<int> PresMatter { get; set; }
        public Nullable<System.Guid> PresMattEffDate { get; set; }
        public Nullable<int> PresTimekeeper { get; set; }
        public Nullable<System.Guid> PresTkprEffDate { get; set; }
        public Nullable<System.DateTime> PresDate { get; set; }
        public Nullable<byte> PresIsNoCharge { get; set; }
        public Nullable<decimal> PresHrs { get; set; }
        public Nullable<decimal> PresAmt { get; set; }
        public Nullable<decimal> PresRate { get; set; }
        public Nullable<decimal> PresQnt { get; set; }
        public string PresTaxJuris { get; set; }
        public Nullable<System.Guid> PresPhase { get; set; }
        public Nullable<System.Guid> PresTask { get; set; }
        public Nullable<System.Guid> PresActivity { get; set; }
        public string PresTaxCode { get; set; }
        public Nullable<int> PresLanguage { get; set; }
        public string PresNarrative { get; set; }
        public string PresNarrative_UnformattedText { get; set; }
        public Nullable<System.DateTime> PresStartTime { get; set; }
        public string PresTimeInterval { get; set; }
        public string PresEntryUnitType { get; set; }
        public Nullable<int> PresEntryUnit { get; set; }
        public string PresTimeType { get; set; }
        public string PresCostEntryUnitType { get; set; }
        public Nullable<int> PresCostEntryUnit { get; set; }
        public string PresCostType { get; set; }
        public string PresChrgType { get; set; }
        public string PresWorkType { get; set; }
        public Nullable<byte> IsChangedNarrative { get; set; }
        public string ReasonType { get; set; }
        public string Disposition { get; set; }
        public string InternalComments { get; set; }
        public string RateCalcList { get; set; }
        public byte IsExcluded { get; set; }
        public byte IsNB { get; set; }
        public byte IsCalculated { get; set; }
        public byte IsAnticipated { get; set; }
        public Nullable<int> TransferProforma { get; set; }
        public byte IsOverride { get; set; }
        public Nullable<int> AnticipatedChrgCard { get; set; }
        public string PurgeType { get; set; }
        public Nullable<decimal> ToleranceAmt { get; set; }
        public Nullable<decimal> TolerancePct { get; set; }
        public string ChrgCalcList { get; set; }
        public string SortString { get; set; }
        public Nullable<int> AuthTimekeeper { get; set; }
        public Nullable<int> SpvTimekeeper { get; set; }
        public string TimePracticeArea { get; set; }
        public string MatrixTaxCode { get; set; }
        public byte IsDoNotSummarize { get; set; }
        public byte IsEBillVal { get; set; }
        public string EBillValMessage { get; set; }
        public string TransferCurrency { get; set; }
        public Nullable<decimal> TransferRate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string EditStatus { get; set; }
        public Nullable<decimal> TransferWIPRate { get; set; }
        public Nullable<System.Guid> WorkPhase2 { get; set; }
        public Nullable<System.Guid> WorkTask2 { get; set; }
        public Nullable<System.Guid> WorkActivity2 { get; set; }
        public Nullable<System.Guid> PresPhase2 { get; set; }
        public Nullable<System.Guid> PresTask2 { get; set; }
        public Nullable<System.Guid> PresActivity2 { get; set; }
        public Nullable<int> ProfDetailEdit { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Activity Activity1 { get; set; }
        public virtual Activity Activity2 { get; set; }
        public virtual Activity Activity3 { get; set; }
        public virtual MattDate MattDate { get; set; }
        public virtual MattDate MattDate1 { get; set; }
        public virtual MattDate MattDate2 { get; set; }
        public virtual Phase Phase { get; set; }
        public virtual Phase Phase1 { get; set; }
        public virtual Phase Phase2 { get; set; }
        public virtual Phase Phase3 { get; set; }
        public virtual ProfMatter ProfMatter1 { get; set; }
        public virtual Task Task { get; set; }
        public virtual Task Task1 { get; set; }
        public virtual Task Task2 { get; set; }
        public virtual Task Task3 { get; set; }
        public virtual TkprDate TkprDate { get; set; }
        public virtual TkprDate TkprDate1 { get; set; }
    }
}