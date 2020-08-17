using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF14Ping
{
    public partial class FFUserSettings : Form
    {

        private FFPing secondForm;
  
        public FFUserSettings()
        {
            InitializeComponent();
            secondForm = new FFPing();
            secondForm.Show();
        }

        private void btnShowBack_Click(object sender, EventArgs e)
        {
            string ColorMeThis = "";
            ColorMeThis = cmbBackColor.Text;

            switch (ColorMeThis)
            {
                case "Indian Red":
                    secondForm?.ChangeMeColor(Color.IndianRed);
                    break;
                case "Dark Green":
                    secondForm?.ChangeMeColor(Color.DarkGreen);
                    break;
                case "Dark Grai":
                    secondForm?.ChangeMeColor(Color.DarkGray);
                    break;
                default:
                    secondForm?.ChangeMeColor(Color.Black);
                    break;
            }

            
        }
    }
}
