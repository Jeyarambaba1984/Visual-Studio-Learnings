﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NUnit.Framework;
using WebService.Base.CAEUMCase;
using System.Net;

namespace WebService.Base.Helpers
{

    public class WebserviceHelpers
    {
        public static string _binding { get; set; }
        public static string _username { get; set; }
        public static string _password{ get; set; }
        public static UMCase1Client _Service = null;



        public WebserviceHelpers()
        {
            Console.WriteLine("INto Webservicehelpers constructor");
            //UMCase1Client Service = new UMCase1Client(_binding);
           Getappconfigvalues();
        }



        public void createInstance(string ResourceType)
        {
            Console.WriteLine("In Create Instance Method");
            _Service = new UMCase1Client("BasicHttpBinding_UMCase");
            //BasicHttpBinding_UMCase
            _Service.ClientCredentials.UserName.UserName = _username;
            _Service.ClientCredentials.UserName.Password = _password;
        }

        private static void Getappconfigvalues()
        {
            Console.WriteLine("Getting value from property file");
            _username = ConfigurationManager.AppSettings["caeusername"];
            _password = ConfigurationManager.AppSettings["caeuserpassword"];
            _binding = ConfigurationManager.AppSettings["binding"];
        }

        
        //public string ICDCodesettings(string Diagcodesettype)
        //{
        //    if (Diagcodesettype.ToLower().Contains("icd9"))
        //    {

        //    }
        //    else if (Diagcodesettype.ToLower().Contains("icd10"))
        //    {

        //    }
        //    return null;
        //}
        public void IgnoreSSLWarnings()
        {
            ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
        }
    }
}

