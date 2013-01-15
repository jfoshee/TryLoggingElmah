using System.Reflection;
using ServiceStack.WebHost.Endpoints;
using ServiceStack.Logging;

namespace TryLoggingElmah
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Testing Web Services", Assembly.GetExecutingAssembly())
        {
        }
        
        public override void Configure(Funq.Container container)
        {
            var baseLogFactory = new ServiceStack.Logging.NLogger.NLogFactory();
            LogManager.LogFactory = new ServiceStack.Logging.Elmah.ElmahLogFactory(baseLogFactory);
        }
    }
}
