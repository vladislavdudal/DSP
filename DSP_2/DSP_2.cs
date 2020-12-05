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
    public partial class DSP_2 : Form
    {
        public DSP_2()
        {
            InitializeComponent();
        }

        private void displayGraph()
        {
            int N = 512;
            int K = Convert.ToInt32(textBoxK.Text);
            int phi = Convert.ToInt32(textBoxF.Text);

            chart.Series.Clear();

            System.Windows.Forms.DataVisualization.Charting.Series graph_1;
            System.Windows.Forms.DataVisualization.Charting.Series graph_2;

            graph_1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            graph_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            graph_1.Color = Color.Green;

            graph_2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            graph_2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            graph_2.Color = Color.OrangeRed;

            double sum_1;
            double sum_2;
            double x;
            double skz_1;
            double skz_2;

            for (int i = K; i <= 2 * N; i++)
            {
                sum_1 = 0;
                sum_2 = 0;

                for (int n = 0; n <= i; n++)
                {
                    x = Math.Sin(2 * Math.PI * n / N + (double)phi / 180 * Math.PI);
                    sum_1 += Math.Pow(x, 2);
                    sum_2 += x;
                }

                skz_1 = Math.Sqrt(sum_1 / (i + 1));
                skz_2 = Math.Sqrt(sum_1 / (i + 1) - Math.Pow(sum_2 / (i + 1), 2));

                graph_1.Points.AddXY(i, 0.707 - skz_1);
                graph_2.Points.AddXY(i, 0.707 - skz_2);
            }
                           
            chart.ResetAutoValues();
            chart.Series.Add(graph_1);
            chart.Series.Add(graph_2);
        }

        private void btnCalc(object sender, EventArgs e)
        {
            displayGraph();
        }

        private void keyPressM(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar !=8) {
                e.Handled = true;
            }
        }

        private void keyPressF(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
