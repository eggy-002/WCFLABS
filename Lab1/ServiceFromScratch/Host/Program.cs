using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace ServiceFromScratch
{
   class Program
   {
      static void Main(string[] args)
      {
         using(ServiceHost host = new ServiceHost(typeof(HelloIndigoService), 
            new Uri("http://localhost:8000/HelloIndigo")))
         {
            host.AddServiceEndpoint(typeof(IHelloIndigoService),
               new BasicHttpBinding(), "HelloIndigoService");
            host.Open();
            Console.WriteLine("Press <ENTER> to terminate the service hook");
            Console.ReadLine();
         }
      }
   }
}
