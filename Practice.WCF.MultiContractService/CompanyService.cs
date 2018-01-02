using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Practice.WCF.MultiContractService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in both code and config file together.
    public class CompanyService : IExternalService, IInternalService
    {
        public string GetExternalMessage()
        {
            return "This is an external message.";
        }

        public string GetInternalMessage()
        {
            return "This is an internal message";
        }
    }
}
