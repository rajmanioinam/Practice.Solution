using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPattern
{
    public class FullTimeEmployee : IEmployee
    {
        public void GetBonus()
        {
            Console.WriteLine("FullTime Employee Bonus");
        }

        public void GetPay()
        {
            Console.WriteLine("FullTime Employee Pay");
        }
    }
}
