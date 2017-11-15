using CreateCase.UMService;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebService.Base.CAEUMCase;
using WebService.Base.Helpers;
using WebServiceTest.cs.SpecflowCommon;
using WebServiceTest.cs.Stepdescriptions;

namespace WebServiceTest.cs.Stepdefinitions
{
    [Binding]
    public class UMCaseCreation
    {
        public WebserviceHelpers WsHelp;
        public UMCaseCreationDescriptions _UMCaseDesc;
        public static WebService.Base.CAEUMCase.CreateCaseSvcRequest _request;
        public static WebService.Base.CAEUMCase.CreateCaseSvcResponse _response;

        public UMCaseCreation()
        {
             WsHelp = new WebserviceHelpers();
            _UMCaseDesc = new UMCaseCreationDescriptions();
        }

        [Given(@"I set up and Create Case Instance for (.*) WebService")]
        public void GivenISetUpAndCreateCaseInstanceForWebService(string servicename)
        {
            _UMCaseDesc.CreateUMCaseInstance(servicename);
            //WsHelp.createInstance(servicename);
        }

        [When(@"I fill in all the below resources")]
        public void WhenIFillAllTheBelowResources(Table table)
        {
            var Resources = table.CreateInstance<ResourceProperties>();
           _request = _UMCaseDesc.InvokeCreateUMCaseResource(Resources);
        }

        [When(@"I verify that UM Case Id is created through response")]
        public void WhenIVerifyThatUMCaseIdIsCreatedThroughResponse()
        {
            _response = WebserviceHelpers._Service.CreateCase(_request);
            Console.WriteLine("UM Request ID " + _response.ExternalCaseId);
            Console.WriteLine("UM Request Response " + _response.ReturnMessage);
            Assert.That(_response.ReturnMessage.ToLower().Contains("success"), "Webservice response may not be successful");
            Console.WriteLine("UM Request Response Status " + _response.Success);
            Assert.That(_response.Success.Equals(true), "Unsuccessful Response");
        }




    }


}
