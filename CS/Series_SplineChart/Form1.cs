using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_SplineChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl splineChart = new ChartControl();

            // Create a spline series.
            Series series1 = new Series("Series 1", ViewType.Spline);

            // Add points to it.
            series1.Points.Add(new SeriesPoint(1, 3));
            series1.Points.Add(new SeriesPoint(2, 12));
            series1.Points.Add(new SeriesPoint(3, 4));
            series1.Points.Add(new SeriesPoint(4, 17));
            series1.Points.Add(new SeriesPoint(5, 3));
            series1.Points.Add(new SeriesPoint(6, 12));
            series1.Points.Add(new SeriesPoint(7, 4));
            series1.Points.Add(new SeriesPoint(8, 17));

            // Add the series to the chart.
            splineChart.Series.Add(series1);

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((SplineSeriesView)series1.View).LineTensionPercent = 90;

            // Access the type-specific options of the diagram.
            ((XYDiagram)splineChart.Diagram).Rotated = true;

            // Hide the legend (if necessary).
            splineChart.Legend.Visibility =  DevExpress.Utils.DefaultBoolean.False;

            // Add a title to the chart (if necessary).
            splineChart.Titles.Add(new ChartTitle());
            splineChart.Titles[0].Text = "A Spline Chart";

            // Add the chart to the form.
            splineChart.Dock = DockStyle.Fill;
            this.Controls.Add(splineChart);
        }

    }
}