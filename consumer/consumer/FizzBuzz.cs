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

        public string DoFizzBuzz(ref int value) {

            int fromService = this.ServiceProxy.GetValue();
            // for each call, return the value via the ref parameter
            value = fromService;

            /*
             * For any number that the service returns
             * If the number is equally divisible by 3, return 'Fizz'
             * if the number is equally divisible by 5, return 'Buzz'
             * if the number is equally divisible by both 3 and 5, return 'FizzBuzz'
             * otherwise, return the number
            */
            
            throw new NotImplementedException("Evaluate FizzBuzz Here");



        }

    }
}
