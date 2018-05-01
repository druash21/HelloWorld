using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    public class HelloAPI
    {
        public string DatabaseWrite()
        {
            //Write to database
            return "Database";
        }

        public string ConsoleWrite()
        {
            Console.WriteLine("Hello world");
            return "Console";
        }

        public string MobileWrite()
        {
            return "Mobile";
        }

        public string WebWrite()
        {
            return "Web";
        }

        public string WinServiceWrite()
        {
            return "Win Service";
        }
    }
}
