using System;

namespace TryLoggingElmah
{
    public class Global : System.Web.HttpApplication
    {
        protected virtual void Application_Start(Object sender, EventArgs e)
        {
            new AppHost().Init();
        }
    }
}
