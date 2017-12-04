using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPattern
{
    public class EmployeeManager
    {
        public IEmployee GetEmployeeManager(int employeeType)
        {
            IEmployee employee = null;
            if(employeeType==1)
            {
                employee = new ContractEmployee();
            }
            else if(employeeType==2)
            {
                employee = new FullTimeEmployee();
            }
            return employee;
        }
    }
}
