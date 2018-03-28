﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();

        }

        void drawGraph(List<Point> points, string XAxisTitle = "x", string YAxisTitle = "y")
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            Series series1 = new Series
            {
                Name = "Line",
                Color = Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2
            };
            Series series2 = new Series
            {
                Name = "Points",
                Color = Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Point,
                BorderWidth = 2
            };
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            foreach (Point p in points)
            {
                series1.Points.AddXY(p.X, p.Y);
                series2.Points.AddXY(p.X, p.Y);
            }
            chart1.ChartAreas[0].AxisX.Title = XAxisTitle;
            chart1.ChartAreas[0].AxisY.Title = YAxisTitle;
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void yxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Point> linear = new List<Point>();
            for (int i = 0; i < 11; i++)
            {
                linear.Add(new Point(i, i));
            }
            drawGraph(linear);
        }

        private void yxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Point> squares = new List<Point>();
            for (int i = 0; i < 11; i++)
            {
                squares.Add(new Point(i, i * i));
            }
            drawGraph(squares);
        }

        private void yxToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            List<Point> cubes = new List<Point>();
            for (int i = 0; i < 11; i++)
            {
                cubes.Add(new Point(i, i * i * i));
            }
            drawGraph(cubes);
        }
    }
}
