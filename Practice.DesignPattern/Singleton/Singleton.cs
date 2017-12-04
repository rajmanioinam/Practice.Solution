using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPattern
{
    public sealed class SingletonSimple
    {
        private static int counter = 0;
        private static SingletonSimple instance = null;
        public static SingletonSimple GetInstance
        {
            get
            {
                if(instance==null)
                {
                    instance = new SingletonSimple();
                }
                return instance;
            }
        }
        private SingletonSimple()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message + "; Counter value: " + counter.ToString() );
        }
    }
}
