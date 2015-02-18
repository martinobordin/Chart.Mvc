namespace Chart.Mvc
{
    /// <summary>
    /// The global chart options.
    /// </summary>
    public abstract class GlobalChartOptions
    {
        /// <summary>
        /// Gets or sets whether to animate the chart.
        /// </summary>
        public bool? Animation
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the number of animation steps.
        /// </summary>
        public double? AnimationSteps
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the animation easing effect.
        /// </summary>
        public string AnimationEasing
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if we should show the scale at all.
        /// </summary>
        public bool? ShowScale
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if we want to override with a hard coded scale.
        /// </summary>
        public bool? ScaleOverride
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the number of steps in a hard coded scale.
        /// </summary>
        public double? ScaleSteps
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the value jump in the hard coded scale.
        /// </summary>
        public double? ScaleStepWidth
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the scale starting value.
        /// </summary>
        public double? ScaleStartValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the color of the scale line.
        /// </summary>
        public string ScaleLineColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pixel width of the scale line.
        /// </summary>
        public double? ScaleLineWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether to show labels on the scale.
        /// </summary>
        public bool? ScaleShowLabels
        {
            get;
            set;
        }

        /////// <summary>
        /////// Gets or sets the scale label. Interpolated JS string - can access value.
        /////// </summary>
        ////public string ScaleLabel
        ////{
        ////    get; 
        ////    set;
        ////}

        /// <summary>
        /// Gets or sets whether the scale should stick to integers, not floats even if drawing space is there.
        /// </summary>
        public bool? ScaleIntegersOnly
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets whether the scale should start at zero, or an order of magnitude down from the lowest value.
        /// </summary>
        public bool? ScaleBeginAtZero
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scale label font declaration for the scale label.
        /// </summary>
        public string ScaleFontFamily
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the scale label font size in pixels.
        /// </summary>
        public double? ScaleFontSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scale label font weight style.
        /// </summary>
        public string ScaleFontStyle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scale label font color.
        /// </summary>
        public string ScaleFontColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether or not the chart should be responsive and resize when the browser does.
        /// </summary>
        public bool? Responsive
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container.
        /// </summary>
        public bool? MaintainAspectRatio
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether to draw tooltips on the canvas or not.
        /// </summary>
        public bool? ShowTooltips
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets whether to execute the customTooltips function instead of drawing the built in tooltips.
        /// </summary>
        public bool? CustomTooltips
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets array of string names to attach tooltip events.
        /// </summary>
        public string TooltipEvents
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip background color.
        /// </summary>
        public string TooltipFillColor
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip label font declaration for the scale label.
        /// </summary>
        public string TooltipFontFamily
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip label font size in pixels.
        /// </summary>
        public double? TooltipFontSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip font weight style.
        /// </summary>
        public string TooltipFontStyle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip label font colour.
        /// </summary>
        public string TooltipFontColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip title font declaration for the scale label.
        /// </summary>
        public string TooltipTitleFontFamily
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip title font size in pixels.
        /// </summary>
        public double? TooltipTitleFontSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip title font weight style.
        /// </summary>
        public string TooltipTitleFontStyle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip title font colour.
        /// </summary>
        public string TooltipTitleFontColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pixel width of padding around tooltip text.
        /// </summary>
        public double? TooltipYPadding
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the pixel width of padding around tooltip text.
        /// </summary>
        public double? TooltipXPadding
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the size of the caret on the tooltip.
        /// </summary>
        public double? TooltipCaretSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pixel radius of the tooltip border.
        /// </summary>
        public double? TooltipCornerRadius
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the tooltip x offset.
        /// </summary>
        public double? TooltipXOffset
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the template string for single tooltips.
        /// </summary>
        public string TooltipTemplate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the multi tooltip template.
        /// </summary>
        public string MultiTooltipTemplate
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the function that will fire on animation progression..
        /// </summary>
        public string OnAnimationProgress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the function that will fire on animation completion.
        /// </summary>
        public string OnAnimationComplete
        {
            get; 
            set;
        }
    }
}
