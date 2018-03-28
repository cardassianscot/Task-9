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

        class PointD
        {
            public double X;
            public double Y;

            public PointD(double x,double y)
            {
                X = x;
                Y = y;
            }
        }

        void drawGraph(List<Point> points, string XAxisTitle = "x", string YAxisTitle = "y", bool PlotPoints = true)
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
            if (PlotPoints)
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

        void drawGraphDouble(List<PointD> points, string XAxisTitle = "x", string YAxisTitle = "y", bool PlotPoints = true)
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
            if (PlotPoints)
                chart1.Series.Add(series2);
            foreach (PointD p in points)
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

        private void sinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PointD> sines = new List<PointD>();
            for (double i = 0; i < 361; i++)
            {
                sines.Add(new PointD(i, sin(i)));
            }
            drawGraphDouble(sines, "θ", "sin θ", false);
        }

        private double sin(double θ)
        {
            return Math.Sin(θ * Math.PI / 180.0);
        }

        private double cos(double θ)
        {
            return Math.Cos(θ * Math.PI / 180.0);
        }

        private double tan(double θ)
        {
            return Math.Tan(θ * Math.PI / 180.0);
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PointD> cosines = new List<PointD>();
            for (double i = 0; i < 361; i++)
            {
                cosines.Add(new PointD(i, cos(i)));
            }
            drawGraphDouble(cosines, "θ", "cos θ", false);
        }

        private void tanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PointD> tans = new List<PointD>();
            for (double i = 0; i < 361; i++)
            {
                if (Math.Abs(tan(i))<10.0)
                    tans.Add(new PointD(i, tan(i)));
            }
            drawGraphDouble(tans, "θ", "tan θ", false);
            
        }
    }
}
