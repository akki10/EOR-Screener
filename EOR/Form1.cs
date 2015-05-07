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
    public partial class Form1 : Form
    {
        
        double convertedVlaueTemp = 0.0;
        double convertedValueDepth = 0.0;
        int countLines = 0;
        double userInputPorosity = 0.0;
        double userInputPermeability = 0.0;
        double userInputTemperature = 0.0;
        double userInputDepth = 0.0;
        double userInputOilGravity = 0.0;
        double userInputOilViscosity = 0.0;
        double userInputOilSaturation = 0.0;
        double[] weights;
        double[] userInput;
        double[] computedOutput;
        double[] targetOutput;
        double eta;
        double alpha;
        string[] s1;
        int counter = 0;
        String path = String.Empty;
        StreamReader sr;
        Timer timer1 = new Timer();
        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            lblProcess.Visible = false;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

       // To import the training data
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Text File| *.txt";
            ofg.Title = "Open Training Data";
            if (ofg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = ofg.FileName;

                // to count the number of inputs
                sr = new StreamReader(File.OpenRead(path));
                while (!String.IsNullOrWhiteSpace(sr.ReadLine()))
                    countLines++;
            }
            else
                this.Dispose();
            
        }
  
        
        // to start the training
        private void btnApply_Click(object sender, EventArgs e)
        {
            
                    
            BackPropogation backPropogation = new BackPropogation();
            targetOutput = new double[backPropogation.numOutput];

            if (String.IsNullOrWhiteSpace(txtRate.Text))
            {
                eta = 0.01;
            }
            else
            {
                try
                {
                    eta = Convert.ToDouble(txtRate.Text);
                    if (eta < 0 || eta > 1)
                    {
                        MessageBox.Show("Learning rate value must be between 0 and 1");
                        txtRate.Text = String.Empty;
                        txtRate.Focus();
                        return;
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Learning rate Error :" + ee.Message);
                    txtRate.Text = String.Empty;
                    txtRate.Focus();
                    return;
                }
            }
            if (String.IsNullOrWhiteSpace(txtMomentum.Text))
            {
                alpha = 0.1;
            }
            else
            {
                try
                {
                    alpha = Convert.ToDouble(txtMomentum.Text);

                    if (alpha < 0 || alpha > 1)
                    {
                        MessageBox.Show("Momentum value must be between 0 and 1");
                        txtMomentum.Text = String.Empty;
                        txtMomentum.Focus();
                        return;
                    }

                }
                catch (Exception ee)
                {
                    MessageBox.Show("Momentum Error :" + ee.Message);
                    txtMomentum.Text = String.Empty;
                    txtMomentum.Focus();
                    return;
                }
            }


            // To read the input data from the file strored at path specified
            // with the timer control.
            
            if (!String.IsNullOrEmpty(path))
            {
                sr = new StreamReader(File.OpenRead(path));
                timer1.Interval = 300;
                timer1.Start();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;
                this.btnApply.Enabled = false;
                btnImport.Enabled = false;
                this.progressBar1.Visible = true;
                lblProcess.Visible = true;
                btnCancel.Enabled = true;
                counter = 1;
                
            }
                
           //Read the data if entered manually
            else
            {

                //To check the validity of inputs
                try
                {
                    userInputPorosity = Convert.ToDouble(txtPorosity.Text);
                    if (userInputPorosity < 0.0 || userInputPorosity > 65)
                    {
                        MessageBox.Show("Porosity value out of range. Check instant help field for more information.");
                        txtPorosity.Focus();
                        txtPorosity.Text = String.Empty;
                        return;
                    }
                
                    userInputPermeability = Convert.ToDouble(txtPermeability.Text);
                    if (userInputPermeability < 0.0 || userInputPermeability > 11500)
                    {
                        MessageBox.Show("Permeability value is not valid. Please check your input value");
                        txtPermeability.Focus();
                        txtPermeability.Text = String.Empty;
                        return;
                    }
               
                    if (convertedVlaueTemp == 0)
                        userInputTemperature = Convert.ToDouble(txtTemp.Text);

                    else
                        userInputTemperature = convertedVlaueTemp;

                    if (userInputTemperature < 0.0 || userInputTemperature > 290)
                    {
                        MessageBox.Show("Temperature value is not valid. Please check your input value");
                        txtTemp.Focus();
                        txtTemp.Text = String.Empty;
                        comboBox1.SelectedIndex = 0;
                        convertedVlaueTemp = 0;
                        return;
                    }
               

                    if (convertedValueDepth > 0)
                        userInputDepth = convertedValueDepth;
                    else
                        userInputDepth = Convert.ToDouble(txtDepth.Text);

                    if (userInputDepth < 0.0 || userInputDepth > 13750)
                    {
                        MessageBox.Show("Reservoir Depth value is not valid. Please check your input value");
                        txtDepth.Focus();
                        txtDepth.Text = String.Empty;
                        comboBox2.SelectedIndex = 0;
                        convertedValueDepth = 0;
                        return;

                    }
                
                    userInputOilGravity = Convert.ToDouble(txtGravity.Text);
                    if (userInputOilGravity < 0.0 || userInputOilGravity > 57)
                    {
                        MessageBox.Show("Oil Gravity value is not valid. Please check your input value");
                        txtGravity.Focus();
                        txtGravity.Text = String.Empty;
                        return;
                    }
                
                    userInputOilViscosity = Convert.ToDouble(txtViscosity.Text);
                    if (userInputOilViscosity < 0.0 || userInputOilViscosity > 200000)
                    {
                        MessageBox.Show("Oil viscosity value is not valid. Please check your input value");
                        txtViscosity.Focus();
                        txtViscosity.Text = String.Empty;
                        return;
                    }
                
                    userInputOilSaturation = Convert.ToDouble(txtOilSaturation.Text);
                    if (userInputOilSaturation < 0.0 || userInputOilSaturation > 98)
                    {
                        MessageBox.Show("Initial Oil Saturation value is not valid. Please check your input value");
                        txtOilSaturation.Focus();
                        txtOilSaturation.Text = String.Empty;
                        return;
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error :" + ee.Message);
                    return;
                }
               
                //to check which output has been selected

                if (radiosteam.Checked == true)
                {
                    double[] result = { 1, 0, 0, 0, 0 };
                    targetOutput = result;
                }
                if (radioco2.Checked == true)
                {
                    double[] result = { 0, 1, 0, 0, 0 };
                    targetOutput = result;
                }
                if (radiohydro.Checked == true)
                {
                    double[] result = { 0, 0, 1, 0, 0 };
                    targetOutput = result;
                }
                if (radioinsitu.Checked == true)
                {
                    double[] result = { 0, 0, 0, 1, 0 };
                    targetOutput = result;
                }
                if (radiopolymer.Checked == true)
                {
                    double[] result = { 0, 0, 0, 0, 1 };
                    targetOutput = result;
                }

                //to check the validity of output 
                if (radioco2.Checked == false && radiohydro.Checked == false && radioinsitu.Checked == false
                    && radiopolymer.Checked == false && radiosteam.Checked == false)
                    MessageBox.Show("No output has been selected. Output selection is must for training.");

                // Artificial Neural Network processing
                weights = backPropogation.ReadWeights();

                backPropogation.SetWeight(weights);

                userInput = backPropogation.NormalizeInput(userInputPorosity, userInputPermeability, userInputTemperature, userInputDepth, userInputOilGravity, userInputOilViscosity, userInputOilSaturation);

                computedOutput = backPropogation.ComputeOutput(userInput);

                double error = backPropogation.CalculateError(computedOutput, targetOutput);
                int epoch = 0;
                while (epoch < 10000 && error > 0.01)
                {
                    backPropogation.UpdateWeights(targetOutput, eta, alpha);
                    computedOutput = backPropogation.ComputeOutput(userInput);
                    error = backPropogation.CalculateError(computedOutput, targetOutput);
                    epoch++;
                }

                txtIteration.Text = epoch.ToString();
                txtError.Text = error.ToString();

                double[] newWeights = backPropogation.GetWeights();

                backPropogation.SetWeight(newWeights);

                backPropogation.SaveWeights(newWeights);

            }
            

        }

        // Timer tick event to handle the training data if it is done from a text file 
        void timer1_Tick(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtRate.Text))
            {
                eta = 0.01;
            }
            else
            {
                try
                {
                    eta = Convert.ToDouble(txtRate.Text);
                    if (eta < 0 || eta > 1)
                    {
                        MessageBox.Show("Learning rate value must be between 0 and 1");
                        txtRate.Text = String.Empty;
                        txtRate.Focus();
                        return;
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Learning rate Error :" + ee.Message);
                    txtRate.Text = String.Empty;
                    txtRate.Focus();
                    return;
                }
            }
            if (String.IsNullOrWhiteSpace(txtMomentum.Text))
            {
                alpha = 0.1;
            }
            else
            {
                try
                {
                    alpha = Convert.ToDouble(txtMomentum.Text);

                    if (alpha < 0 || alpha > 1)
                    {
                        MessageBox.Show("Momentum value must be between 0 and 1");
                        txtMomentum.Text = String.Empty;
                        txtMomentum.Focus();
                        return;
                    }

                }
                catch (Exception ee)
                {
                    MessageBox.Show("Momentum Error :"+ee.Message);
                    txtMomentum.Text = String.Empty;
                    txtMomentum.Focus();
                    return;
                }
            }

            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = countLines;
            
            BackPropogation backPropogation = new BackPropogation();
            targetOutput = new double[backPropogation.numOutput];
                String line = sr.ReadLine();

            // Stop the timer if all the inputs has been read
              if (String.IsNullOrWhiteSpace(line))
                {
                    timer1.Stop();
                    progressBar1.Visible = false;
                    lblProcess.Visible = false;
                    btnCancel.Enabled = false;
                    btnImport.Enabled = true;
                    counter = 1;
                    countLines = 0;
                    path = String.Empty;
                   
                    MessageBox.Show("Training has been completed");
                    btnApply.Enabled = true;
                    txtPorosity.Text = String.Empty;
                    txtPermeability.Text = String.Empty;
                    txtDepth.Text = String.Empty;
                    txtGravity.Text = String.Empty;
                    txtOilSaturation.Text = String.Empty;
                    txtTemp.Text = String.Empty;
                    txtViscosity.Text = String.Empty;
                    txtIteration.Text = String.Empty;
                    txtError.Text = String.Empty;
                    radioco2.Checked = false;
                    radiohydro.Checked = false;
                    radioinsitu.Checked = false;
                    radiopolymer.Checked = false;
                    radiosteam.Checked = false;
                }
                
              // Do this till there is some data to be read in the file    
                else
              {

                      // percentage += 100 / countLines; 
                       //lblPercentCompleted.Text = percentage.ToString();
                       progressBar1.Value = counter;

                        int i=1;
                        s1 = line.Split(',');
                        double[] inputArray = new double[0];
                        Int32[] outputArray = new Int32[0];
                        foreach (string s in s1)
                        {
                            // creating output array for training
                            if (i>7)
                            {
                                Array.Resize(ref outputArray, outputArray.Length + 1);
                                outputArray[outputArray.Length - 1] = Convert.ToInt32(s);
                                i++;
                            }

                            // creating input array for training
                            else
                            {
                                Array.Resize(ref inputArray, inputArray.Length + 1);
                                inputArray[inputArray.Length - 1] = Convert.ToDouble(s);
                                i++;
                            }

                        }

                  // check the validty of input training data
                        try
                        {
                            txtPorosity.Text = inputArray[0].ToString();
                            userInputPorosity = Convert.ToDouble(txtPorosity.Text);
                            if (userInputPorosity < 0.0 || userInputPorosity > 65)
                            {
                                timer1.Stop();
                                progressBar1.Visible = false;
                                lblProcess.Visible = false;
                                btnApply.Enabled = true;
                                MessageBox.Show("Porosity value is not valid at line number "+  counter +". Check instant help field for more information.");
                                txtPorosity.Focus();
                                txtPorosity.Text = String.Empty;
                                return;
                            }
                        
                      
                            txtPermeability.Text = inputArray[1].ToString();
                            userInputPermeability = Convert.ToDouble(txtPermeability.Text);
                            if (userInputPermeability < 0.0 || userInputPermeability > 11500)
                            {
                                timer1.Stop();
                                progressBar1.Visible = false;
                                lblProcess.Visible = false;
                                btnApply.Enabled = true;
                                MessageBox.Show("Permeability value is not valid at line number"+ counter +". Please check your input value");
                                txtPermeability.Focus();
                                txtPermeability.Text = String.Empty;
                                return;
                            }
                       

                     
                            txtTemp.Text = inputArray[2].ToString();
                            userInputTemperature = Convert.ToDouble(txtTemp.Text);
                            if (userInputTemperature < 0.0 || userInputTemperature > 290)
                            {
                                timer1.Stop();
                                progressBar1.Visible = false;
                                lblProcess.Visible = false;
                                btnApply.Enabled = true;
                                MessageBox.Show("Temperature value is not valid at line number" + counter + ". Please check your input value");
                                txtTemp.Focus();
                                txtTemp.Text = String.Empty;
                                return;
                            }
                        

                      
                            txtDepth.Text = inputArray[3].ToString();
                            userInputDepth = Convert.ToDouble(txtDepth.Text);
                            if (userInputDepth < 0.0 || userInputDepth > 13750)
                            {
                                timer1.Stop();
                                progressBar1.Visible = false;
                                lblProcess.Visible = false;
                                btnApply.Enabled = true;
                                MessageBox.Show("Reservoir Depth value is not valid at line number" + counter + ". Please check your input value");
                                txtDepth.Focus();
                                txtDepth.Text = String.Empty;
                                return;

                            }

                          txtGravity.Text = inputArray[4].ToString();
                            userInputOilGravity = Convert.ToDouble(txtGravity.Text);
                            if (userInputOilGravity < 0.0 || userInputOilGravity > 57)
                            {
                                timer1.Stop();
                                progressBar1.Visible = false;
                                lblProcess.Visible = false;
                                btnApply.Enabled = true;
                                MessageBox.Show("Oil Gravity value is not valid at line number" + counter + ". Please check your input value");
                                txtGravity.Focus();
                                txtGravity.Text = String.Empty;
                                return;
                            }
                       

                            txtViscosity.Text = inputArray[5].ToString();
                            userInputOilViscosity = Convert.ToDouble(txtViscosity.Text);
                            if (userInputOilViscosity < 0.0 || userInputOilViscosity > 200000)
                            {
                                timer1.Stop();
                                progressBar1.Visible = false;
                                lblProcess.Visible = false;
                                btnApply.Enabled = true;
                                MessageBox.Show("Oil viscosity value is not valid at line number" + counter + ". Please check your input value");
                                txtViscosity.Focus();
                                txtViscosity.Text = String.Empty;
                                return;
                            }
                        

                            txtOilSaturation.Text = inputArray[6].ToString();
                            userInputOilSaturation = Convert.ToDouble(txtOilSaturation.Text);
                            if (userInputOilSaturation < 0.0 || userInputOilSaturation > 98)
                            {
                                timer1.Stop();
                                progressBar1.Visible = false;
                                lblProcess.Visible = false;
                                btnApply.Enabled = true;
                                MessageBox.Show("Initial Oil Saturation value is not valid at line number" + counter + ". Please check your input value");
                                txtOilSaturation.Focus();
                                txtOilSaturation.Text = String.Empty;
                                return;
                            }
                        }
                        catch (Exception ee)
                        {
                            timer1.Stop();
                            progressBar1.Visible = false;
                            lblProcess.Visible = false;
                            btnApply.Enabled = true;
                            MessageBox.Show("Error :" + ee.Message);
                            return;
                        }


                        if (outputArray[0] == 1)
                        {
                            radiosteam.Checked = true;
                            double[] result = { 1, 0, 0, 0, 0 };
                            targetOutput = result;
                        }
                        if (outputArray[1] == 1)
                        {
                            radioco2.Checked = true;
                            double[] result = { 0, 1, 0, 0, 0 };
                            targetOutput = result;
                        }
                        if (outputArray[2] == 1)
                        {
                            radiohydro.Checked = true;
                            double[] result = { 0, 0, 1, 0, 0 };
                            targetOutput = result;
                        }
                        if (outputArray[3] == 1)
                        {
                            radioinsitu.Checked = true;
                            double[] result = { 0, 0, 0, 1, 0 };
                            targetOutput = result;

                        }
                        if (outputArray[3] == 1)
                        {
                            radiopolymer.Checked = true;
                            double[] result = { 0, 0, 0, 1, 0 };
                            targetOutput = result;
                        }

                        // Artificial neural network processing
                        weights = backPropogation.ReadWeights();

                        backPropogation.SetWeight(weights);

                        userInput = backPropogation.NormalizeInput(userInputPorosity, userInputPermeability, userInputTemperature, userInputDepth, userInputOilGravity, userInputOilViscosity, userInputOilSaturation);

                        computedOutput = backPropogation.ComputeOutput(userInput);

                        double error = backPropogation.CalculateError(computedOutput, targetOutput);
                        int epoch = 0;
                        while (epoch < 10000 && error > 0.01)
                        {
                            backPropogation.UpdateWeights(targetOutput, eta, alpha);
                            computedOutput = backPropogation.ComputeOutput(userInput);
                            error = backPropogation.CalculateError(computedOutput, targetOutput);
                            epoch++;
                        }

                        txtIteration.Text = epoch.ToString();
                        txtError.Text = error.ToString();

                        double[] newWeights = backPropogation.GetWeights();

                        backPropogation.SaveWeights(newWeights);
                        
                        counter++;
                        
                    }
                  
             
            }
        


        private void txtPorosity_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Porosity minimum value is 0.0 and maximum value is 65.0. Unit is peercent";
        }

        private void txtPorosity_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void txtPermeability_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Permeability minimum value is 0.0 and maximum value is 11,500.0. Unit is milidarcy";
        }

        private void txtPermeability_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void txtTemp_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Temperature mininum value is 0.0 and maximum value is 290.0. Unit is Farenhiet";
        }

        private void txtTemp_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void txtDepth_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Depth minimum value is 0.0 and maximum value is 13,750.0. Unit is ft";
        }

        private void txtDepth_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void txtGravity_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Oil Gravity minimum value is 0.0 and maximum value is 57.0 . Unit is API.";
        }

        private void txtGravity_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void txtViscosity_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Oil Viscosity minimum value is 0.0 and maximum value is 200,000 . Unit is cp";
        }

        private void txtViscosity_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void txtOilSaturation_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Oil Saturation minimum value is 0.0 and maximum value is 98.0 . Unit is % in OOIP";
        }

        private void txtOilSaturation_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void txtRate_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Set the Learning rate for training the Neural Network. Default learning rate is 0.5 ";
        }

        private void txtRate_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void txtMomentum_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Set the momentum for training the Neural Network. Default momentum is 0.2 ";
        }

        private void txtMomentum_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Visible = false;
            lblProcess.Visible = false;
            MessageBox.Show("Training has been stopped");
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double value = 0.0;

            if (txtTemp.Text == "")
                return;
            try
            {
                value = Convert.ToDouble(txtTemp.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Temperature Error :" + ee.Message);
                txtTemp.Text = String.Empty;
                txtTemp.Focus();
                comboBox1.SelectedIndex = 0;
            }
            if (comboBox1.SelectedIndex == 2)
            {

                convertedVlaueTemp = (value / (5 / 9)) + 32;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                convertedVlaueTemp = (9 / 5) * (value - 273) + 32;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                convertedVlaueTemp = value;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double value = 0.0;
            if (txtDepth.Text == "")
                return;
            try
            {
                value = Convert.ToDouble(txtDepth.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Reservoir Depth Error: " + ee.Message);
                txtDepth.Text = String.Empty;
                txtDepth.Focus();
                comboBox2.SelectedIndex = 0;
            }
            if (comboBox2.SelectedIndex == 0)
            {
                convertedValueDepth = value;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                convertedValueDepth = value * 3.2808399;
            }

        }

        private void btnImport_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Import button is used o import the traning data in the format of .txt";
        }

        private void btnImport_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Cancel button is used to stop the training and to close the form.";
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void btnApply_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Apply button is used to start the training.";
        }

        private void btnApply_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "°F stands for Temperature in Farenheit. °K stands for Temperature in kelvin. °C stands for temperature in Celcius.";
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void comboBox2_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "ft stands for Depth in Feet. m stands for Depth in Meters.";
        }

        private void comboBox2_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

      

        
       

       

     
    }
}
