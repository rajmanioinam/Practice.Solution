using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.DesignPatternFactoryWeb.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 8;
        }

        public decimal GetHourlyPay()
        {
            return 35;
        }
    }
}