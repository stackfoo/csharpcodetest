using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using consumer.Infrastructure;

namespace consumer {
    public class FizzBuzz {

        [Dependency]
        public IServiceProxy ServiceProxy { get; set; }

        public string DoFizzBuzz() {

            int fromService = this.ServiceProxy.GetValue();

            throw new NotImplementedException("Evaluate FizzBuzz Here");

        }

    }
}
