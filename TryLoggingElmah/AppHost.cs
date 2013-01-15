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
//            LogManager.LogFactory = new ServiceStack.Logging.Support.Logging.ConsoleLogFactory();
//            LogManager.LogFactory = new ServiceStack.Logging.Log4Net.Log4NetFactory("log4net.config");
            var log4NetFactory = new ServiceStack.Logging.Log4Net.Log4NetFactory("log4net.config");
            LogManager.LogFactory = new ServiceStack.Logging.Elmah.ElmahLogFactory(log4NetFactory);
//            LogManager.LogFactory = new ServiceStack.Logging.NLogger.NLogFactory();
            container.Register<ILog>(LogManager.GetLogger(typeof(AppHost)));
        }
    }
}
