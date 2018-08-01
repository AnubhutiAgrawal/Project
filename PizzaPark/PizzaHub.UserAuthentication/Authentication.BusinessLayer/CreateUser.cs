using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaPark.PizzaHub.UserAuthentication.Authentication.Model;

namespace PizzaPark.PizzaHub.UserAuthentication.Authentication.BusinessLayer
{
    public class CreateUser
    {

        List<AuthenticationDomain> user;
        public CreateUser()
        {
            user = new List<AuthenticationDomain>();
            user.Add(new AuthenticationDomain { Email = "Abc", Password = "abc" });
            user.Add(new AuthenticationDomain { Email = "bcd", Password = "bcd" });
            user.Add(new AuthenticationDomain { Email = "Anu", Password = "Anu" });
            user.Add(new AuthenticationDomain { Email = "akku", Password = "akku:" });
        }


        public bool CheckUser(string username, string password)
        {
            var account = user.FirstOrDefault(e => e.Email.Equals(username));
          //  var acc = user.Count(e => e.Password.StartsWith("a"));
          
            if(account!=null)
            {
                return account.Password.Equals(password);
            }
            return false;
        }
        public void DisplayUser()
        {
           
        }
    }

}
