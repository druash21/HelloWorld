using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using AndyHelloWorld.Infrastructure;
using System.Configuration;
using System.Reflection;

namespace AndyHelloWorld
{
    class HelloModule : NinjectModule
    {

        public override void Load()
        {
            string source = ConfigurationManager.AppSettings["source"];
            Assembly assem = typeof(ICommand).Assembly;
            
            //Gets namespace to find type
            var namespac = assem.GetTypes().Where(x => x.Name == "ICommand").Select(x => x.Namespace).FirstOrDefault();
            
            //Gets type for binding. Based on App.config source key
            Type typ = assem.GetType(namespac + "." + source);

            Bind<ICommand>().To(typ);
        }


    }

}
