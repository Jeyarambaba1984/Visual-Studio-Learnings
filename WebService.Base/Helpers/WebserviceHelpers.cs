using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NUnit.Framework;

namespace WebService.Base.Helpers
{
    public class WebserviceHelpers
    {
        public static void Getappconfig()
        {   
            string _userName = ConfigurationManager.AppSettings["caeusername"];
            string _password = ConfigurationManager.AppSettings["caeuserpassword"];
            string _Binding = ConfigurationManager.AppSettings["binding"];
            //string _password = ConfigurationManager.AppSettings["caeuserpassword"];
        }
    }
}


