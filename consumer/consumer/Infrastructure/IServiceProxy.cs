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

            FizzBuzzService.ServiceClient client = new FizzBuzzService.ServiceClient();

            return client.GetData();

            
            


        }

    }
}
