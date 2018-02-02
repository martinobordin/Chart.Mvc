namespace Chart.Mvc
{
    using Chart.Mvc.Options;

    /// <summary>
    /// The global chart options.
    /// </summary>
    public abstract class GlobalChartOptions
    {
        /// <summary>
        /// Gets or sets the animation.
        /// </summary>
        /// <value>
        /// The animation.
        /// </value>
        public AnimationConfigurations Animation { get; set; }

        /// <summary>
        /// Gets or sets the layout.
        /// </summary>
        /// <value>
        /// The layout.
        /// </value>
        public LayoutConfigurations Layout { get; set; }

        /// <summary>
        /// Gets or sets the legend.
        /// </summary>
        /// <value>
        /// The legend.
        /// </value>
        public LegendConfigurations Legend { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public TitleConfigurations Title { get; set; }

        /// <summary>
        /// Gets or sets the tooltips.
        /// </summary>
        /// <value>
        /// The tooltips.
        /// </value>
        public TooltipConfigurations tooltips { get; set; }
    }
}
