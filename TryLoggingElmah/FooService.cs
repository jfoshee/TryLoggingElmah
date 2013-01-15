using System;
using System.Reflection;
using ServiceStack.ServiceInterface;
using ServiceStack.Logging;
using ServiceStack.ServiceHost;
using ServiceStack.Text;

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

    public class FooService : IService<FooRequest>
    {
        static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
//        public ILog Log { get; set; }

        public object Execute(FooRequest request)
        {
            Log.Info("Received request: " + request.Dump());
            if (request.Value1 < 0 || request.Value2 < 0)
                throw new InvalidOperationException("Negative numbers not supported");
            return new FooResponse
            {
                Sum = request.Value1 + request.Value2
            };
        }
    }
}
