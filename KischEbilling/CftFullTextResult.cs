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
    
    public partial class CftFullTextResult
    {
        public System.Guid CftFullTextResultsID { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> ItemID { get; set; }
        public Nullable<System.Guid> SearchID { get; set; }
        public Nullable<System.Guid> SearchTermID { get; set; }
        public byte IsFiltered { get; set; }
        public int PageNumber { get; set; }
        public string AttributeCode { get; set; }
        public string ProviderCode { get; set; }
        public string SourceCollection { get; set; }
        public string AttributeText { get; set; }
        public string HighlightedText { get; set; }
        public Nullable<System.Guid> DocumentID { get; set; }
        public Nullable<int> SearchTermSortOrder { get; set; }
        public byte IsResolvedToAnotherHit { get; set; }
        public string ResolvedFromArchetype { get; set; }
        public Nullable<System.Guid> ResolvedFromItemID { get; set; }
        public Nullable<int> Risk { get; set; }
        public string CompareStatus { get; set; }
        public string ExternalItemID { get; set; }
        public int CftFTXIndex { get; set; }
        public string SearchTermGroupingLabel { get; set; }
        public byte IsIncludedInSearchResults { get; set; }
        public byte IsExcludedFromSearchResults { get; set; }
        public byte IsEthicalWall { get; set; }
        public Nullable<System.Guid> EntityClassEntityID { get; set; }
        public Nullable<int> SearchTermRoleCodeSortValue { get; set; }
    }
}