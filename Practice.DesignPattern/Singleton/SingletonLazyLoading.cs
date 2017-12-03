using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPattern
{
    public sealed class SingletonLazyLoading
    {
        private static int counter = 0;
        private static Lazy<SingletonLazyLoading> instance = new Lazy<SingletonLazyLoading>(()=>new SingletonLazyLoading());
        public static SingletonLazyLoading GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        private SingletonLazyLoading()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message + "; Counter value: " + counter.ToString());
        }
    }
}
