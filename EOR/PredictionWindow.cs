using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection; 

namespace EOR
{
    public partial class PredictionWindow : Form
    {
        double convertedVlaueTemp = 0.0;
        double convertedValueDepth = 0.0;
        String path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

        public PredictionWindow()
        {
            
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            double userInputDepth = 0.0;
            double userInputTemperature = 0.0;
            double userInputPorosity=0.0;
            double userInputPermeability = 0.0;
            double userInputOilGravity = 0.0;
            double userInputOilViscosity = 0.0;
            double userInputOilSaturation = 0.0;
            double[] userInput;
            double[] computedOutput;
            double[] weights;
            

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
            }
            catch (Exception ee)
            {
                MessageBox.Show("Porosity Error :" + ee.Message);
                txtPorosity.Focus();
                txtPorosity.Text = String.Empty;
                return;
            }

            try
            {
                userInputPermeability = Convert.ToDouble(txtPermeability.Text);
                if (userInputPermeability < 0.0 || userInputPermeability > 11500)
                {
                    MessageBox.Show("Permeability value is not valid. Please check your input value");
                    txtPermeability.Focus();
                    txtPermeability.Text = String.Empty;
                    return;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Permeability Error :" + ee.Message);
                txtPermeability.Focus();
                txtPermeability.Text = String.Empty;
                return;
            }

            try
            {
                if (convertedVlaueTemp == 0)
                    userInputTemperature =Convert.ToDouble(txtTemp.Text);
                   
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
            }
            catch (Exception ee)
            {
                MessageBox.Show("Temperature Error :" + ee.Message);
                txtTemp.Focus();
                txtTemp.Text = String.Empty;
                comboBox1.SelectedIndex = 0;
                convertedVlaueTemp = 0;
                return;
            }

            try
            {
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
            }

            catch (Exception ee)
            {
                MessageBox.Show("Reservoir Depth Error :" + ee.Message);
                txtDepth.Focus();
                txtDepth.Text = String.Empty;
                comboBox2.SelectedIndex = 0;
                convertedValueDepth = 0;
                return;
            }

            try
            {
                userInputOilGravity = Convert.ToDouble(txtGravity.Text);
                if (userInputOilGravity < 0.0 || userInputOilGravity > 57)
                {
                    MessageBox.Show("Oil Gravity value is not valid. Please check your input value");
                    txtGravity.Focus();
                    txtGravity.Text = String.Empty;
                    return;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Oil Gravity Error :" + ee.Message);
                txtGravity.Focus();
                txtGravity.Text = String.Empty;
                return;
            }

            try
            {
                userInputOilViscosity = Convert.ToDouble(txtViscosity.Text);
                if (userInputOilViscosity < 0.0 || userInputOilViscosity > 200000)
                {
                    MessageBox.Show("Oil viscosity value is not valid. Please check your input value");
                    txtViscosity.Focus();
                    txtViscosity.Text = String.Empty;
                    return;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Oil Viscosity Error :" + ee.Message);
                txtViscosity.Focus();
                txtViscosity.Text = String.Empty;
                return;
            }

            try
            {
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
                MessageBox.Show("Initial Oil Saturation Error :" + ee.Message);
                txtOilSaturation.Focus();
                txtOilSaturation.Text = String.Empty;
                return;
            }
               


            NeuralNetwork neuralNetwork = new NeuralNetwork(7, 10, 8, 5);
            userInput = neuralNetwork.NormalizeInput(userInputPorosity, userInputPermeability, userInputTemperature, userInputDepth, userInputOilGravity, userInputOilViscosity, userInputOilSaturation);

            weights = neuralNetwork.ReadWeights();
            neuralNetwork.SetWeight(weights);

            computedOutput = neuralNetwork.ComputeOutput(userInput);

            int index = neuralNetwork.IndexOfLargest(computedOutput);
            if (index == 0)
            {
                lblSteam.BackColor = Color.Lime;
                lblHydroCarbon.BackColor = Color.Red;
                lblInSitu.BackColor = Color.Red;
                lblPolymer.BackColor = Color.Red;
                lblCo2Miscible.BackColor = Color.Red;

                btnsteamEconomic.Enabled = true;

            }

            if (index == 1)
            {
                lblCo2Miscible.BackColor = Color.Lime;
                lblSteam.BackColor = Color.Red;
                lblHydroCarbon.BackColor = Color.Red;
                lblInSitu.BackColor = Color.Red;
                lblPolymer.BackColor = Color.Red;

                btnCo2Economic.Enabled = true;
            }

            if (index == 2)
            {
                lblHydroCarbon.BackColor = Color.Lime;
                lblInSitu.BackColor = Color.Red;
                lblPolymer.BackColor = Color.Red;
                lblCo2Miscible.BackColor = Color.Red;
                lblSteam.BackColor = Color.Red;

               btnHydroEconomic.Enabled = true;
            }

            if (index == 3)
            {
                lblHydroCarbon.BackColor = Color.Red;
                lblInSitu.BackColor = Color.Lime;
                lblPolymer.BackColor = Color.Red;
                lblCo2Miscible.BackColor = Color.Red;
                lblSteam.BackColor = Color.Red;

                 btnInsituEconomic.Enabled = true;
            }

            if (index == 4)
            {
                lblHydroCarbon.BackColor = Color.Red;
                lblInSitu.BackColor = Color.Red;
                lblPolymer.BackColor = Color.Lime;
                lblCo2Miscible.BackColor = Color.Red;
                lblSteam.BackColor = Color.Red;

                btnPolymerEconomic.Enabled = true;
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

     

        private void btnsteamEconomic_Click(object sender, EventArgs e)
        {
            try
            {
                if (path.Substring(0, 4) == "file")
                {
                    string newpath = path.Substring(6);
                    newpath.Trim();
                    path = newpath;
                }
                File.Delete(path + @"\Steam.xlsx");
                File.Copy(path + @"\Steam_o.xlsx", path + @"\Steam.xlsx");
                Excel.Application excelApp = new Excel.ApplicationClass();
                excelApp.Workbooks.Open(path + @"\Steam.xlsx");
                excelApp.Visible = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnCo2Economic_Click(object sender, EventArgs e)
        {
            try
            {
                if (path.Substring(0, 4) == "file")
                {
                    string newpath = path.Substring(6);
                    newpath.Trim();
                    path = newpath;
                }
                File.Delete(path + @"\CO2.xlsx");
                File.Copy(path + @"\CO2_o.xlsx", path + @"\CO2.xlsx");
                Excel.Application excelApp = new Excel.ApplicationClass();
                excelApp.Workbooks.Open(path + @"\CO2.xlsx");
                excelApp.Visible = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnHydroEconomic_Click(object sender, EventArgs e)
        {
            try
            {
                if (path.Substring(0, 4) == "file")
                {
                    string newpath = path.Substring(6);
                    newpath.Trim();
                    path = newpath;
                }
                File.Delete(path + @"\hyadrocarbon.xlsx");
                File.Copy(path + @"\hyadrocarbon_o.xlsx", path + @"\hyadrocarbon.xlsx");
                Excel.Application excelApp = new Excel.ApplicationClass();
                excelApp.Workbooks.Open(path + @"\hyadrocarbon.xlsx");
                excelApp.Visible = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            
        }

        private void btnInsituEconomic_Click(object sender, EventArgs e)
        {
            try
            {
                if (path.Substring(0, 4) == "file")
                {
                    string newpath = path.Substring(6);
                    newpath.Trim();
                    path = newpath;
                }
                File.Delete(path + @"\In_situ_combustion.xlsx");
                File.Copy(path + @"\In_situ_combustion_o.xlsx", path + @"\In_situ_combustion.xlsx");
                Excel.Application excelApp = new Excel.ApplicationClass();
                excelApp.Workbooks.Open(path + @"\In_situ_combustion.xlsx");
                excelApp.Visible = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnPolymerEconomic_Click(object sender, EventArgs e)
        {
            try
            {
                if (path.Substring(0, 4) == "file")
                {
                    string newpath = path.Substring(6);
                    newpath.Trim();
                    path = newpath;
                }
                File.Delete(path + @"\Polymer.xlsx");
                File.Copy(path + @"\Polymer_o.xlsx", path + @"\Polymer.xlsx");
                Excel.Application excelApp = new Excel.ApplicationClass();
                excelApp.Workbooks.Open(path + @"\Polymer.xlsx");
                excelApp.Visible = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDepth.Text = String.Empty;
            txtGravity.Text = String.Empty;
            txtOilSaturation.Text= String.Empty;
            txtPermeability.Text = String.Empty;
            txtPorosity.Text = String.Empty;
            txtTemp.Text = String.Empty;
            txtViscosity.Text = String.Empty;
            
            btnCo2Economic.Enabled = false;
            btnHydroEconomic.Enabled = false;
            btnInsituEconomic.Enabled = false;
            btnPolymerEconomic.Enabled = false;
            btnsteamEconomic.Enabled = false;

            lblCo2Miscible.BackColor = SystemColors.Control;
            lblHydroCarbon.BackColor = SystemColors.Control;
            lblInSitu.BackColor = SystemColors.Control;
            lblPolymer.BackColor = SystemColors.Control;
            lblSteam.BackColor = SystemColors.Control;

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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
                MessageBox.Show("Temperature Error :"+ee.Message);
                txtTemp.Text =String.Empty;
                txtTemp.Focus();
                comboBox1.SelectedIndex = 0;
            }
            if (comboBox1.SelectedIndex==2)
            {
                
                convertedVlaueTemp = (value / (5 / 9)) + 32; 
            }
            if (comboBox1.SelectedIndex==1)
            {
                convertedVlaueTemp = (9 / 5)*(value - 273) + 32;
            }
            if (comboBox1.SelectedIndex==0)
            {
                convertedVlaueTemp = value;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double value=0.0;
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
            if (comboBox2.SelectedIndex==0)
            {
                convertedValueDepth = value;
            }
            if (comboBox2.SelectedIndex==1)
            {
                convertedValueDepth = value * 3.2808399;
            }
        }

        private void btnApply_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "Apply button is used to start the prediction.";
        }

        private void btnApply_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "cancel button is used to reset the controls.";
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            txtinstanthelp.Text = String.Empty;
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            txtinstanthelp.Text = "°F stands for Temperature in Farenheit. °K stands for Temperature in kelvin. °C stands for temperature in Celcius.";
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
