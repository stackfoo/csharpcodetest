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

            //servic expects that a header be passed (name = "Test", namespace="")
            //.. the contract for which is defined in the service reference.

            throw new NotImplementedException("Wire up service here");
            


        }

    }
}
