using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace consumer {
    class Program {
        static void Main(string[] args) {

            try { 
            //wire up DI Container
            IUnityContainer container = new UnityContainer();
            Infrastructure.BootStrap.BuildUp(container);

            //build up our fizzbuzz instance

            FizzBuzz fb = new FizzBuzz();
            container.BuildUp<FizzBuzz>(fb);
                int ref_int = 0;
                string test = fb.DoFizzBuzz(ref ref_int);
            Console.WriteLine("All Done!  Yay!  Press [Enter] to close.");

            Console.ReadLine();

            //call fizzbuzz.dofizzbuzz 50 times, outputing the value that the service used (returned via ref param)
            //and the fizzbuzz evaluate returned by fizzbuzz operation.
            } catch(Exception error)
            { 
                throw new NotImplementedException("Display FizzBuzz Results Here");            
            }
        }
    }
}
