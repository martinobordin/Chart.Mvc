namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The bar chart.
    /// </summary>
    public class BarChart : ComplexChartBase
    {
        private BarChartOptions chartOptions = new BarChartOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType
        {
            get
            {
                return ComplexChartType.Bar;
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
