using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPattern
{
    public class ContractEmployee : IEmployee
    {
        public void GetBonus()
        {
            Console.WriteLine("Contract Employee Bonus");
        }

        public void GetPay()
        {
            Console.WriteLine("Contract Employee Pay");
        }
    }
}
