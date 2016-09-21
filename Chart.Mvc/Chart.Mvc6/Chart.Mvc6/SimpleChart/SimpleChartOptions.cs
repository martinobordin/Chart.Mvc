namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The simple chart options.
    /// </summary>
    public abstract class SimpleChartOptions : GlobalChartOptions
    {
        /// <summary>
        /// Gets or sets the segment show stroke.
        /// </summary>
        public bool? SegmentShowStroke
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the segment stroke width.
        /// </summary>
        public double? SegmentStrokeWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the animate rotate.
        /// </summary>
        public bool? AnimateRotate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the animate scale.
        /// </summary>
        public bool? AnimateScale
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the legend template.
        /// </summary>
        public string LegendTemplate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the segment stroke color.
        /// </summary>
        public string SegmentStrokeColor
        {
            get;
            set;
        }
    }
}
