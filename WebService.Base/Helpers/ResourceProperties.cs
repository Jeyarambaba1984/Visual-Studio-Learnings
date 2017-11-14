using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Base.CAEUMCase;

namespace WebService.Base.Helpers
{
    public class ResourceProperties
    {
        public string ExternalMemberId { get; set; }
        public int ExternalSystemId { get; set; }
        public bool ShouldReturnBrsActions { get; set; }
        public string CareTypeDescription { get; set; }
        public int CareId { get; set; }
        public string CasePriorityDescription { get; set; }
        public int CasePriorityId { get; set; }
        public string CaseSettingDescription { get; set; }
        public int CaseSettingId { get; set; }
        public string CaseTypeDescription { get; set; }
        public int CaseTypeId { get; set; }
        public bool IsUrgent { get; set; }
        public int PlaceOfServiceId { get; set; }
        public string PlaceOfServiceDescription { get; set; }
        public string RequesterId { get; set; }
        public string RequesterName { get; set; }
        public int RequesterTypeId { get; set; }
        public string RequesterPhone { get; set; }
        public string RequesterTypeDescription { get; set; }
        public int ReviewTypeId { get; set; }
        public string ReviewTypeDescription { get; set; }
        public int AuthorizationUnits { get; set; }
        public int RequestedUnits { get; set; }
        public string DiagnosisDescription { get; set; }
        public string DiagnosisCode { get; set; }
        public string DiagnosisId { get; set; }
        public string DiagnosissetID { get; set; }
        public bool IsPrimary { get; set; }
        public string ProcedureDescription { get; set; }
        public string ProcedureCode { get; set; }
        public string ProcedureCodeSetId { get; set; }
        public string RequestingProviderExternalId { get; set; }
        public string RequestingProviderName { get; set; }
        public string ProviderAddressExternalId { get; set; }
        public string ProviderAddressStreet { get; set; }
        public string ProviderAddressExternalAddressType { get; set; }
        public string ProviderAddressCity { get; set; }
        public string ProviderAddressState { get; set; }
        public string ProviderAddressZip { get; set; }
        public bool ProviderIsPrimary { get; set; }
        public int ServiceTypeId { get; set; }
        public string ServiceTypeDescription { get; set; }
        public string TreatingProviderExternalId { get; set; }
        public string TreatingProviderName { get; set; }
        public int TreatingProviderAddressExternalId { get; set; }
        public int TreatingProviderAddressExternalAddressType { get; set; }
        public string TreatingProviderAddressStreet { get; set; }
        public string TreatingProviderAddressCity { get; set; }
        public string TreatingProviderAddressState { get; set; }
        public int TreatingProviderAddressZip { get; set; }

       
    }
}
