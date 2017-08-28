using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackupService
{
    public partial class BackupService : ServiceBase
    {
        string mainPath = @"D:\project_dir\freshbatch-july17\Assignments\dotNet\Main Path\";
        string backupPath = @"D:\project_dir\freshbatch-july17\Assignments\dotNet\Backup Path\";
        

        public BackupService()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("BackupSvcSource"))
                System.Diagnostics.EventLog.CreateEventSource("BackupSvcSource", "BackupSvcLog");
            eventLog1.Source = "BackupSvcSource";
            eventLog1.Log = "BackupSvcLog";
        }

        protected override void OnStart(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(mainPath);
            eventLog1.WriteEntry("Monitoring Main Path");
            watcher.Created += Watcher_Created;
            watcher.Changed += Watcher_Changed;
            watcher.Deleted += Watcher_Deleted;
            watcher.Renamed += Watcher_Renamed;
            watcher.Error += Watcher_Error;
            watcher.EnableRaisingEvents = true;
        }

        private void Watcher_Error(object sender, ErrorEventArgs e)
        {
            eventLog1.WriteEntry("Errors found : ");
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {

            eventLog1.WriteEntry("File Created");
            if (File.Exists(mainPath + e.Name))
                  File.Copy(mainPath + e.Name, backupPath + e.Name, true);
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            eventLog1.WriteEntry("File Renamed");
            if (File.Exists(mainPath + e.Name))
            {
                File.Copy(mainPath + e.Name, backupPath + e.Name, true);
                File.Delete(backupPath + e.OldName);
            }
            
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("File Deleted");
           
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("File Changed");
            if (File.Exists(mainPath + e.Name))
                File.Copy(mainPath + e.Name,backupPath +e.Name,true);
        }

        protected override void OnStop()
        {
        }
        protected override void OnPause()
        {
            base.OnPause();
        }

        protected override void OnContinue()
        {
            base.OnContinue();
        }

    }
}
