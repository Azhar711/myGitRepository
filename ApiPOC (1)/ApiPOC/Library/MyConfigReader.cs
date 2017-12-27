using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ApiPOC.Library
{
    public static class MyConfigReader
    {
        public static string UsersXmlPath
        {
            get
            {
                return ConfigurationManager.AppSettings["UsersXmlPath"];
            }
        }
    }
}