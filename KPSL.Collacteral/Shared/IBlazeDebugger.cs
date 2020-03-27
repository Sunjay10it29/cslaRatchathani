using System.Threading.Tasks;

namespace KPSL.Collacteral.Shared
{
    public interface IBlazeDebugger
    {
        Task ConsoleLog(string title, object data, LogLevel level = LogLevel.Info);
    }
}