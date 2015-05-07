using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EOR
{

    class BackPropogation : NeuralNetwork
    {
      
        // Array to store the output gradient
        private double[] oGradient;
        //Array to store the second hidden layer gradient
        private double[] h2Gradient;
        //Array to store the second hidden layer gradient
        private double[] h1Gradient;

        private double[,] ih1PrevWeightDelta;
        private double[] ih1PrevbiasDelta;
        private double[,] h1h2PrevWeightDelta;
        private double[] h1h2PrevbiasDelta;
        private double[,] h2oPrevWeightDelta;
        private double[] h2oPrevBiasDelta;

        public BackPropogation()
            : base(7, 10, 8, 5)
        {
            
            oGradient = new double[numOutput];
            h2Gradient = new double[numHidden2];
            h1Gradient = new double[numHidden1];

            ih1PrevWeightDelta = new double[numInput, numHidden1];
            ih1PrevbiasDelta = new double[numHidden1];

            h1h2PrevWeightDelta = new double[numHidden1, numHidden2];
            h1h2PrevbiasDelta = new double[numHidden2];

            h2oPrevWeightDelta = new double[numHidden2, numOutput];
            h2oPrevBiasDelta = new double[numOutput];
        }

        // Method to update the weights
        // tvalues is the array of desired output or target output
        // eta is the value of learning rate
        // alpha is the value of momentum
        public void UpdateWeights(double[] tValues, double eta, double alpha)
        {
            //1. Compute Output gradient
            for (int i = 0; i < oGradient.Length; i++)
            {
                double derivative = (1 - output[i]) * output[i];
                oGradient[i] = (tValues[i] - output[i]) * derivative;
            }

            //2. Compute Second Hidden layer Gradient
            for (int i = 0; i < h2Gradient.Length; i++)
            {
                double derivative = (1 - h1h2Output[i]) * (1 + h1h2Output[i]);
                double sum = 0.0;
                for (int j = 0; j < numOutput; j++)
                    sum += oGradient[j] * h2OWeights[i, j];
                h2Gradient[i] = derivative * sum;
            }

            //3. compute first hidden layer gradient
            for (int i = 0; i < h1Gradient.Length; i++)
            {
                double derivative = (1 - ih1Output[i]) * ih1Output[i];
                double sum = 0.0;
                for (int j = 0; j < numHidden2; j++)
                    sum += h2Gradient[j] * h1h2Weights[i, j];
                h1Gradient[i] = derivative * sum;
            }

            // UPDATE WEIGHTS
            // Update input to hidden-one weights
            for (int i = 0; i < numInput; i++)
            {
                for (int j = 0; j < numHidden1; j++)
                {
                    double delta = eta * h1Gradient[j] * inputValues[i];
                    ih1Weights[i, j] += delta;   //updating weight with delta
                    ih1Weights[i, j] += alpha * ih1PrevWeightDelta[i, j];   //Adding a momentum term
                    ih1PrevWeightDelta[i, j] = delta;   //storing the previous value of delta
                }
            }
            
            //update input to hidden-one bias
            for (int i = 0; i < numHidden1; i++)
            {
                double delta = eta * h1Gradient[i] * 1.0;
                ih1Bias[i] += delta;
                ih1Bias[i] += alpha * ih1PrevbiasDelta[i];
                ih1PrevbiasDelta[i] = delta;
            }

            //update hidden-one to hidden-two weights
            for (int i = 0; i < numHidden1; i++)
            {
                for (int j = 0; j < numHidden2; j++)
                {
                    double delta = eta * h2Gradient[j] * ih1Output[i];
                    h1h2Weights[i, j] += delta;
                    h1h2Weights[i, j] += alpha * h1h2PrevWeightDelta[i, j];
                    h1h2PrevWeightDelta[i, j] = delta;
                }
            }

            //update hidden-one to hidden-two bias
            for (int i = 0; i < numHidden2; i++)
            {
                double delta = eta * h2Gradient[i] * 1.0;
                h1h2Bias[i] += delta;
                h1h2Bias[i] += alpha * h1h2PrevbiasDelta[i];
                h1h2PrevbiasDelta[i] = delta;
            }

            //update hidden-two to output weights
            for (int i = 0; i < numHidden2; i++)
            {
                for (int j = 0; j < numOutput; j++)
                {
                    double delta = eta * oGradient[j] * h1h2Output[i];
                    h2OWeights[i, j] += delta;
                    h2OWeights[i, j] += alpha * h2oPrevWeightDelta[i, j];
                    h2oPrevWeightDelta[i, j] = delta;
                }
            }

            // Update hidden-two to output bias
            for (int i = 0; i < numOutput; i++)
            {
                double delta = eta * oGradient[i] * 1.0;
                h2OBias[i] += delta;
                h2OBias[i] += alpha * h2oPrevBiasDelta[i];
                h2oPrevBiasDelta[i] = delta;
            }
        }

        public double[] GetWeights()
        {
            int numofWeight;
            numofWeight = ((numInput * numHidden1) + (numHidden1 * numHidden2) + (numHidden2 * numOutput) + numHidden1 + numHidden2 + numOutput);

            double[] result = new double[numofWeight];

            int k = 0;
            for (int i = 0; i < numInput; i++)
            {
                for (int j = 0; j < numHidden1; j++)
                    result[k++] = ih1Weights[i, j];        
            }

            for (int i = 0; i < numHidden1; i++)
                result[k++] = ih1Bias[i];

            for (int i = 0; i < numHidden1; i++)
            {
                for (int j = 0; j < numHidden2; j++)
                    result[k++] = h1h2Weights[i, j];
            }

            for (int i = 0; i < numHidden2; i++)
                result[k++] = h1h2Bias[i];

            for (int i = 0; i < numHidden2; i++)
            {
                for (int j = 0; j < numOutput; j++)
                    result[k++] = h2OWeights[i, j];
            }

            for (int i = 0; i < numOutput; i++)
                result[k++] = h2OBias[i];

            return result;
        }


    }
}
