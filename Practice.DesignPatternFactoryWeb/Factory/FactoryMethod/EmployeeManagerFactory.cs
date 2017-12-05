using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.DesignPatternFactoryWeb.Models;


namespace Practice.DesignPatternFactoryWeb.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory retVal = null;
            if (employee.EmployeeTypeId == 1)
            {
                retVal = new PermanentEmployeeFactory(employee);
            }
            else if (employee.EmployeeTypeId == 2)
            {
                retVal = new ContractEmployeeFactory(employee);
            }
            return retVal;
        }
    }
}