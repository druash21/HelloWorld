using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndyHelloWorld.Infrastructure;

namespace AndyHelloWorld
{
    class Message
    {
        private readonly ICommand command;
        /// <summary>
        /// Constructor is passed correct implementation based on App.config and Ninject setup
        /// </summary>
        /// <param name="command">Injected from Ninject</param>
        public Message(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// Calls Write method of either ConsoleCommand or DatabaseCommand. 
        /// Could easily be expanded to others creating new command classes implementing the ICommand interface.
        /// </summary>
        /// <returns></returns>
        public string Write()
        {
            return command.Write();
        }
    }
}
