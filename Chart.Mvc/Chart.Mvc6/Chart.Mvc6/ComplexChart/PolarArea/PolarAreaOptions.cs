namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The polar area options.
    /// </summary>
    public class PolarAreaOptions : ChartOptions
    {
        /// <summary>
        /// Gets or sets the scale show label backdrop.
        /// </summary>
        public bool? ScaleShowLabelBackdrop
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the scale backdrop color.
        /// </summary>
        public string ScaleBackdropColor
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the scale backdrop padding y.
        /// </summary>
        public double? ScaleBackdropPaddingY
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the scale backdrop padding x.
        /// </summary>
        public double? ScaleBackdropPaddingX
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

        
    }
}
