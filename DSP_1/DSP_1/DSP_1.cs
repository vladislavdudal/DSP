using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace trDSP
{
    public partial class DSP_1 : Form
    {
        System.Windows.Forms.DataVisualization.Charting.Series Graph;
       
        public DSP_1()
        {
            InitializeComponent();
            comboBoxN.SelectedIndex = 0;
            comboBoxSignal.SelectedIndex = 0;
        }

        private void BuildHarmGraph()
        {
            chart.Series.Remove(Graph);
            Graph = new System.Windows.Forms.DataVisualization.Charting.Series();
            Graph.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            Graph.Color = Color.Green;

            int N = int.Parse(comboBoxN.SelectedItem.ToString());

            double A = Convert.ToDouble(textBoxA.Text);
            double f = Convert.ToDouble(textBoxF.Text);
            double phi = Convert.ToDouble(textBoxFi.Text);

            if (comboBoxSignal.SelectedIndex == 0)
            {
                for (int n = 1; n <= N - 1; n++)
                {
                    Graph.Points.AddXY(n, A * Math.Sin(2 * Math.PI * f * n / N + Math.PI * (double)phi / 180));
                }
            }
            else if (comboBoxSignal.SelectedIndex == 1)
            {
                for (int n = 1; n <= N - 1; n++)
                {
                    var sum = 0.0;
                    for (int j = 1; j < 125; j++)
                    {
                        sum += Math.Sin(j * 2 * Math.PI * f / N * n) / j;
                    }
                    var y = A / 2 - A / Math.PI * sum;
                    Graph.Points.AddXY(n, y);
                }
            }
            else if (comboBoxSignal.SelectedIndex == 2)
            {
                for (int n = 0; n < N; n++)
                {
                    var sum = 0.0;
                    for (int j = 1; j < 125; j += 2)
                    {
                        sum += Math.Pow(-1, (j - 1) / 2) * Math.Sin(j * 2 * Math.PI * f / N * n) / (j * j);
                    }
                    var y = 8 * A / Math.PI / Math.PI * sum;
                    Graph.Points.AddXY(n, y);
                }
            }
            else
            {
                for (int n = 1; n <= N - 1; n++)
                {
                    if (n % 8 == 0)
                    {
                        Graph.Points.AddXY(n, A * Math.Sin(2 * Math.PI * f * n / N + Math.PI * (double)phi / 180));
                    }
                }
            }
                
            chart.ChartAreas[0].AxisY.Maximum = 25;
            chart.ChartAreas[0].AxisY.Minimum = -25;
            chart.Series.Add(Graph);
        }

        private void BuildPolyHarmGraph(object sender, EventArgs e)
        {
            chart.Series.Remove(Graph);

            double[] phc = new double[15];
            phc[0] = Convert.ToDouble(textBoxFi1.Text); 
            phc[1] = Convert.ToDouble(textBoxF1.Text);
            phc[2] = Convert.ToDouble(textBoxA1.Text);
            phc[3] = Convert.ToDouble(textBoxFi2.Text);
            phc[4] = Convert.ToDouble(textBoxF2.Text);
            phc[5] = Convert.ToDouble(textBoxA2.Text);
            phc[6] = Convert.ToDouble(textBoxFi3.Text);
            phc[7] = Convert.ToDouble(textBoxF3.Text);
            phc[8] = Convert.ToDouble(textBoxA3.Text);
            phc[9] = Convert.ToDouble(textBoxFi4.Text);
            phc[10] = Convert.ToDouble(textBoxF4.Text);
            phc[11] = Convert.ToDouble(textBoxA4.Text);
            phc[12] = Convert.ToDouble(textBoxFi5.Text);
            phc[13] = Convert.ToDouble(textBoxF5.Text);
            phc[14] = Convert.ToDouble(textBoxA5.Text);

            Graph = new System.Windows.Forms.DataVisualization.Charting.Series();
            Graph.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            Graph.Color = Color.OrangeRed;

            int N = int.Parse(comboBoxN.SelectedItem.ToString());
            if (comboBoxSignal.SelectedIndex == 0)
            {
                for (int n = 1; n <= N - 1; n++)
                {
                    double res = 0;
                    for (int k = 0; k <= 4; k++)
                    {
                        double t = (3 * phc[k * 3 + 2]) * Math.Sin(2 * Math.PI * (3 * phc[k * 3 + 1]) * n / N + (double)(3 * phc[k * 3]) / 180 * Math.PI);
                        res += t;
                    }
                    Graph.Points.AddXY(n, res);
                }
            }
            else if (comboBoxSignal.SelectedIndex == 1)
            {
                for (int n = 1; n <= N - 1; n++)
                {
                    double res = 0;
                    for (int k = 0; k <= 4; k++)
                    {
                        var sum = 0.0;
                        for (int j = 1; j < 125; j++)
                        {
                            sum += Math.Sin(j * 2 * Math.PI * (3 * phc[k * 3 + 1]) / N * n) / j;
                        }

                        var t = (3 * phc[k * 3 + 2]) / 2 - (3 * phc[k * 3 + 2]) / Math.PI * sum;
                        res += t;
                    }
                    Graph.Points.AddXY(n, res);
                }
            }
            else
            {
                for (int n = 1; n <= N - 1; n++)
                {
                    double res = 0;
                    for (int k = 0; k <= 4; k++)
                    {
                        var sum = 0.0;
                        for (int j = 1; j < 125; j++)
                        {
                            sum += Math.Pow(-1, (j - 1) / 2) * Math.Sin(j * 2 * Math.PI * (3 * phc[k * 3 + 1]) / N * n) / (j * j);
                        }
                        var t = 8 * (3 * phc[k * 3 + 2]) / Math.PI / Math.PI * sum;
                        res += t;
                    }
                    Graph.Points.AddXY(n, res);
                }
            }

            chart.ChartAreas[0].AxisY.Maximum = 500;
            chart.ChartAreas[0].AxisY.Minimum = -500;
            chart.Series.Add(Graph);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonHarm.Checked)
            {
                BuildHarmGraph();
            }
            else BuildPolyHarmGraph(sender, e);
        }
    }
}
