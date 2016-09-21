using Chart.Mvc.ComplexChart;

namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The polar area chart.
    /// </summary>
    public class PolarAreaChart : ComplexChartBase<PolarAreaOptions>
    {

        private readonly PolarAreaOptions chartOptions = new PolarAreaOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType
        {
            get
            {
                return ComplexChartType.PolarArea;
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
