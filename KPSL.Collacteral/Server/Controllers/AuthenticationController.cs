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
      { "rocky", "1234" },
      { "user", "abcd" },
      { "admin", "sunny" }
    };

    [HttpPost]
    public UserIdentity Post(UserCredentials credentials)
    {
      var result = new UserIdentity();
      if (!string.IsNullOrWhiteSpace(credentials.Username) && 
          Users.TryGetValue(credentials.Username.ToLower(), out string pw) &&
          pw == credentials.Password)
      {
        result.IsAuthenticated = true;
        result.AuthenticationType = "password";
        result.Name = credentials.Username.ToLower();
        result.Claims.Add(new ClaimInfo 
          { ClaimType = ClaimTypes.Role, Claim = credentials.Username.ToLower() });
      }
      return result;
    }
  }
}
