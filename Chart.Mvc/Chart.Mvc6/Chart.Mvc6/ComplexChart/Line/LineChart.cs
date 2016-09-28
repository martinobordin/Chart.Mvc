namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The line chart.
    /// </summary>
    public class LineChart : ChartBase<LineChartOptions>
    {
        private readonly LineChartOptions chartOptions = new LineChartOptions();

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
        public override LineChartOptions ChartConfiguration
        {
            get
            {
                return chartOptions;
            }
        }
    }
}