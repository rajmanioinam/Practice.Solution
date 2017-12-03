﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DesignPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
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