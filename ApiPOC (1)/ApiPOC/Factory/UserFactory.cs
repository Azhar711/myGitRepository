using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPOC.Factory
{
    public class UserFactory
    {
        public static IUserContext CreateUserContextInstance(string contextType)
        {
            IUserContext userContext = null;
            switch (contextType)
            {
                case "XML":
                    userContext = new XmlUserContext();
                    break;
                case "DB":
                    userContext = new DbUserContext();
                    break;
                default:
                    throw new Exception("Unknown context type!");
            }
            return userContext;
        }
    }
}