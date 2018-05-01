using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using System.Reflection;
using AndyHelloWorld.Infrastructure;

namespace AndyHelloWorld
{
    class Program
    {
        /// <summary>
        /// Program prints to console or "database" depending on source key in App.config file
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Ninject setup. Gets implementation to pass to Message class
            var kernel = new StandardKernel(new HelloModule());
            kernel.Load(Assembly.GetExecutingAssembly());
            var source = kernel.Get<ICommand>();

            var message = new Message(source);

            Console.WriteLine(message.Write());

            Console.ReadKey();
        }
    }
}
