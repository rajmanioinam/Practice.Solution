using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPatternFactoryWeb.Managers
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetHourlyPay();
    }
}
