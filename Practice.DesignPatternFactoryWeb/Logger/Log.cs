using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.DesignPatternFactoryWeb.Logger
{
    public sealed class Log : ILog
    {
        private Log()
        { }
        private static Lazy<Log> instance = new Lazy<Log>(() => new Log());
        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void LogException(string message)
        {
            string fileName = "Exception_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_.log";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + fileName;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}