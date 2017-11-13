using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
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
        public UMCaseCreationDescriotions _UMCaseDesc;

        public UMCaseCreation()
        {
           // WsHelp = new WebserviceHelpers();
            _UMCaseDesc = new UMCaseCreationDescriotions();
        }

        [Given(@"I set up and Create Case Instance for (.*) WebService")]
        public void GivenISetUpAndCreateCaseInstanceForWebService(string servicename)
        {
            _UMCaseDesc.CreateUMCase(servicename);
            //WsHelp.createInstance(servicename);
        }
    }

    
}
