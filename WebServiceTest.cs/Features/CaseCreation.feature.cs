﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WebServiceTest.cs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateCase through WebService")]
    [NUnit.Framework.CategoryAttribute("Webservice")]
    public partial class CreateCaseThroughWebServiceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CaseCreation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateCase through WebService", null, ProgrammingLanguage.CSharp, new string[] {
                        "Webservice"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Case - Outpatient - Hospital Claim")]
        [NUnit.Framework.CategoryAttribute("Webservice")]
        public virtual void CreateCase_Outpatient_HospitalClaim()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Case - Outpatient - Hospital Claim", new string[] {
                        "Webservice"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I set up and Create Case Instance for UMcase WebService", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ResourceType",
                        "ResourceValue"});
            table1.AddRow(new string[] {
                        "ExternalMemberId",
                        "140651"});
            table1.AddRow(new string[] {
                        "ExternalSystemId",
                        "2"});
            table1.AddRow(new string[] {
                        "ShouldReturnBrsActions",
                        "true"});
            table1.AddRow(new string[] {
                        "CareTypeDescription",
                        "Elective"});
            table1.AddRow(new string[] {
                        "CareId",
                        "1"});
            table1.AddRow(new string[] {
                        "CasePriorityDescription",
                        "Medium"});
            table1.AddRow(new string[] {
                        "CasePriorityId",
                        "3"});
            table1.AddRow(new string[] {
                        "CaseSettingDescription",
                        "Outpatient"});
            table1.AddRow(new string[] {
                        "CaseSettingId",
                        "2"});
            table1.AddRow(new string[] {
                        "CaseTypeId",
                        "1"});
            table1.AddRow(new string[] {
                        "CaseTypeDescription",
                        "Medical/Surgical"});
            table1.AddRow(new string[] {
                        "IsUrgent",
                        "false"});
            table1.AddRow(new string[] {
                        "PlaceOfServiceId",
                        "33"});
            table1.AddRow(new string[] {
                        "PlaceOfServiceDescription",
                        "Custodial Care Facility"});
            table1.AddRow(new string[] {
                        "RequesterId",
                        "300343434"});
            table1.AddRow(new string[] {
                        "RequesterName",
                        "Terry Biggs"});
            table1.AddRow(new string[] {
                        "RequesterPhone",
                        "8888881212"});
            table1.AddRow(new string[] {
                        "RequesterTypeId",
                        "1"});
            table1.AddRow(new string[] {
                        "RequesterTypeDescription",
                        "Web Physician Submission"});
            table1.AddRow(new string[] {
                        "ReviewTypeId",
                        "2"});
            table1.AddRow(new string[] {
                        "ReviewTypeDescription",
                        "Pre-Authorization"});
            table1.AddRow(new string[] {
                        "AuthorizationUnits",
                        "008"});
            table1.AddRow(new string[] {
                        "RequestedUnits",
                        "50"});
            table1.AddRow(new string[] {
                        "DiagnosisCode",
                        "428.1"});
            table1.AddRow(new string[] {
                        "DiagnosisId",
                        "DiagnosisCodeSet"});
            table1.AddRow(new string[] {
                        "DiagnosissetID",
                        "ICD9,ICD10"});
            table1.AddRow(new string[] {
                        "DiagnosisDescription",
                        "LEFT HEART FAILURE(ICD9 428.1)"});
            table1.AddRow(new string[] {
                        "IsPrimary",
                        "true"});
            table1.AddRow(new string[] {
                        "ProcedureCode",
                        "12001"});
            table1.AddRow(new string[] {
                        "ProcedureCodeSetId",
                        "ProcedureCodeSet.CPT"});
            table1.AddRow(new string[] {
                        "ProcedureDescription",
                        "SMPL RPR SUPFC S/N/AX/G/T 2.5CM/"});
            table1.AddRow(new string[] {
                        "RequestingProviderExternalId",
                        "IHMPRAC00012"});
            table1.AddRow(new string[] {
                        "RequestingProviderName",
                        "Reeves, Anthony"});
            table1.AddRow(new string[] {
                        "ProviderAddressExternalId",
                        "IHMPRAC00012"});
            table1.AddRow(new string[] {
                        "ProviderAddressExternalAddressType",
                        "001"});
            table1.AddRow(new string[] {
                        "ProviderAddressStreet",
                        "1021 CVS Drive"});
            table1.AddRow(new string[] {
                        "ProviderAddressCity",
                        "Flemington"});
            table1.AddRow(new string[] {
                        "ProviderAddressState",
                        "NJ"});
            table1.AddRow(new string[] {
                        "ProviderAddressZip",
                        "08822"});
            table1.AddRow(new string[] {
                        "ProviderIsPrimary",
                        "false"});
            table1.AddRow(new string[] {
                        "ServiceTypeId",
                        "33"});
            table1.AddRow(new string[] {
                        "ServiceTypeDescription",
                        "Acupuncture"});
            table1.AddRow(new string[] {
                        "TreatingProviderExternalId",
                        "IHMPRAC00012"});
            table1.AddRow(new string[] {
                        "TreatingProviderName",
                        "Reeves, Anthony"});
            table1.AddRow(new string[] {
                        "ProviderAddressExternalId",
                        "IHMPRAC00012"});
            table1.AddRow(new string[] {
                        "ProviderAddressExternalAddressType",
                        "001"});
            table1.AddRow(new string[] {
                        "ProviderAddressStreet",
                        "1021 CVS Drive"});
            table1.AddRow(new string[] {
                        "ProviderAddressCity",
                        "Flemington"});
            table1.AddRow(new string[] {
                        "ProviderAddressState",
                        "NJ"});
            table1.AddRow(new string[] {
                        "ProviderAddressZip",
                        "08822"});
#line 10
 testRunner.When("I fill in all the below resources", ((string)(null)), table1, "When ");
#line 62
 testRunner.And("I verify that UM Case Id is created through response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
