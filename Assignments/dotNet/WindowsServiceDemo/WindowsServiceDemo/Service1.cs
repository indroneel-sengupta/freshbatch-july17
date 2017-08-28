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

namespace WindowsServiceDemo
{
    public partial class WindowsServiceDemo : ServiceBase
    {
        public WindowsServiceDemo()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("MyPracSvcSource"))
                System.Diagnostics.EventLog.CreateEventSource("MyPracSvcSource","MyPracSvcLog");
            eventLog1.Source = "MyPracSvcSource";
            eventLog1.Log = "MyPracSvcLog";
         }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("My service started for Demo");

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000;//60 seconds
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        private void OnTimer(object sender, ElapsedEventArgs args)
        {
            eventLog1.WriteEntry("Monitoring the service",EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("My service stopped for Demo");

        }
    }
}
