namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The pie chart.
    /// </summary>
    public class PieChart : SimpleChartBase<PieChartOptions>
    {

        private readonly PieChartOptions chartOptions = new PieChartOptions();
        
        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override SimpleChartType ChartType
        {
            get
            {
                return SimpleChartType.Pie;
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
