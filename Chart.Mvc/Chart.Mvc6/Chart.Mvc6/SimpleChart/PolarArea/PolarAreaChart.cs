namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The polar area chart.
    /// </summary>
    public class PolarAreaChart : SimpleChartBase<PolarAreaOptions>
    {

        private readonly PolarAreaOptions chartOptions = new PolarAreaOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override SimpleChartType ChartType
        {
            get
            {
                return SimpleChartType.PolarArea;
            }
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override PolarAreaOptions ChartConfiguration
        {
            get
            {
                return chartOptions;
            }
        }
    }
}
