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
        #region Form Movement  
        //Allows form to be dragged around even when controls arent showing
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

        //Initialise Location Data
        int SavedLocationX = Properties.Settings.Default.SavedLocationX;
        int SavedLocationY = Properties.Settings.Default.SavedLocationY;
        string MyServer = Properties.Settings.Default.MyServer;
        #endregion



        public FFPing()
        {
            InitializeComponent();
        }

        private void FFPing_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            Location = new Point(SavedLocationX, SavedLocationY);


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
                lblLatency.Text = p.Send(MyServer).RoundtripTime.ToString() + "ms";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Save data and exit when the little x is clicked
            SavedLocationX = this.Location.X;
            SavedLocationY = this.Location.Y;
            Properties.Settings.Default.SavedLocationX = SavedLocationX;
            Properties.Settings.Default.SavedLocationY = SavedLocationY;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {

            new FFUserSettings().Show();
            this.Hide();
        }

        public void ChangeMeColor(Color clr)
        {
            lblLatency.BackColor = clr;
        }

        public void ChangeServer(string thisServer)
        {
            MyServer = thisServer;
        }


    }
}

