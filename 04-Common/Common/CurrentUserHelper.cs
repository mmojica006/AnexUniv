using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.Security;

namespace Common
{
    public class CurrentUser
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }

        public  List<string> Roles { get; set; }


        public CurrentUser()
        {
            Roles = new List<string>();
        }
        public bool IsAdmin()
        {
            return Roles.Contains(RolesNames.Admin);
        }

        public bool IsStudent()
        {
            return Roles.Contains(RolesNames.Admin);
        }

        public bool IsTeacher()
        {
            return Roles.Contains(RolesNames.Admin);
        }

        public bool IsUser()
        {
            return Roles.Contains(RolesNames.Admin);
        }




    }

    public class CurrentUserHelper
    {
        public static CurrentUser Get
        {
            get
            {
                var user = HttpContext.Current.User;

                if (user == null)
                {
                    return null;
                }
                else if (string.IsNullOrEmpty(user.Identity.GetUserId()))
                {
                    return null;
                }

                var jUser = ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.UserData).Value;

                return JsonConvert.DeserializeObject<CurrentUser>(jUser);
            }
        }
    }
}
