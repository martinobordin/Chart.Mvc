namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The line chart options.
    /// </summary>
    public class LineChartOptions  : ChartOptions
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
        /// Gets or sets the bezier curve.
        /// </summary>
        public bool? BezierCurve
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the bezier curve tension.
        /// </summary>
        public double? BezierCurveTension
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the point dot.
        /// </summary>
        public bool? PointDot
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the point dot radius.
        /// </summary>
        public double? PointDotRadius
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the point dot stroke width.
        /// </summary>
        public double? PointDotStrokeWidth
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the point hit detection radius.
        /// </summary>
        public double? PointHitDetectionRadius
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the dataset stroke.
        /// </summary>
        public bool? DatasetStroke
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the dataset stroke width.
        /// </summary>
        public double? DatasetStrokeWidth
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the dataset fill.
        /// </summary>
        public bool? DatasetFill
        {
            get; 
            set;
        }
    }
}
