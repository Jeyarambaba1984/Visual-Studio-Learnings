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
    public class UMCaseCreationDescriotions
    {
        public static WebserviceHelpers _help;
        public UMCaseCreationDescriotions()
        {
            _help = new WebserviceHelpers();
        }
        public void CreateUMCase(string ServiceType)
        {
            _help.createInstance(ServiceType);
            _help.IgnoreSSLWarnings();
        }
    }
}
