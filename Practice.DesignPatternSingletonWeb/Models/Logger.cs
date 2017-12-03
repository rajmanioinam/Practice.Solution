using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Practice.DesignPatternSingletonWeb.Models
{
    public sealed class Logger : ILog
    {
        private Logger()
        { }
        private static Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());
        public static Logger GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void LogException(string message)
        {
            string fileName = "Exception"+ DateTime.Now.ToString("yyyyMMddHHmmss")+".log";
            string logPath =  AppDomain.CurrentDomain.BaseDirectory + fileName;
            StringBuilder sb = new StringBuilder();
            sb.Append("------------------------------------");
            sb.Append(DateTime.Now.ToString());
            sb.Append(message);
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}