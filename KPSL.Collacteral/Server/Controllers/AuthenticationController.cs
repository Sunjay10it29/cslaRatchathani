using KPSL.Collacteral.Shared;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace KPSL.Collacteral.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController
    {
        private static Dictionary<string, string> Users = new Dictionary<string, string>
        {
            { "manager", "1234" },
            { "supervisor", "abcd" },
            { "admin", "sunny" }
        };

        [HttpPost]
        public UserIdentity Post(UserCredentials credentials)
        {
            var result = new UserIdentity();
            if (!string.IsNullOrWhiteSpace(credentials.Username) &&
                Users.TryGetValue(credentials.Username.ToLower(), out string pw))
            {
                if ((!string.IsNullOrWhiteSpace(pw) && pw == credentials.Password))
                {
                    result.IsAuthenticated = true;
                    result.AuthenticationType = "password";
                    result.Name = credentials.Username.ToLower();
                    result.Claims.Add(new ClaimInfo
                    { ClaimType = ClaimTypes.Role, Claim = credentials.Username.ToLower() });
                }
            }
            else
            {
                result.IsAuthenticated = false;
            }
            return result;
        }
    }
}
