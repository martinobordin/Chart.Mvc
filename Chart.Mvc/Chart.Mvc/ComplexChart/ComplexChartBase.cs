namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The complex chart base.
    /// </summary>
    public abstract class ComplexChartBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexChartBase"/> class.
        /// </summary>
        protected ComplexChartBase()
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
        public abstract ComplexChartOptions ChartConfiguration
        {
            get;
        }
    }
}