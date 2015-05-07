using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace EOR
{
    class NeuralNetwork
    {
        // Number of neurons in the Input Layer
        public int numInput;
        // Number of neurons in the First Hidden Layer
        protected int numHidden1;
        // Number of neurons in the Second Hidden Layer
        protected int numHidden2;
        // Number of neurons in the Output Layer 
        public int numOutput;
        // Total number of weights
        public int numWeight;
        // Input Array to store input values
        protected double[] inputValues;
        
        
        // INPUT TO HIDDEN-ONE
        //Input to hidden1 weight array 
        protected double[,] ih1Weights;
        //Input to hidden1 bias weights array
        protected double[] ih1Bias;
        //Input to hidden1 weighted sum array
        protected double[] ih1Sums;
        //Input to hidden1 output array
        protected double[] ih1Output;

        // HIDDEN-ONE TO HIDDEN-TWO
        //Hidden1 to Hidden2 weight array
        protected double[,] h1h2Weights;
        //Hidden1 to Hidden2 bias weights array
        protected double[] h1h2Bias;
        //Hidden1 to Hidden2 weighted sum array
        protected double[] h1h2Sums;
        //Hidden1 to Hidden2 output array
        protected double[] h1h2Output;

        //HIDDEN-TWO TO OUTPUT
        //Hidden2 to Output weight array
        protected double[,] h2OWeights;
        //Hidden2 to Output bias weights array
        protected double[] h2OBias;
        //Hidden2 to Output weighted sum array
        protected double[] h2OSums;
        //Hidden2 to Output output array
        protected double[] output;
        
        //Constructor to initialize the values
        public NeuralNetwork(int numInput, int numHidden1, int numHidden2, int numOutput)
        {
            this.numInput = numInput;
            this.numHidden1 = numHidden1;
            this.numHidden2 = numHidden2;
            this.numOutput = numOutput;

            inputValues = new double[numInput];

            ih1Weights = new double[numInput, numHidden1];     
            ih1Bias = new double[numHidden1];
            ih1Sums = new double[numHidden1];
            ih1Output = new double[numHidden1];

            h1h2Weights = new double[numHidden1, numHidden2];   
            h1h2Bias = new double[numHidden2];
            h1h2Sums = new double[numHidden2];
            h1h2Output = new double[numHidden2];

            h2OWeights = new double[numHidden2, numOutput];     
            h2OBias = new double[numOutput];
            h2OSums = new double[numOutput];
            output = new double[numOutput];
            
        }

        //Method to read the weights from a file 
        public double[] ReadWeights()
        {
            String line="";
            numWeight = (numInput * numHidden1) + (numHidden1 * numHidden2) + (numHidden2 * numOutput) 
                + numHidden1 + numHidden2 + numOutput;
            double[] result = new double[numWeight];
            using (StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\weights.txt"))
            {
                line = reader.ReadToEnd();
                if (line != null)
                {
                    for (int i = 0; i < numWeight; i++)
                    {
                        String[] value = line.Split(',');
                        result[i] = Convert.ToDouble(value[i]);
                    }
                }
            }

            return result;
        }

        //Method is used to save weights to a file
        public void SaveWeights(double[] weights)
        {
            using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\weights.txt"))
            {
                foreach (var value in weights)
                {
                    writer.Write(value + ",");
                }
            }
        }
        // Method is used to set the weights of different weight and bias array
        public void SetWeight(double[] randWeights)
        {
            // Total number of weights
             numWeight = (numInput * numHidden1) + (numHidden1 * numHidden2) + (numHidden2 * numOutput) 
                + numHidden1 + numHidden2 + numOutput;
             try
             {
                 if (numWeight != randWeights.Length)
                     System.Windows.Forms.MessageBox.Show("Length of weight array " + randWeights.Length + " does not match total number of weights and biases " + numWeight);

             }
             catch
             { }
            int k = 0;
            //randWeights = new double[numWeight];
            //setting weights of Input to Hidden-one layer
            for (int i = 0; i < numInput; i++)
            {
                for (int j = 0; j < numHidden1; j++)
                    ih1Weights[i, j] = randWeights[k++];
            }

            //setting bias weights of Input to hidden-one layer
            for (int i = 0; i < numHidden1; i++)
                ih1Bias[i] = randWeights[k++];

            //setting weights of Hidden-one to Hidden-two layer 
            for (int i = 0; i < numHidden1; i++)
            {
                for (int j = 0; j < numHidden2; j++)
                    h1h2Weights[i, j] = randWeights[k++];
            }

            //setting bias weights of Hidden-one to Hidden-two layer
            for (int i = 0; i < numHidden2; i++)
                h1h2Bias[i] = randWeights[k++];

            //setting weights of Hidden-two to Output layer
            for (int i = 0; i < numHidden2; i++)
            {
                for (int j = 0; j < numOutput; j++)
                    h2OWeights[i, j] = randWeights[k++];
            }

            //setting bias weights of Hidden-two to Output layer
            for (int i = 0; i < numOutput; i++)
                h2OBias[i] = randWeights[k++];
        }


        //Function to Compute the values of the output layer of the Neural Network
        public double[] ComputeOutput(double[] inputValuesUser)
        {
            if (numInput != inputValuesUser.Length)
                throw new Exception("Error in the Input Values");

            //Initializing each neuron weighted sum to zero
            //Neurons of the Hidden-one Layer
            for (int i = 0; i < numHidden1; i++)
                ih1Sums[i] = 0;
            
            //Neurons of the Hidden-two Layer
            for (int i = 0; i < numHidden2; i++)
                h1h2Sums[i] = 0;

            //Neurons of the Output layer
            for (int i = 0; i < numOutput; i++)
                h2OSums[i] = 0;

            //Passing thw Input Values entered by the user in the InputValues array
            for (int i = 0; i < inputValuesUser.Length; i++)
               this.inputValues[i] = inputValuesUser[i];

            // INPUT TO HIDDEN LAYER ONE CALCULATION
            // input to hidden1 weighted sum
            for (int j = 0; j < numHidden1; j++)
            {
                for (int i = 0; i < numInput; i++)
                    ih1Sums[j] += this.inputValues[i] * ih1Weights[i, j];
            }

            // Add the bias weights in the weighted sum
            for (int i = 0; i < numHidden1; i++)
                ih1Sums[i] += ih1Bias[i];

            // Pass the calculated weighted sum to the Activation function 
            for(int i=0;i<numHidden1;i++)
            ih1Output[i]= SigmoidFunction(ih1Sums[i]);

            // HIDDEN LAYER ONE TO HIDDEN LAYER TWO CALCULATION
            // hidden1 to hidden2 weighted sum
            for (int j = 0; j < numHidden2; j++)
            {
                for (int i = 0; i < numHidden1; i++)
                    h1h2Sums[j] += ih1Output[i] * h1h2Weights[i, j];
            }

            //Add the bias weights in the weighted sum
            for(int i=0;i<numHidden2;i++)
                h1h2Sums[i]+= h1h2Bias[i];
            
            // Pass the calculated weighted sum to the Activation function

            for (int i = 0; i < numHidden2; i++)
                h1h2Output[i] = HyperTanFunction(h1h2Sums[i]);

            //HIDDEN LAYER TWO TO OUTPUT LAYER CALCULATION
            //hidden2 to output weighted sum
            for (int j = 0; j < numOutput; j++)
            {
                for (int i = 0; i < numHidden2; i++)
                    h2OSums[j] += h1h2Output[i] * h2OWeights[i, j];
            }

            //Add the bias weights in the weighted sum
            for (int i = 0; i < numOutput; i++)
                h2OSums[i] += h2OBias[i];

            //Pass the calculated weighted sum to the Activation function
            for(int i=0; i<numOutput; i++)
                output[i] = SigmoidFunction(h2OSums[i]);

            return output;
        }

        // Method to calculate the error
        public double CalculateError(double[] output, double[] targetOutput)
        {
            double sum = 0.0;
            for (int i = 0; i < targetOutput.Length; i++)
            {
                sum += Math.Abs(targetOutput[i] - output[i]);
            }
            return sum;
        }

        // Method returns the index of the output array which has the highest value
        public int IndexOfLargest(double[] vector)
        {
            int indexOfLargest = 0;
            double maxVal = vector[0];
            for (int i = 0; i < vector.Length; ++i)
            {
                if (vector[i] > maxVal)
                {
                    maxVal = vector[i];
                    indexOfLargest = i;
                }
            }
            return indexOfLargest;
        }

        // Method to Normalize the input data
        public double[] NormalizeInput(double ip1, double ip2, double ip3, double ip4, double ip5, double ip6, double ip7)
        {
            double[] result = new double[numInput];
            double maxPorosity = 65.0;
            double minPorosity = 0.0;
            double maxDepth = 13750.0;
            double minDepth = 0.0;
            double maxTemp = 290.0;
            double minTemp = 0.0;
            double maxPermeability = 11500.0;
            double minPermeability = 0.0;
            double maxOilSaturation = 98.0;
            double minOilSaturation = 0.0;
            double maxOilGravity = 57.0;
            double minOilGravity = 0.0;
            double maxOilViscosity = 200000.0;
            double minOilViscosity = 0.0;

            double NormalizedPorosity;
            double NormalizedDepth;
            double NormalizedTemp;
            double NormalizedPermeability;
            double NormalizedOilSaturation;
            double NormalizedOilGravity;
            double NormalizedOilViscosity;

            int k = 0;

            NormalizedPorosity = (ip1 - minPorosity) / (maxPorosity - minPorosity);
            result[k++] = NormalizedPorosity;

            NormalizedPermeability = (ip2 - minPermeability) / (maxPermeability - minPermeability);
            result[k++] = NormalizedPermeability;

            NormalizedTemp = (ip3 - minTemp) / (maxTemp - minTemp);
            result[k++] = NormalizedTemp;

            NormalizedDepth = (ip4 - minDepth) / (maxDepth - minDepth);
            result[k++] = NormalizedDepth;

            NormalizedOilGravity = (ip5 - minOilGravity) / (maxOilGravity - minOilGravity);
            result[k++] = NormalizedOilGravity;

            NormalizedOilViscosity = (ip6 - minOilViscosity) / (maxOilViscosity - minOilViscosity);
            result[k++] = NormalizedOilViscosity;

            NormalizedOilSaturation = (ip7 - minOilSaturation) / (maxOilSaturation - minOilSaturation);
            result[k++] = NormalizedOilSaturation;

            return result;

        }


        // ACTIVATION FUNCTIONS
        // Activation Function gives the output in the range [0,1]
        private static double SigmoidFunction(double x)
        {
            if (x < -25)
                return 0.0;
            else if (x > 25)
                return 1.0;
            else
                return 1.0 / (1 + Math.Exp(-x));

        }

        // Activation function gives the output in the range [-1,1]
        private static double HyperTanFunction(double x)
        {
            if (x < -25)
                return -1;
            else if (x > 25)
                return 1;
            else
                return Math.Tanh(x);
        }

    }
}
