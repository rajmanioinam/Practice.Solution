using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice.Web.ASP_NET.DotNetBasic
{
    public partial class MultithreadingExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDoWork_Click(object sender, EventArgs e)
        {
            //DoTimeConsumingWork();
            Thread thread = new Thread(DoTimeConsumingWork);
            thread.Start();
        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(10000);
            logStatus("Do Time Consuming Work");
        }

        private void logStatus(string source)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\MyPC\GITHUB\Practice.Solution\Practice.Web\Components\Logs\Logs.txt",true))
            {
                sw.WriteLine(source + " : " + DateTime.Now.ToString());
            }
        }

        protected void btnDoAnotherWork_Click(object sender, EventArgs e)
        {
            logStatus("Do Another Work");
        }
    }
}