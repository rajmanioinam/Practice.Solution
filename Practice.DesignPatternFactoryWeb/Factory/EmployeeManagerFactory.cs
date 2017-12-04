using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.DesignPatternFactoryWeb.Managers;

namespace Practice.DesignPatternFactoryWeb.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeType)
        {
            IEmployeeManager retVal = null;
            if (employeeType == 1)
            {
                retVal = new PermanentEmployeeManager();
            }
            else if (employeeType == 2)
            {
                retVal = new ContractEmployeeManager();
            }
            return retVal;
        }
    }
}