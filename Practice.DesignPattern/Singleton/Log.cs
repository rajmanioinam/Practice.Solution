using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Practice.DesignPattern.Singleton
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
            string fileName = "Log_" + message + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + fileName;
            StringBuilder sb = new StringBuilder();
            sb.Append("------------------------");
            sb.Append(DateTime.Now.ToString());
            sb.Append(message);
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
