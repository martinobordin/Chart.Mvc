namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The radar chart.
    /// </summary>
    public class RadarChart : ChartBase<RadarChartOptions>
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
        public override RadarChartOptions ChartConfiguration
        {
            get
            {
                return chartOptions;
            }
        }
    }
}
