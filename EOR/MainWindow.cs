using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EOR
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
            try
            {
                axShockwaveFlash1.WMode = "Window";
                axShockwaveFlash1.Size = new System.Drawing.Size(200,150);
                axShockwaveFlash1.Movie = AppDomain.CurrentDomain.BaseDirectory + "\\sample.swf";
            }
            catch(Exception ee)
            {
                MessageBox.Show("Exception "+ee.Message);
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            txtDescription.Text = "Click on the Exit Button to close the plugin.";
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            txtDescription.Text = String.Empty;
        }

        private void btnStarted_Click(object sender, EventArgs e)
        {
            GettingStarted gs = new GettingStarted();
            gs.Show();
        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            PredictionWindow pw = new PredictionWindow();
            pw.Show();
        }

        private void btnStarted_MouseEnter(object sender, EventArgs e)
        {
            txtDescription.Text = "Click on the button see the video of how this plugin works.";
        }

        private void btnStarted_MouseLeave(object sender, EventArgs e)
        {
            txtDescription.Text = String.Empty;
        }

        private void btnPrediction_MouseEnter(object sender, EventArgs e)
        {
            txtDescription.Text = "Click on the button to predict which EOR method is to be used in the field.";
        }

        private void btnPrediction_MouseLeave(object sender, EventArgs e)
        {
            txtDescription.Text = String.Empty;
        }

        private void btnTraining_MouseEnter(object sender, EventArgs e)
        {
            txtDescription.Text = "Click on the button to train the Artificial Neural Network.";
        }

        private void btnTraining_MouseLeave(object sender, EventArgs e)
        {
            txtDescription.Text = String.Empty;
        }

        private void btnHelp_MouseEnter(object sender, EventArgs e)
        {
            txtDescription.Text = "Click on the button to have a written help on how to use the plugin.";
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            txtDescription.Text = String.Empty;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("This button will be in working state when plugin will complete. This Help buttom will help the user while working with the plugin. ");
            //Help help = new Help();
            //help.Show();
            try
            {
                Help.ShowHelp(this, "C:\\Check\\eclipse.chm");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        

       
    }
}
