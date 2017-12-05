using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.DesignPatternFactoryWeb.Models;
using Practice.DesignPatternFactoryWeb.Managers;

namespace Practice.DesignPatternFactoryWeb.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee employee)
        {
            _emp = employee;
        }
        public abstract IEmployeeManager Create();
        public Employee ApplySalary()
        {
            IEmployeeManager employee = this.Create();
            _emp.Bonus = employee.GetBonus();
            _emp.HourlyPay = employee.GetHourlyPay();

            return _emp;
        }
    }
}