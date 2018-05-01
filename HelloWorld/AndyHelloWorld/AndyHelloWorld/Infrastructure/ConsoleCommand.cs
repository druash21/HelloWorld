﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI;

namespace AndyHelloWorld.Infrastructure
{
    class ConsoleCommand : ICommand
    {
        public string Write()
        {
           var api = new HelloAPI();

           return api.ConsoleWrite();
        }
    }
}
