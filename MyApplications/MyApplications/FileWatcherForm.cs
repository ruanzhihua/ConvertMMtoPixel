using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplications
{
    public partial class FileWatcherForm : Form
    {
        public FileWatcherForm()
        {
            InitializeComponent();
        }

        private void buttonSelectCacheFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                this.textboxWatcherPath.Text = fbd.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            if(!Directory.Exists(this.textboxWatcherPath.Text))
            {
                MessageBox.Show("文件夹无效");
                return;
            }
            fsw.Path = this.textboxWatcherPath.Text;
            /* 设置为监视 LastWrite 和 LastAccess 时间方面的更改，以及目录中文本文件的创建、删除或重命名。 */
            fsw.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // 添加事件处理器。
            fsw.Changed += new FileSystemEventHandler(OnChanged);
            //fsw.Created += new FileSystemEventHandler(OnCreated);
            fsw.Deleted += new FileSystemEventHandler(OnDeleted);
            //fsw.Renamed += new RenamedEventHandler(OnRenamed);
            fsw.EnableRaisingEvents = true;
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show("OnRenamed");
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("OnDeleted");
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("OnCreated");
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("OnChanged");
        }
    }
}
