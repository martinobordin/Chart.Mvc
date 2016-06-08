using System.Collections.Generic;

namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The simple chart base.
    /// </summary>
    public abstract class SimpleChartBase<TSimpleChartOptions> 
        where TSimpleChartOptions : SimpleChartOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleChartBase"/> class.
        /// </summary>
        protected SimpleChartBase()
        {
            this.Data = new List<SimpleData>();
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public List<SimpleData> Data
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public abstract SimpleChartType ChartType
        {
            get;
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public abstract TSimpleChartOptions ChartConfiguration
        {
            get;
        }
    }
}
