namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The radar chart options.
    /// </summary>
    public class RadarChartOptions : ComplexChartOptions
    {
        /// <summary>
        /// Gets or sets the angle line color.
        /// </summary>
        public string AngleLineColor
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the angle show line out.
        /// </summary>
        public bool? AngleShowLineOut
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the scale show line.
        /// </summary>
        public bool? ScaleShowLine
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the angle line width.
        /// </summary>
        public double? AngleLineWidth
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the point label font family.
        /// </summary>
        public string PointLabelFontFamily
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the point label font style.
        /// </summary>
        public string PointLabelFontStyle
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the point label font size.
        /// </summary>
        public double? PointLabelFontSize
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the point label font color.
        /// </summary>
        public string PointLabelFontColor
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
