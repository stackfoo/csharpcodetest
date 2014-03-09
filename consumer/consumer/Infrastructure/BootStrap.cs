using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace consumer.Infrastructure {
    public class BootStrap {

        public static void BuildUp(IUnityContainer container) {

            container.RegisterType<IServiceProxy, ServiceProxy>(new PerThreadLifetimeManager());
            
        }

    }
}
