namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The bar chart.
    /// </summary>
    public class BarChart : ComplexChartBase
    {
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
                return new BarChartOptions();
            }
        }
    }
}