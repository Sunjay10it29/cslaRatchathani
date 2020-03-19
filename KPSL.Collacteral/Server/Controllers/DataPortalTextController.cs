using Microsoft.AspNetCore.Mvc;
using Csla.Server.Hosts;
using System.Threading.Tasks;
using Csla.Core;
using Csla.Rules;
namespace KPSL.Collacteral.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DataPortalTextController : HttpPortalController
  {
    public DataPortalTextController()
    {
      UseTextSerialization = true;
    }

    [HttpPost]
    public override Task PostAsync([FromQuery] string operation)
    {
      return base.PostAsync(operation);
    }
  }
}