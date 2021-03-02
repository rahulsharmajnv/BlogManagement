using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using WebApplication3.Interfaces;
using WebApplication3.Model;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private IConfiguration _config;

        private IAuthenticationServices _authenticationServices;


        public LoginController(IConfiguration config, IAuthenticationServices authenticationServices)
        {
            _config = config;
            _authenticationServices = authenticationServices;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody]Login login)
        {
            IActionResult response = Unauthorized();
            var user = _authenticationServices.AuthenticateUser(login);

            if (user != null)
            {
                var tokenString = _authenticationServices.GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

    }
}