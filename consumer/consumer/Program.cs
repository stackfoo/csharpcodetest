using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace consumer {
    class Program {
        static void Main(string[] args) {


            //wire up DI Container
            IUnityContainer container = new UnityContainer();
            Infrastructure.BootStrap.BuildUp(container);

            //build up our fizzbuzz instance
            FizzBuzz fb = new FizzBuzz();
            container.BuildUp<FizzBuzz>(fb);


            //call fizzbuzz.dofizzbuzz 50 times, outputing the value that the service used (returned via ref param)
            //and the fizzbuzz evaluate returned by fizzbuzz operation.
            


            Console.WriteLine("All Done!  Yay!  Press [Enter] to close.");
            Console.ReadLine();

        }
    }


}
