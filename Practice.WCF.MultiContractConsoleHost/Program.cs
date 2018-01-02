using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Practice.WCF.MultiContractConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Practice.WCF.MultiContractService.CompanyService)))
            {
                host.Open();
                Console.WriteLine("Host Stated @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
