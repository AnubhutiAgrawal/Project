using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPark.PizzaHub.UserAuthentication.Authentication.BusinessLayer;
using PizzaPark.PizzaHub.UserAuthentication.Authentication.Model;

namespace PizzaPark.Controllers
{
    [Produces("application/json")]
    [Route("api/UserAuthentication")]
    public class UserAuthenticationController : Controller
    {

        [Route("login")]
        [HttpPost]
        public Boolean Login([FromBody]AuthenticationRequest request)
        {
            CreateUser obj = new CreateUser();
            return obj.CheckUser(request.UserName, request.Password);
            //Call to Business logic 


        
        }
        [Route("DisplayList")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

     



        [Route("logout")]
        [HttpGet] 
      

        public void Logout() 
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("Password");
            HttpContext.Response.StatusCode = 200;
            return;

        }

    }
}
