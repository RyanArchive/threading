using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void frmTrackThread_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine(label1.Text.ToString());

            ThreadStart delThread1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart delThread2 = new ThreadStart(MyThreadClass.Thread2);

            Thread threadA = new Thread(delThread1);
            threadA.Name = "Thread A Process";
            threadA.Priority = ThreadPriority.Highest;

            Thread threadB = new Thread(delThread2);
            threadB.Name = "Thread B Process";
            threadB.Priority = ThreadPriority.Normal;

            Thread threadC = new Thread(delThread1);
            threadC.Name = "Thread C Process";
            threadC.Priority = ThreadPriority.AboveNormal;

            Thread threadD = new Thread(delThread2);
            threadD.Name = "Thread D Process";
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
