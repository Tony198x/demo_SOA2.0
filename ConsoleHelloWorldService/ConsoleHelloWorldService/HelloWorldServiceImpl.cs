using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CServiceStack.Common.Types;
using CServiceStack.ServiceHost;

namespace ConsoleHelloWorldService
{
    public class HelloWorldServiceImpl : IHelloWorldService
    {
        [Route("/sayHello")]
        public HelloResponseType Hello(HelloRequestType helloWorldIn)
        {
            return new HelloResponseType { Result = "Hello " + helloWorldIn.Name };
        }

        [Route("/check")]
        public CheckHealthResponseType CheckHealth(CheckHealthRequestType healthCheckIn)
        {
            return new CheckHealthResponseType();
        }
    }
}
