namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The radar chart.
    /// </summary>
    public class RadarChart : ComplexChartBase
    {
        private readonly RadarChartOptions chartOptions = new RadarChartOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType
        {
            get
            {
                return ComplexChartType.Radar;
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
