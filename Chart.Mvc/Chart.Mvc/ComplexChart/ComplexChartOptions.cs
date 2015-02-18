namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The complex chart options.
    /// </summary>
    public abstract class ComplexChartOptions : GlobalChartOptions
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
