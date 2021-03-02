using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Interfaces
{
    public interface IAuthenticationServices
    {
        string GenerateJSONWebToken(User userInfo);

        User AuthenticateUser(Login login);
    }
}
