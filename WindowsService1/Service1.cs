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
using System.Threading;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        System.Timers.Timer timer;
        
        protected override void OnStart(string[] args)
        {
           /* LOG.write("Service is start at " + DateTime.Now);
            timer = new System.Timers.Timer();
            timer.Start();
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5000;
            timer.Enabled = true;*/
            for (int i = 1; i <=5; i++)
            {
               
                ThreadPool.QueueUserWorkItem(LOG.Print_to_File, i);
            }
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
           // LOG.write("Service is running at " + DateTime.Now);
        }
        protected override void OnStop()
        {
           // LOG.write("Service is stoped at " + DateTime.Now);
        }
    }
}
