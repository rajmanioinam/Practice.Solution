using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Practice.WCF.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PracticeService" in both code and config file together.
    public class PracticeService : IPracticeService
    {
        public string GetMessage(string message)
        {
            return "The message: " + message;
        }
    }
}
