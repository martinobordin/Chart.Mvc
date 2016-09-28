namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The bar chart options.
    /// </summary>
    public class BarChartOptions : ChartOptions
    {
        /// <summary>
        /// Gets or sets the scale show grid lines.
        /// </summary>
        public bool? ScaleShowGridLines
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scale grid line color.
        /// </summary>
        public string ScaleGridLineColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scale grid line width.
        /// </summary>
        public double? ScaleGridLineWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scale show horizontal lines.
        /// </summary>
        public bool? ScaleShowHorizontalLines
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scale show vertical lines.
        /// </summary>
        public bool? ScaleShowVerticalLines
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the bar show stroke.
        /// </summary>
        public bool? BarShowStroke
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the bar stroke width.
        /// </summary>
        public double? BarStrokeWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the bar value spacing.
        /// </summary>
        public double? BarValueSpacing
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the bar dataset spacing.
        /// </summary>
        public double? BarDatasetSpacing
        {
            get;
            set;
        }
    }
}
