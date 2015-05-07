using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace EOR
{
    public partial class GettingStarted : Form
    {
        public GettingStarted()
        {
            InitializeComponent();
            try
            {
              axWindowsMediaPlayer1.URL = Application.StartupPath + "\\Plugin Video\\video.wmv";
            }
            catch(Exception ee)
            {
                MessageBox.Show("Exception " + ee.Message);
            }
        }
    }
}
