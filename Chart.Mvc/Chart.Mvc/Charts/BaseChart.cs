namespace Chart.Mvc.Charts
{
    public abstract class BaseChart<TChartData, TChartOptions>
    {
        /// <summary>
        /// Gets the type of the chart.
        /// </summary>
        /// <value>
        /// The type of the chart.
        /// </value>
        public abstract ChartType ChartType { get; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public TChartData Data { get; set; }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public TChartOptions Options { get; set; }
    }
}