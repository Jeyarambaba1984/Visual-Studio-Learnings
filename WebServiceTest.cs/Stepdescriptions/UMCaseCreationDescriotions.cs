using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NUnit.Framework;
using WebService.Base.CAEUMCase;
using System.Net;
using WebService.Base.Helpers;

namespace WebServiceTest.cs.Stepdescriptions
{
    public class UMCaseCreationDescriptions
    {
        public static WebserviceHelpers _help;
        public UMCaseCreationDescriptions()
        {
            _help = new WebserviceHelpers();
        }
        public void CreateUMCaseInstance(string ServiceType)
        {
            _help.createInstance(ServiceType);
            _help.IgnoreSSLWarnings();
        }

        public CreateCaseSvcRequest InvokeCreateUMCaseResource(ResourceProperties UMCase)
        {
            var request = new CreateCaseSvcRequest()
            {
                SessionId = string.Empty,

                ExternalMember = new ExternalMember()
                {
                    ExternalMemberId = UMCase.ExternalMemberId,
                    ExternalSystemId = UMCase.ExternalSystemId
                },
                ShouldReturnBrsActions = UMCase.ShouldReturnBrsActions,

                UmCase = new UmCase()
                {
                    WorkflowRunMode = WorkflowRunMode.ActionsAndDecisions,

                    CareType = new SystemSpecificValueOption()
                    {
                        Description = UMCase.CareTypeDescription,
                        Id = UMCase.CareId
                    },
                    CasePriority = new SystemSpecificValueOption()
                    {
                        Description = UMCase.CasePriorityDescription,
                        Id = UMCase.CasePriorityId
                    },
                    CaseSetting = new SystemSpecificValueOption()
                    {
                        Id = UMCase.CaseSettingId,
                        Description = UMCase.CaseSettingDescription
                    },
                    CaseType = new SystemSpecificValueOption()
                    {
                        Id = UMCase.CaseTypeId,
                        Description = UMCase.CaseTypeDescription
                    },
                    IsUrgent = UMCase.IsUrgent,

                    PlaceOfService = new SystemSpecificValueOption()
                    {
                        Id = UMCase.PlaceOfServiceId,
                        Description = UMCase.PlaceOfServiceDescription
                    },
                    RequestDate = DateTime.Now,
                    Requester = new Requester()
                    {
                        Id = UMCase.RequesterId,
                        Name = UMCase.RequesterName,
                        Phone = UMCase.RequesterPhone,
                        Type = new SystemSpecificValueOption()
                        {
                            Id = UMCase.RequesterTypeId,
                            Description = UMCase.RequesterTypeDescription
                        }
                    },
                    ReviewType = new SystemSpecificValueOption()
                    {
                        Id = UMCase.ReviewTypeId,
                        Description = UMCase.ReviewTypeDescription
                    },
                    Services = new Service[1]
                        {
                            new Service()
                            {
                                Certifications = new Certification[1]
                                {
                                    new Certification()
                                    {
                                        AuthorizedUnits=UMCase.AuthorizationUnits,
                                        FromDate=DateTime.Now,
                                        RequestedUnits=UMCase.RequestedUnits,
                                        ToDate=DateTime.Now,
                                    },
                                },
                                Diagnosis = new Diagnosis()
                                {
                                    Code=UMCase.DiagnosisCode,
                                 //   CodeSetId= Enum.Parse(DiagnosisCodeSet, UMCase.DiagnosissetID);
                                     CodeSetId= DiagnosisCodeSet.ICD9,
                                    //CodeSetId= DiagnosisCodeSet.ICD9,
                                    Description=UMCase.DiagnosisDescription
                                },

                                IsPrimary=UMCase.IsPrimary,

                                Procedure = new Procedure()
                                {
                                    Code=UMCase.ProcedureCode,
                                    CodeSetId=ProcedureCodeSet.CPT,
                                    Description=UMCase.ProcedureDescription,
                                },
                                RequestingProvider = new Provider()
                                {
                                    ExternalId=UMCase.RequestingProviderExternalId,
                                    Name=UMCase.RequestingProviderName,
                                    AddressList=new ProviderAddress[]
                                    {
                                        new ProviderAddress()
                                        {
                                            ExternalId=UMCase.ProviderAddressExternalId,
                                            ExternalAddressType=UMCase.ProviderAddressExternalAddressType,
                                            Street=UMCase.ProviderAddressStreet,
                                            City=UMCase.ProviderAddressCity,
                                            State=UMCase.ProviderAddressState,
                                            Zip=UMCase.ProviderAddressZip,
                                            
                                            //EffectiveDate=oDate,
                                            IsPrimary =UMCase.ProviderIsPrimary
                                        },
                                    },
                                },

                               ServiceType = new SystemSpecificValueOption()
                               {
                                   Description=UMCase.ServiceTypeDescription,
                                   Id=UMCase.ServiceTypeId
                               },
                               TreatingProvider = new Provider()
                               {
                                   ExternalId=UMCase.TreatingProviderExternalId,
                                   Name=UMCase.TreatingProviderName,
                                   AddressList=new ProviderAddress[]
                                   {
                                       new ProviderAddress()
                                       {
                                           ExternalId=UMCase.ProviderAddressExternalId,
                                           ExternalAddressType=UMCase.ProviderAddressExternalAddressType,
                                           Street=UMCase.ProviderAddressStreet,
                                           City=UMCase.ProviderAddressCity,
                                           State=UMCase.ProviderAddressState,
                                           Zip=UMCase.ProviderAddressZip,
                                           EffectiveDate=DateTime.Now
                                       },
                                   },
                               },
                            },
                        },
                },
            };
            return request;
        }
    }
}
