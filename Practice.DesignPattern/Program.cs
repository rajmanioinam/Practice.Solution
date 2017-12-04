using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SINGLETON
            //SINGLETON SIMPLE
            Console.WriteLine("SINGLETON");
            SingletonSimple s1 = SingletonSimple.GetInstance;
            s1.PrintDetails("From S1");

            SingletonSimple s2 = SingletonSimple.GetInstance;
            s2.PrintDetails("From s2");
            Console.ReadLine();

            //SINGLETON THREAD SAFETY
            Console.WriteLine("SINGLETON THREAD SAFETY");
            Parallel.Invoke(() => PrintS1(), () => PrintS2());
            Console.ReadLine();

            //SINGLETON LAZY LOADING
            Console.WriteLine("SINGLETON LAZY LOADING");
            Parallel.Invoke(() => PrintL1(), () => PrintL2());
            Console.ReadLine();
            #endregion

            #region SIMPLE FACTORY
            Console.WriteLine("SIMPLE FACTORY");
            EmployeeManager employeeManager = new EmployeeManager();
            IEmployee contractEmployee = employeeManager.GetEmployeeManager(1);
            contractEmployee.GetBonus();
            contractEmployee.GetPay();
            Console.ReadLine();

            IEmployee fullTimeEmployee = employeeManager.GetEmployeeManager(2);
            fullTimeEmployee.GetBonus();
            fullTimeEmployee.GetPay();
            Console.ReadLine();
            #endregion
        }

        #region SINGLETON
        //SINGLETON THREAD SAFETY
        private static void PrintS1()
        {
            SingletonThreadSafety s1 = SingletonThreadSafety.GetInstance;
            s1.PrintDetails("From Singleton Thread Safety S1");
        }
        private static void PrintS2()
        {
            SingletonThreadSafety s2 = SingletonThreadSafety.GetInstance;
            s2.PrintDetails("From Singleton Thread Safety S2");
        }

        //SINGLETON LAZY LOADING 
        private static void PrintL1()
        {
            SingletonLazyLoading L1 = SingletonLazyLoading.GetInstance;
            L1.PrintDetails("From Singleton Lazy Loading L1");
        }
        private static void PrintL2()
        {
            SingletonLazyLoading L2 = SingletonLazyLoading.GetInstance;
            L2.PrintDetails("From Singleton Thread Safety L2");
        }
        #endregion
    }
}
