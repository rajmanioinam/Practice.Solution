using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPattern
{
    public sealed class SingletonThreadSafety
    {
        private int counter = 0;
        private static SingletonThreadSafety instance = null;
        private static object obj = new object();
        public static SingletonThreadSafety GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonThreadSafety();
                        }
                    }
                }
                return instance;
            }
        }
        private SingletonThreadSafety()
        {
            counter++;
            Console.WriteLine("Counter value; " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message + "; Counter Value: " + counter.ToString());
        }
    }
}
