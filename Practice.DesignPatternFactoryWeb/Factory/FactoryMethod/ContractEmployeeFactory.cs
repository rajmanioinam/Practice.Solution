using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.DesignPatternFactoryWeb.Managers;
using Practice.DesignPatternFactoryWeb.Models;

namespace Practice.DesignPatternFactoryWeb.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}