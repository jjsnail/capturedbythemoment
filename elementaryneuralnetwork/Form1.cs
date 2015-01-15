// a simple scheme is attached

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simple
{
    public partial class Form1 : Form
    {
        const int LayerN = 3;
        const int WeightLayerN = LayerN - 1;

        double learningRate;
        int inputN;
        int outputN;
        int hiddenN;
        int patternN;
        double weightRange;

        List<double[]> neurons = new List<double[]>();
        List<double[,]> weights = new List<double[,]>();
        List<List<double[]>> patterns = new List<List<double[]>>();

        Random r = new Random();

        int iterationN;

        double[,] error;
        double[] errorsByCycles;

        public Form1()
        {
            InitializeComponent();
        }

        private void initAll()
        {
            neurons.Clear();
            weights.Clear();
            patterns.Clear();

            //input layer
            neurons.Add(new double[inputN]);
            //hidden layer
            neurons.Add(new double[hiddenN]);
            //output layer
            neurons.Add(new double[outputN]);

            // input layer - hidden layer
            weights.Add(new double[inputN, hiddenN]);
            // hidden leyer - output layer
            weights.Add(new double[hiddenN, outputN]);

            patterns.Add(new List<double[]>
            {
                new double[inputN],
                new double[outputN]
            }
            );
            patterns.Add(new List<double[]>
            {
                new double[inputN],
                new double[outputN]
            }
            );

            error = new double[patterns.Count, neurons.Last().Length];
            errorsByCycles = new double[iterationN];
        }

        private void getDataFromExample()
        {
            learningRate = 0.05;
            inputN = 2;
            outputN = 1;
            hiddenN = 2;
            patternN = 2;

            iterationN = 5000;

            initAll();

            patterns[0][0][0] = 0;
            patterns[0][0][1] = 1;
            patterns[0][1][0] = 0;

            patterns[1][0][0] = 1;
            patterns[1][0][1] = 1;
            patterns[1][1][0] = 1;

            weights[0][0, 0] = 0.62;
            weights[0][0, 1] = 0.42;
            weights[0][1, 0] = 0.55;
            weights[0][1, 1] = -0.17;

            weights[1][0, 0] = 0.35;
            weights[1][1, 0] = 0.81;

        }

        private void getUserData()
        {
            learningRate = Double.Parse(tbLR.Text);
            inputN = Int32.Parse(tbINA.Text);
            outputN = Int32.Parse(tbONA.Text);
            hiddenN = Int32.Parse(tbHNA.Text);
            patternN = Int32.Parse(tbPA.Text);

            iterationN = Int32.Parse(tbIA.Text);

            weightRange = Double.Parse(tbWVR.Text);

            initAll();

            fillByRandom();
        }

        private void fillByRandom()
        {
            for (int patternI = 0; patternI < patternN; patternI++)
            {
                for (int i = 0; i < inputN; i++)
                {
                    patterns[patternI][0][i] = r.NextDouble() > 0.5 ? 1.0 : 0;
                }
                for (int i = 0; i < outputN; i++)
                {
                    patterns[patternI][1][i] = r.NextDouble() > 0.5 ? 1.0 : 0;
                }
            }
            for (int currNeuronLayerI = 0; currNeuronLayerI < inputN; currNeuronLayerI++)
            {
                for (int nextNeuronLayerI = 0; nextNeuronLayerI < hiddenN; nextNeuronLayerI++)
                {
                    weights[0][currNeuronLayerI, nextNeuronLayerI] = r.NextDouble() * weightRange * (r.NextDouble() < 0.5 ? -1.0 : 1.0);
                }
            }

            for (int currNeuronLayerI = 0; currNeuronLayerI < hiddenN; currNeuronLayerI++)
            {
                for (int nextNeuronLayerI = 0; nextNeuronLayerI < outputN; nextNeuronLayerI++)
                {
                    weights[1][currNeuronLayerI, nextNeuronLayerI] = r.NextDouble() * weightRange * (r.NextDouble() < 0.5 ? -1.0 : 1.0);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                chartError.Series.First().Points.Clear();
                getUserData();
                // getDataFromExample();

                for (int cycle = 0; cycle < iterationN; cycle++)
                {
                    for (int patternI = 0; patternI < patterns.Count; patternI++)
                    {
                        // fill input values
                        for (int i = 0; i < inputN; i++)
                        {
                            neurons[0][i] = patterns[patternI][0][i];
                        }

                        // count output values for neurons for each next layer
                        for (int layerI = 0; layerI < neurons.Count - 1; layerI++)
                        {
                            for (int nextLayerI = 0; nextLayerI < neurons[layerI + 1].Length; nextLayerI++)
                            {
                                double summ = 0;
                                for (int inputI = 0; inputI < neurons[layerI].Length; inputI++)
                                {
                                    summ += neurons[layerI][inputI] * weights[layerI][inputI, nextLayerI];
                                }
                                neurons[layerI + 1][nextLayerI] = 1 / (1 + Math.Exp(-summ));
                            }
                        }

                        // compute error
                        int lastLayerL = neurons[neurons.Count - 1].Length;

                        for (int outputNeuronI = 0; outputNeuronI < lastLayerL; outputNeuronI++)
                        {
                            error[patternI, outputNeuronI] = patterns[patternI][1][outputNeuronI] - neurons[neurons.Count - 1][outputNeuronI];
                        }

                        // do backpropagation
                        for (int layerI = neurons.Count - 1; layerI > 0; layerI--)
                        {
                            for (int outputNeuronI = 0; outputNeuronI < lastLayerL; outputNeuronI++)
                            {
                                for (int neuronI = 0; neuronI < neurons[layerI].Length; neuronI++)
                                {
                                    for (int previousNeuronI = 0; previousNeuronI < neurons[layerI - 1].Length; previousNeuronI++)
                                    {
                                        double currW = weights[layerI - 1][previousNeuronI, neuronI];
                                        double currLR = learningRate;
                                        double currErr = error[patternI, outputNeuronI];
                                        double currPrev = neurons[layerI - 1][previousNeuronI];
                                        double currCurr = neurons[layerI][neuronI];

                                        weights[layerI - 1][previousNeuronI, neuronI] += learningRate * error[patternI, outputNeuronI] * neurons[layerI - 1][previousNeuronI] *
                                            neurons[layerI][neuronI] * (1 - neurons[layerI][neuronI]);
                                    }
                                }
                            }
                        }
                    }

                    double summErrorAllOutputs = 0;
                    for (int patternI = 0; patternI < patterns.Count; patternI++)
                    {
                        double summError = 0;
                        for (int outputNeuronI = 0; outputNeuronI < neurons[neurons.Count - 1].Length; outputNeuronI++)
                        {
                            summError += Math.Pow(error[patternI, outputNeuronI], 2.0);
                        }
                        summErrorAllOutputs += summError;
                    }
                    errorsByCycles[cycle] = summErrorAllOutputs;
                }

                // add to chart
                for (int iter = 0; iter < errorsByCycles.Length; iter++)
                {
                    chartError.Series.First().Points.AddXY(iter, errorsByCycles[iter]);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Smth wrong");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbLR.Text = (0.25).ToString();
        }
    }
}
