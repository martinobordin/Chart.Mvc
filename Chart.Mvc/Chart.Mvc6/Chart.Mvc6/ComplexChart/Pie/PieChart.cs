namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The pie chart.
    /// </summary>
    public class PieChart : ChartBase<PieChartOptions>
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
