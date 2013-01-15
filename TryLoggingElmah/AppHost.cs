using System.Reflection;
using ServiceStack.WebHost.Endpoints;

namespace TryLoggingElmah
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Testing Web Services", Assembly.GetExecutingAssembly())
        {
        }
        
        public override void Configure(Funq.Container container)
        {
        }
    }
}

