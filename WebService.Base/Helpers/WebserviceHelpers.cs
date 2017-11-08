using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace WebService.Base.Helpers
{
    class WebserviceHelpers
    {
        public void Getappconfig()
        {   
            string userName = ConfigurationManager.AppSettings["restartfacetspartnershipusername"];

        }
    }
}
