namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The pie chart.
    /// </summary>
    public class PieChart : ComplexChartBase<PieChartOptions>
    {

        private readonly PieChartOptions chartOptions = new PieChartOptions();
        
        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType
        {
            get
            {
                return ComplexChartType.Pie;
            }
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override PieChartOptions ChartConfiguration
        {
            get
            {
                return chartOptions;
            }
        }
    }
}
