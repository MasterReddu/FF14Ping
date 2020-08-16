using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace FF14Ping
{
    public partial class FFPing : Form
    {

        private bool IsDrag = false;
        private Point startPoint = new Point(0,0);
        private void FFPing_MouseDown(object sender, MouseEventArgs e)
        {
            IsDrag = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void FFPing_MouseUp(object sender, MouseEventArgs e)
        {
            IsDrag = false;
        }
        private void FFPing_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }



        public FFPing()
        {
            InitializeComponent();
        }

        

        private void FFPing_Load(object sender, EventArgs e)
        {
            // To update the first time.
            Ping();
            //Tick-tock on the clock
            //But the party don't stop...
            var myTimer = new Timer { Interval = 1000 };
            myTimer.Tick += (o, args) =>
            {
                Ping();
            };
            myTimer.Start();
        }





        private void Ping()
        //Ping the Tonberry Server and toss it in the label
        {
            using (Ping p = new Ping())
            {
                lblLatency.Text = p.Send("124.150.157.24").RoundtripTime.ToString() + "ms";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

