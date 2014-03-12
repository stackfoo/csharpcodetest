using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace consumer.Infrastructure {
    public interface IServiceProxy {

        int GetValue();

    }

    public class ServiceProxy:IServiceProxy {

        int IServiceProxy.GetValue() {

            consumer.ServiceReference1.ServiceClient cli = new ServiceReference1.ServiceClient();
            return cli.GetData();
           // throw new NotImplementedException("Wire up service here");
            


        }

    }
}
