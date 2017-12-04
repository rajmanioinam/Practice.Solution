using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.DesignPatternFactoryWeb.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 16;
        }

        public decimal GetHourlyPay()
        {
            return 48;
        }
    }
}