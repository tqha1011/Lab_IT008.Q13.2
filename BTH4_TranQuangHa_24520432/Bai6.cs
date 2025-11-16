using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_TranQuangHa_24520432
{
    public partial class Bai6 : Form
    {
        string filesource = "";
        string folderdestination = "";
        public Bai6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            filesource = openFileDialog.FileName;
            txtSource.Text = filesource;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            folderdestination = folderBrowserDialog.SelectedPath;
            txtDestination.Text = folderdestination;
        }

        

        private void btnCopy_Click(object sender, EventArgs e)
        {
            pgbCopy.Value = 0;
            btnCopy.Enabled = false;
            textBox3.Text = filesource;
            List<string> files = new List<string>();
            files.Add(filesource);
            files.Add(folderdestination);
            backgroundWorker1.RunWorkerAsync(files);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            List<string> files = e.Argument as List<string>;
            string source = files[0];
            string destination = files[1];
            long totalBytes = new System.IO.FileInfo(source).Length;
            long totalBytesCopied = 0;
            using (var sourceStream = new System.IO.FileStream(source, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                using (var destinationStream = new System.IO.FileStream(System.IO.Path.Combine(destination, System.IO.Path.GetFileName(source)), System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    byte[] buffer = new byte[1024]; 
                    int bytesRead;
                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destinationStream.Write(buffer, 0, bytesRead);
                        totalBytesCopied += bytesRead;
                        int progressPercentage = (int)((totalBytesCopied * 100) / totalBytes);
                        worker.ReportProgress(progressPercentage);
                    }
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbCopy.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Copy file thành công!");
            btnCopy.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
