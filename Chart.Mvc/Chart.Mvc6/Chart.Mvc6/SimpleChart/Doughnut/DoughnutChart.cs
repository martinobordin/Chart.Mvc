namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The doughnut chart.
    /// </summary>
    public class DoughnutChart : SimpleChartBase<DoughnutChartOptions>
    {
        private readonly DoughnutChartOptions chartOptions = new DoughnutChartOptions();
        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override SimpleChartType ChartType
        {
            get
            {
                return SimpleChartType.Doughnut;
            }
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override DoughnutChartOptions ChartConfiguration
        {
            get
            {
                return chartOptions;
            }
        }
    }
}
