using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using UsingSOAP;

namespace UsingSOAP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creating object of program class to access methods  
            //Program obj = new Program();
            //Console.WriteLine("Please Enter Input values..");
            //Reading input values from console  
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Calling InvokeService method  
            InvokeService();
        }
        public static void InvokeService()
        {

            //Calling CreateSOAPWebRequest method  
            HttpWebRequest request = CreateSOAPWebRequest();


            System.Xml.Linq.XElement SOAPReqBody = XElement.Load(@"C:\WebService\CreateCase_Oct10Updatednow.xml");
            Console.WriteLine(SOAPReqBody);
            XmlDocument SOAPReqBody1 = new XmlDocument();
            //SOAP Body Request  
            SOAPReqBody1.LoadXml(@"<?xml version=""1.0"" encoding=""utf - 8"" ?>  
            < soapenv:Envelope xmlns:i=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:umc=""http://trizetto.com/CareAdvance/UMCaseService/"" xmlns:dat=""http://trizetto.com/CareAdvance/DataContracts"" xmlns:mem=""http://trizetto.com/CareAdvance/DataContracts/Member"" xmlns:umc1=""http://trizetto.com/CareAdvance/DataContracts/UMCase"" xmlns:sys=""http://trizetto.com/CareAdvance/DataContracts/SystemSpecificValue"" xmlns:que=""http://trizetto.com/CareAdvance/DataContracts/Queue"" xmlns:user=""http://trizetto.com/CareAdvance/DataContracts/User"" xmlns:cus=""http://trizetto.com/CareAdvance/DataContracts/CustomFields"" xmlns:prov=""http://trizetto.com/CareAdvance/DataContracts/Provider"" xmlns:arr=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"">
                < soapenv:Header/>
                  <soapenv:Body>
                        <umc:CreateCase>
                            <!--Optional:-->
                            <umc:request>
                            <!--Optional:-->
                            <dat:SessionId>0500003002C7009A1-DAE2-4A20-AFA8-5C0102865A4E091</dat:SessionId>
                            <!--Optional:-->
                            <umc:ExternalMember>
                                <!--Optional:-->
                                <mem:ExternalMemberId>140651</mem:ExternalMemberId>
                                <!--Optional:-->
                                <mem:ExternalSystemId>2</mem:ExternalSystemId>
                            </umc:ExternalMember>
                            <!--Optional:-->
                            <umc:ProcessingOptions i:nil=""true""/>
                            < !--Optional:-->
                            < umc:ShouldReturnBrsActions > true </ umc:ShouldReturnBrsActions >
                            < !--Optional:-->
                            < umc:UmCase >
                         < !--Optional:-->
                            < umc1:AccidentDateTime i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:AccidentGeographicState i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:AccidentIndicator i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:AssignedToQueue i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:AssignedToUser i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:AuthStatusSummary i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:CareType >
                                        < !--Optional:-->
                                        < sys:Description > Elective </ sys:Description >
                                        < !--Optional:-->
                                        < sys:Id > 1 </ sys:Id >
                            </ umc1:CareType >
                            < !--Optional:-->
                            < umc1:CasePriority >
                                        < !--Optional:-->
                                        < sys:Description > Medium </ sys:Description >
                                        < !--Optional:-->
                                        < sys:Id > 3 </ sys:Id >
                            </ umc1:CasePriority >
                            < !--Optional:-->
                            < umc1:CaseSetting >
                                        < !--Optional:-->
                                        < sys:Description > Outpatient </ sys:Description >
                                        < !--Optional:-->
                                        < sys:Id > 2 </ sys:Id >
                            </ umc1:CaseSetting >
                            < !--Optional:-->
                            < umc1:CaseStatus  i: nil = ""true""/>
                            < !--Optional:-->
                            < umc1:CaseType >
                                        < !--Optional:-->
                                        < sys:Description > Medical / Surgical </ sys:Description >
                                        < !--Optional:-->
                                        < sys:Id > 1 </ sys:Id >
                            </ umc1:CaseType >
                            < !--Optional:-->
                            < umc1:ContactName > FAX </ umc1:ContactName >
                            < !--Optional:-->
                            < umc1:ContactPhone > 8888881212 </ umc1:ContactPhone >
                            < !--Optional:-->
                            < umc1:CustomFields >
                                        < !--Optional:-->
                                        < cus:MetaDataGuid i: nil = ""true""/>
                                        < !--Optional:-->
                                        < cus:UserField1  i: nil = ""true"" />
                                        < !--Optional:-->
                                        < cus:UserField2 i: nil = ""true"" />
                                        < !--Optional:-->
                                        < cus:UserField3 i: nil = ""true"" />
                                        < !--Optional:-->
                                        < cus:UserField4 i: nil = ""true""/>
                                        < !--Optional:-->
                                        < cus:UserField5 i: nil = ""true"" />
                                        < !--Optional:-->
                                        < cus:UserField6 i: nil = ""true"" />
                                        < !--Optional:-->
                                        < cus:UserField7 i: nil = ""true"" />
                                        < !--Optional:-->
                                        < cus:UserField8 i: nil = ""true"" />
                                        < !--Optional:-->
                                        < cus:UserField9 i: nil = ""true"" />
                                        < !--Optional:-->
                                        < cus:UserField10 i: nil = ""true"" />
                            </ umc1:CustomFields >
                            < !--Optional:-->
                            < umc1:DelegateSystem i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:DsmIV i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:ExternalId i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:GlobalCaseIndicator i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:HasCommunications i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:IsUrgent > false </ umc1:IsUrgent >
                            < !--Optional:-->
                            < umc1:LastUpdateDate i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:Los i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:Notes i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:OnsetDate i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:PatientRisk i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:Phase i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:PlaceOfService >
                                        < !--Optional:-->
                                        < sys:Description > Custodial Care Facility </ sys:Description >
                                        < !--Optional:-->
                                        < sys:Id > 33 </ sys:Id >
                            </ umc1:PlaceOfService >
                            < !--Optional:-->
                            < umc1:PrimaryCarePhysician i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:RegulatoryDueDate i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:RequestDate > 2017 - 10 - 09T10: 06:40.646Z </ umc1:RequestDate >
                            < !--Optional:-->
                            < umc1:Requester >
                                        < !--Optional:-->
                                        < umc1:CodeSystem i: nil = ""true"" />
                                        < !--Optional:-->
                                        < umc1:Id > 300343434 </ umc1:Id >
                                        < !--Optional:-->
                                        < umc1:Name > Terry Biggs </ umc1:Name >
                                        < !--Optional:-->
                                        < umc1:Phone > 8888881212 </ umc1:Phone >
                                        < !--Optional:-->
                            < umc1:Type >
                                < !--Optional:-->
                                < sys:Description > Web Physician Submission </ sys:Description >
                                < !--Optional:-->
                                < sys:Id > 1 </ sys:Id >
                            </ umc1:Type >
                            </ umc1:Requester >
                            < !--Optional:-->
                            < umc1:ReviewType >
                                        < !--Optional:-->
                                        < sys:Description > Pre - Authorization </ sys:Description >
                                        < !--Optional:-->
                                        < sys:Id > 2 </ sys:Id >
                            </ umc1:ReviewType >
                            < !--Optional:-->
                            < umc1:SecondaryDiagnoses i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:SecondaryProcedures  i: nil = ""true"" />
                            < !--Optional:-->
                            < umc1:Services >
                            < umc1:Service >
                            < !--Optional:-->
                            < umc1:Certifications >
                                < !--Zero or more repetitions: -->
                                < umc1:Certification >
                                    < !--Optional:-->
                                    < umc1:AuthorizedUnits > 008 </ umc1:AuthorizedUnits >
                                    < !--Optional:-->
                                    < umc1:Coverage i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:CustomFields i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:ExternalId i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:FacilityNotificationLetterTime i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:FacilityNotificationTime i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:FacilityNotificationType  i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:FromDate > 2016 - 11 - 07T12: 00:00 - 04:00 </ umc1:FromDate >
                                    < !--Optional:-->
                                    < umc1:MemberNotificationLetterTime i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:MemberNotificationTime i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:MemberNotificationType i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:Payment i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:ProviderNotificationLetterTime i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:ProviderNotificationTime i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:ProviderNotificationType  i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:RequestedUnits > 50 </ umc1:RequestedUnits >
                                    < !--Optional:-->
                                    < umc1:Status i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:ToDate > 2016 - 11 - 07T12: 00:00 - 04:00 </ umc1:ToDate >
                                </ umc1:Certification >
                    </ umc1:Certifications >
                            < !--Optional:-->
                                    < umc1:CustomFields >
                                                < !--Optional:-->
                                                < cus:MetaDataGuid i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField1  i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField2  i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField3 i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField4 i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField5 i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField6 i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField7 i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField8 i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField9 i: nil = ""true"" />
                                                < !--Optional:-->
                                                < cus:UserField10 i: nil = ""true"" />
                                    </ umc1:CustomFields >
                                    < !--Optional:-->
                                    < umc1:Diagnosis >
                                                < !--Optional:-->
                                                < umc1:Code > 428.1 </ umc1:Code >
                                                < !--Optional:-->
                                                < umc1:CodeSetId > ICD9 </ umc1:CodeSetId >
                                                < !--Optional:-->
                                                < umc1:Description > LEFT HEART FAILURE(ICD9 428.1) </ umc1:Description >
                                                < !--Optional:-->
                                                < umc1:PoaIndicator i: nil = ""true"" />
                                    </ umc1:Diagnosis >
                                    < !--Optional:-->
                                    < umc1:ExternalId i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:Facility i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:HasCommunications i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:IsPrimary > true </ umc1:IsPrimary >
                                    < !--Optional:-->
                                    < umc1:NdcCode i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:NdcDescription i: nil = ""true"" />
                                    < !--Optional:-->
                                    < umc1:Procedure >
                                                < !--Optional:-->
                                                < umc1:Code > 12001 </ umc1:Code >
                                                < !--Optional:-->
                                                < umc1:CodeSetId > CPT </ umc1:CodeSetId >
                                                < !--Optional:-->
                                                < umc1:Description > SMPL RPR SUPFC S / N / AX / G / T 2.5CM /</ umc1:Description >
                                                < !--Optional:-->
                                                < umc1:ProcedureDate i: nil = ""true"" />
                                    </ umc1:Procedure >
                                    < !--Optional:-->
                                    < umc1:RequestingProvider >
                                                < !--Optional:-->
                                                < prov:ExternalId > IHMPRAC00012 </ prov:ExternalId >
                                                < !--Optional:-->
                                                < prov:ExternalAddressType > 001 </ prov:ExternalAddressType >
                                                < !--Optional:-->
                                                < prov:Title i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:Name > Reeves, Anthony </ prov:Name >
                                                < !--Optional:-->
                                                < prov:FirstName i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:LastName i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:NetworkStatus i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:Npi i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:Role i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:TaxId i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:Type  i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:SpecialtyList i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:EffectiveDate i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:TerminationDate i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:MedicareIds i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:AddressList >
                                                    < !--Zero or more repetitions: -->
                                                    < prov:ProviderAddress >
                                                                < !--Optional:-->
                                                                < prov:ExternalId > IHMPRAC00012 </ prov:ExternalId >
                                                                < !--Optional:-->
                                                                < prov:ExternalAddressType > 001 </ prov:ExternalAddressType >
                                                    < !--Optional:-->
                                                                < prov:Street > 1021 CVS Drive </ prov:Street >
                                                                < !--Optional:-->
                                                                < prov:City > Flemington </ prov:City >
                                                                < !--Optional:-->
                                                                < prov:State > NJ </ prov:State >
                                                                < !--Optional:-->
                                                                < prov:Zip > 08822 </ prov:Zip >
                                                                < !--Optional:-->
                                                                < prov:Country i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:County i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:Phone i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:PhoneExtension i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:Fax i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:FaxExtension i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:Email i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:Type i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:EffectiveDate > 2017 - 10 - 09T10: 06:40.646Z </ prov:EffectiveDate >
                                                                < !--Optional:-->
                                                                < prov:TerminationDate i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:CustomFields i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < prov:IsTemporary i: nil = ""true"" />
                                                                < !--Optional:-->
                                                                < umc1:IsPrimary > false </ umc1:IsPrimary >
                                                    </ prov:ProviderAddress >
                                                </ prov:AddressList >
                                                < !--Optional:-->
                                                < prov:CustomFields  i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:NetworkStatusType  i: nil = ""true"" />
                                                < !--Optional:-->
                                                < prov:Affiliations  i: nil = ""true"" />
                                    </ umc1:RequestingProvider >
                                    < !--Optional:-->
                                            < umc1:ServiceType >
                                                        < !--Optional:-->
                                                        < sys:Description > Acupuncture </ sys:Description >
                                                        < !--Optional:-->
                                                        < sys:Id > 33 </ sys:Id >
                                            </ umc1:ServiceType >
                                            < !--Optional:-->
                                            < umc1:TreatingProvider >
                                                        < !--Optional:-->
                                                        < prov:ExternalId > IHMPRAC00012 </ prov:ExternalId >
                                                        < !--Optional:-->
                                                        < prov:ExternalAddressType > 001 </ prov:ExternalAddressType >
                                                        < !--Optional:-->
                                                        < prov:Title i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:Name > Reeves, Anthony </ prov:Name >
                                                        < !--Optional:-->
                                                        < prov:FirstName i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:LastName i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:NetworkStatus i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:Npi i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:Role i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:TaxId i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:Type i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:SpecialtyList i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:EffectiveDate i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:TerminationDate i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:MedicareIds i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:AddressList >
                                                        < !--Zero or more repetitions: -->
                                                        < prov:ProviderAddress >
                                                        < !--Optional:-->
                                                        < prov:ExternalId > IHMPRAC00012 </ prov:ExternalId >
                                                        < !--Optional:-->
                                                        < prov:ExternalAddressType > 001 </ prov:ExternalAddressType >
                                                        < !--Optional:-->
                                                        < prov:Street > 1021 CVS Drive </ prov:Street >
                                                        < !--Optional:-->
                                                        < prov:City > Flemington </ prov:City >
                                                        < !--Optional:-->
                                                        < prov:State > NJ </ prov:State >
                                                        < !--Optional:-->
                                                        < prov:Zip > 08822 </ prov:Zip >
                                                        < !--Optional:-->
                                                        < prov:Country i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:County i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:Phone i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:PhoneExtension i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:Fax i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:FaxExtension i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:Email i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:Type i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:EffectiveDate > 2017 - 10 - 09T10: 06:40.646Z </ prov:EffectiveDate >
                                                        < !--Optional:-->
                                                        < prov:TerminationDate i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:CustomFields i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:IsTemporary i: nil = ""true"" />
                                                        < !--Optional:-->
                                                        < prov:IsPrimary i: nil = ""true"" />
                                                </ prov:ProviderAddress >
                                            </ prov:AddressList >
                                            < !--Optional:-->
                                            < prov:CustomFields i: nil = ""true"" />
                                            < !--Optional:-->
                                            < prov:NetworkStatusType i: nil = ""true"" />
                                            < !--Optional:-->
                                            < prov:Affiliations  i: nil = ""true"" />
                                </ umc1:TreatingProvider >
                                                </ umc1:Service >
                                    </ umc1:Services >
                                    < !--Optional:-->
                                    < umc1:Source  i: nil = ""true"" />


                                    < !--Optional:-->
                                    < umc1:WorkflowRunMode > ActionsAndDecisions </ umc1:WorkflowRunMode >
                                </ umc:UmCase >
                                < !--Optional:-->
                                < umc:ShouldReturnCase i: nil = ""true"" />
                                  </ umc:request >
                                </ umc:CreateCase >
                  </ soapenv:Body >
            </ soapenv:Envelope > ");


            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }
            //Geting response from request  
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    //reading stream  
                    var ServiceResult = rd.ReadToEnd();
                    //writting stream result on console  
                    Console.WriteLine(ServiceResult);
                    Console.ReadLine();
                }
            }
        }

        public static HttpWebRequest CreateSOAPWebRequest()
        {
            //Making Web Request  
           //HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"https://abn-ode-web-c12.ode.trizetto.com/SOAFServices/UMCaseService/UMCase.svc");
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"https://abn-ode-web-c12.ode.trizetto.com/SOAFServices/UMCaseService/UMCase.svc?wsdl");
            //SOAPAction  
            //Req.Headers.Add(@"SOAPAction:http://tempuri.org/Addition");
            //Content_type  
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            //HTTP method  
            Req.Method = "POST";
            //return HttpWebRequest  
            return Req;
        }
    }
}