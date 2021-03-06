﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CServiceStack.WebHost.Endpoints;

namespace ConsoleHelloWorldService
{

    // Define the Web Service AppHost
    public class AppHost : AppHostHttpListenerBase
    {
        public AppHost() : base(typeof(Program).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            // ignore for demo
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listeningOn = args.Length == 0 ? "http://*:1337/" : args[0];
            var appHost = new AppHost();
            appHost.Init();
            appHost.Start(listeningOn);

            Console.WriteLine("AppHost Created at {0}, listening on {1}", DateTime.Now, listeningOn);
            Console.ReadKey();
        }
    }
}
