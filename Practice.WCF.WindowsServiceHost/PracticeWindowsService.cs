using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Practice.WCF.WindowsServiceHost
{
    public partial class PracticeWindowsService : ServiceBase
    {
        //installutil -i path/<applicationame>.exe to install the windows service
        ServiceHost host;
        public PracticeWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(Practice.WCF.Service.PracticeService));
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
