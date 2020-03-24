using System;
using Csla;

namespace KPSL.Collacteral.Shared
{
  [Serializable]
  public class CustomIdentity : Csla.Security.CslaIdentityBase<CustomIdentity>
  {
    [Fetch]
    private void Fetch(UserCredentials credentials)
    {
      // validate credentials here
      if (!string.IsNullOrWhiteSpace(credentials.Username) && !string.IsNullOrWhiteSpace(credentials.Password) )
      {
        Name = credentials.Username;
        IsAuthenticated = true;
        AuthenticationType = "Password";
        Roles = new Csla.Core.MobileList<string>
        {
          
        };
        Roles.Add("admin");
        Roles.Add("supervisor");
        Roles.Add("manager");
      }
      else
      {
        Name = string.Empty;
        IsAuthenticated = false;
        AuthenticationType = string.Empty;
        Roles = new Csla.Core.MobileList<string>();
      }
    }
  }
}
