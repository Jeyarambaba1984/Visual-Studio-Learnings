using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateCase.UMService;
using System.Globalization;
using System.Net;

namespace CreateCase
{
    public class Program
    {
        
        public static void DatetimeConverter()
        {

            //2016-11-07T12:00:00-04:00
            TimeZone zone = TimeZone.CurrentTimeZone;
            // Get offset.
            TimeSpan offset = zone.GetUtcOffset(DateTime.Now.AddDays(-200));
            Console.WriteLine(offset);
            DateTime now = DateTime.Now.AddDays(-200);
            Console.WriteLine(now);
            DateTime dt = DateTime.ParseExact(now.ToString(), "yyyy-MM-dd h:mm tt", CultureInfo.InvariantCulture);

            Console.WriteLine(now.Year + "-" + now.Month + "-" + now.Day + "T" + now.Hour + ":" + now.Minute + ":" + now.Second + "-" + offset.Hours + ":" + offset.Minutes);

        }
        static void Main(string[] args)
        {
            //DatetimeConverter();

            try
            {
                Console.WriteLine("Before HTTP Bindings");
                UMCase1Client service = new UMCase1Client("BasicHttpBinding_UMCase");
                service.ClientCredentials.UserName.UserName = "JeyaramB";
                service.ClientCredentials.UserName.Password = "Sadhguru@123";
                Console.WriteLine("After Credentials");
                ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
                var request = new CreateCaseSvcRequest()
                {
                    SessionId = string.Empty,

                    ExternalMember = new ExternalMember()
                    {
                        ExternalMemberId = "140651",
                        ExternalSystemId = 2
                        
                    },

                    ShouldReturnBrsActions = true,


                    UmCase = new UmCase()
                    {
                        WorkflowRunMode = WorkflowRunMode.ActionsAndDecisions,

                        CareType = new SystemSpecificValueOption()
                        {
                            Description = "Elective",
                            Id = 1
                        },
                        CasePriority = new SystemSpecificValueOption()
                        {
                            Description = "Medium",
                            Id = 3
                        },
                        CaseSetting = new SystemSpecificValueOption()
                        {
                            Id = 2,
                            Description = "Outpatient"
                        },
                        CaseType = new SystemSpecificValueOption()
                        {
                            Id = 1,
                            Description = "Medical/Surgical"
                        },
                        IsUrgent = false,

                        PlaceOfService = new SystemSpecificValueOption()
                        {
                            Id = 33,
                            Description = "Custodial Care Facility"
                        },
                        RequestDate = DateTime.Now,
                        Requester = new Requester()
                        {
                            Id = "300343434",
                            Name = "Terry Biggs",
                            Phone = "8888881212",
                            Type = new SystemSpecificValueOption()
                            {
                                Id = 1,
                                Description = "Web Physician Submission"
                            }
                        },
                        ReviewType = new SystemSpecificValueOption()
                        {
                            Id = 2,
                            Description = "Pre-Authorization"
                        },
                        Services = new Service[1]
                        {
                            new Service()
                            {
                                Certifications = new Certification[1]
                                {
                                    new Certification()
                                    {
                                        AuthorizedUnits=008,
                                        FromDate=DateTime.Now,
                                        RequestedUnits=50,
                                        ToDate=DateTime.Now,
                                    },
                                },
                                Diagnosis = new Diagnosis()
                                {
                                    Code="428.1",
                                    CodeSetId=DiagnosisCodeSet.ICD9,
                                    Description="LEFT HEART FAILURE(ICD9 428.1)"
                                },

                                IsPrimary=true,

                                Procedure = new Procedure()
                                {
                                    Code="12001",
                                    CodeSetId=ProcedureCodeSet.CPT,
                                    Description="SMPL RPR SUPFC S/N/AX/G/T 2.5CM/",
                                },
                                RequestingProvider = new Provider()
                                {
                                    ExternalId="IHMPRAC00012",
                                    Name="Reeves, Anthony",
                                    AddressList=new ProviderAddress[]
                                    {
                                        new ProviderAddress()
                                        {
                                            ExternalId="IHMPRAC00012",
                                            ExternalAddressType="001",
                                            Street="1021 CVS Drive",
                                            City="Flemington",
                                            State="NJ",
                                            Zip="08822",
                                            
                                            //EffectiveDate=oDate,
                                            IsPrimary =false
                                        },
                                    },
                                },

                               ServiceType = new SystemSpecificValueOption()
                               {
                                   Description="Acupuncture",
                                   Id=33
                               },
                               TreatingProvider = new Provider()
                               {
                                   ExternalId="IHMPRAC00012",
                                   Name="Reeves, Anthony",
                                   AddressList=new ProviderAddress[]
                                   {
                                       new ProviderAddress()
                                       {
                                           ExternalId="IHMPRAC00012",
                                           ExternalAddressType="001",
                                           Street="1021 CVS Drive",
                                           City="Flemington",
                                           State="NJ",
                                           Zip="08822",
                                           EffectiveDate=DateTime.Now
                                       },
                                   },
                               },
                            },
                        },
                    },
                };
                Console.WriteLine("After data");
                var response = service.CreateCase(request);
                Console.WriteLine("UM Request ID "+ response.ExternalCaseId);
                Console.WriteLine("UM Request Response " + response.ReturnMessage);
                Console.WriteLine("UM Request Response Status " + response.Success);
            }
            catch (Exception ex)
            {
                
            }
            Console.ReadLine();
        }    
    }
}
