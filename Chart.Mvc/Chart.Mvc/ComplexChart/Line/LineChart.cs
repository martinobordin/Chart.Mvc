namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The line chart.
    /// </summary>
    public class LineChart : ComplexChartBase
    {
        private LineChartOptions chartOptions = new LineChartOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType
        {
            get
            {
                return ComplexChartType.Line;
            }
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override ComplexChartOptions ChartConfiguration
        {
            get
            {
                return chartOptions;
            }
        }
    }
}