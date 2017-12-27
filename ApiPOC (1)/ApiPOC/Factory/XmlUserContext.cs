using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using ApiPOC.Library;

namespace ApiPOC.Factory
{
    public class XmlUserContext : IUserContext
    {
        public async Task<IdentityUser> GetUser(string userName, string password)
        {
            return await Task.Run(() =>
            {
                IdentityUser user = null;
                var xmlUser = XmlUser.GetUser(userName, password);
                if(xmlUser != null)
                {
                    user = new IdentityUser();
                    user.UserName = userName;
                }
                return user;
            });
        }
    }
}