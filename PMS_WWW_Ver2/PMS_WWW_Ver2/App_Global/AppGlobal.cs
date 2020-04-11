using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PMS_WWW_Ver2.App_Global
{
    public static partial class AppGlobal
    {
        public static string ProductCode = "GPRO_PMS_WWW";

        public static string GetPMSUrl
        {
            get { return ConfigurationManager.AppSettings["HostUrl"]; }
        }
    }
}