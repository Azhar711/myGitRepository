using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;

namespace ApiPOC.Factory
{
    public class DbUserContext : IUserContext
    {
        public async Task<IdentityUser> GetUser(string userName, string password)
        {
            using (AuthRepository _repo = new AuthRepository())
            {
                return await _repo.FindUser(userName, password);
            }
        }
    }
}