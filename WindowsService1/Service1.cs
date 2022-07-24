using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        Timer timer;
        
        protected override void OnStart(string[] args)
        {
            LOG.write("Service is start at " + DateTime.Now);
            timer = new Timer();
            timer.Start();
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5000;
            timer.Enabled = true;
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            LOG.write("Service is running at " + DateTime.Now);
        }
        protected override void OnStop()
        {
            LOG.write("Service is stoped at " + DateTime.Now);
        }
    }
}
