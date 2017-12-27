using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ApiPOC.Library
{
    public class XmlUser
    {
        private XmlUser()
        {

        }

        public string UserName { get; set; }
        public string Password { get; set; }

        public static List<XmlUser> GetAllUsers()
        {
            var users = new List<XmlUser>();
            XDocument doc = XDocument.Load(MyConfigReader.UsersXmlPath);
            var userElements = doc.Descendants("User");
            foreach (var item in userElements)
            {
                var user = new XmlUser()
                {
                    UserName = item.Element("UserName").Value,
                    Password = item.Element("Password").Value
                };
                users.Add(user);
            }
            return users;
        }

        public static XmlUser GetUser(string userName, string password)
        {
            var users = GetAllUsers();
            return users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }
    }
}