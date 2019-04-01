using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label2.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value.ToString() == "100")
            {
                timer1.Stop();
                MessageBox.Show(@"您的智商為""987""不能在高了"+"\n\n 請按確定後結束程式");
                int millisecondsTimeout = 500; // 1 sec
                System.Threading.Thread.Sleep(millisecondsTimeout);
                this.Close();
                Environment.Exit(Environment.ExitCode);
                InitializeComponent();
            }
        }
    }
}
