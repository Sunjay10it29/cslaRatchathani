using System;
using System.Collections.Generic;
using System.Text;

namespace KPSL.Collacteral.Shared
{
  public class UserIdentity
  {
    public string Name { get; set; }
    public string AuthenticationType { get; set; }
    public bool IsAuthenticated { get; set; }
    public List<ClaimInfo> Claims { get; set; } = new List<ClaimInfo>();

  }

  public class ClaimInfo
  {
    public string ClaimType { get; set; }
    public string Claim { get; set; }
  }

}
