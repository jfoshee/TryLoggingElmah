using System;
using ServiceStack.ServiceInterface;
using ServiceStack.Logging;
using System.Reflection;
using ServiceStack.ServiceHost;

namespace TryLoggingElmah
{
    public class FooResponse
    {
        public int Sum { get; set; }
    }

    public class FooRequest : IReturn<FooRequest>
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }

    public class FooService : Service
    {
        static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public FooService()
        {
            Log.Info("Constructed");
        }

        public FooResponse Get(FooRequest request)
        {
            return new FooResponse
            {
                Sum = request.Value1 + request.Value2
            };
        }
    }
}

