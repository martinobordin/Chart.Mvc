namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The complex chart options.
    /// </summary>
    public abstract class ChartOptions : GlobalChartOptions
    {
        /// <summary>
        /// Gets or sets the legend template.
        /// </summary>
        public string LegendTemplate
        {
            get;
            set;
        }
    }
}
