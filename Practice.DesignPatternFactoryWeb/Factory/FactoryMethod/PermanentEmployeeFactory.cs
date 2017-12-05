using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.DesignPatternFactoryWeb.Managers;
using Practice.DesignPatternFactoryWeb.Models;

namespace Practice.DesignPatternFactoryWeb.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllownce = manager.GetHouseAllowance();
            return manager;
        }
    }
}