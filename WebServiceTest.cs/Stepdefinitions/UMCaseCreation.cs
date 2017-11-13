using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WebService.Base.Helpers;

namespace WebServiceTest.cs.Stepdefinitions
{
    [Binding]
    public class UMCaseCreation
    {

        [Given(@"I set up and Create Case Instance for WebService")]
        public static void GivenISetUpAndCreateCaseInstanceForWebService()
        {
            WebserviceHelpers.Getappconfig();
        }
    }

    
}
