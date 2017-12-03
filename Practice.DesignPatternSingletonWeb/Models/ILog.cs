using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.DesignPatternSingletonWeb.Models
{
    public interface ILog
    {
        void LogException(string message);
    }
}