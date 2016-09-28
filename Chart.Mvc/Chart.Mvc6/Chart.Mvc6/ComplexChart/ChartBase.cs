namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The chart base.
    /// </summary>
    public abstract class ChartBase<TChartOptions> 
        where TChartOptions : ChartOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexChartBase"/> class.
        /// </summary>
        protected ChartBase()
        {
            this.ComplexData = new ComplexData();
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public ComplexData ComplexData
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public abstract ComplexChartType ChartType
        {
            get;
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public abstract TChartOptions ChartConfiguration
        {
            get;
        }
    }
}