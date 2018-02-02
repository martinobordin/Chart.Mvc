namespace Chart.Mvc.Options
{
    using System;

    public class LabelConfigurations
    {
        /// <summary>
        /// Gets or sets the width of the box.
        /// </summary>
        /// <value>
        /// The width of the box.
        /// </value>
        public double? BoxWidth { get; set; }

        /// <summary>
        /// Gets or sets the size of the font.
        /// </summary>
        /// <value>
        /// The size of the font.
        /// </value>
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        /// <value>
        /// The font style.
        /// </value>
        public string FontStyle { get; set; }

        /// <summary>
        /// Gets or sets the color of the font.
        /// </summary>
        /// <value>
        /// The color of the font.
        /// </value>
        public string FontColor { get; set; }

        /// <summary>
        /// Gets or sets the font family.
        /// </summary>
        /// <value>
        /// The font family.
        /// </value>
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        /// <value>
        /// The padding.
        /// </value>
        public double? Padding { get; set; }

        /// <summary>
        /// Gets or sets the generate labels.
        /// </summary>
        /// <value>
        /// The generate labels.
        /// </value>
        public string GenerateLabels { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets the use point style.
        /// </summary>
        /// <value>
        /// The use point style.
        /// </value>
        public bool? UsePointStyle { get; set; }
    }

    public class AnimationConfigurations
    {
        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public double? Duration { get; set; }

        /// <summary>
        /// Gets or sets the easing.
        /// </summary>
        /// <value>
        /// The easing.
        /// </value>
        public string Easing { get; set; }

        /// <summary>
        /// Gets or sets the on progress.
        /// </summary>
        /// <value>
        /// The on progress.
        /// </value>
        public string OnProgress { get; set; }

        /// <summary>
        /// Gets or sets the on complete.
        /// </summary>
        /// <value>
        /// The on complete.
        /// </value>
        public string OnComplete { get; set; }
    }

    public class LayoutConfigurations
    {
        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        /// <value>
        /// The padding.
        /// </value>
        public Padding Padding { get; set; }
    }

    public class LegendConfigurations
    {
        /// <summary>
        /// Gets or sets the display.
        /// </summary>
        /// <value>
        /// The display.
        /// </value>
        public bool? Display { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the full width.
        /// </summary>
        /// <value>
        /// The full width.
        /// </value>
        public bool? FullWidth { get; set; }

        /// <summary>
        /// Gets or sets the on click.
        /// </summary>
        /// <value>
        /// The on click.
        /// </value>
        public string OnClick { get; set; }

        /// <summary>
        /// Gets or sets the on hover.
        /// </summary>
        /// <value>
        /// The on hover.
        /// </value>
        public string OnHover { get; set; }

        /// <summary>
        /// Gets or sets the reverse.
        /// </summary>
        /// <value>
        /// The reverse.
        /// </value>
        public bool? Reverse { get; set; }

        public LabelConfigurations Labels { get; set; }
    }

    public class TitleConfigurations
    {
        /// <summary>
        /// Gets or sets the display.
        /// </summary>
        /// <value>
        /// The display.
        /// </value>
        public bool? Display { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the size of the font.
        /// </summary>
        /// <value>
        /// The size of the font.
        /// </value>
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets the font family.
        /// </summary>
        /// <value>
        /// The font family.
        /// </value>
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the color of the font.
        /// </summary>
        /// <value>
        /// The color of the font.
        /// </value>
        public string FontColor { get; set; }

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        /// <value>
        /// The font style.
        /// </value>
        public string FontStyle { get; set; }

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        /// <value>
        /// The padding.
        /// </value>
        public double? Padding { get; set; }

        /// <summary>
        /// Gets or sets the height of the line.
        /// </summary>
        /// <value>
        /// The height of the line.
        /// </value>
        public T1OrT2Value<double?, string> LineHeight { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public T1OrT2Value<string, string[]> Text { get; set; }
    }

    public class TooltipConfigurations
    {
        /// <summary>
        /// Gets or sets the enabled.
        /// </summary>
        /// <value>
        /// The enabled.
        /// </value>
        public bool? Enabled { get; set; }
        /// <summary>
        /// Gets or sets the custom.
        /// </summary>
        /// <value>
        /// The custom.
        /// </value>
        public string Custom { get; set; }
        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        public string Mode { get; set; }
        /// <summary>
        /// Gets or sets the intersect.
        /// </summary>
        /// <value>
        /// The intersect.
        /// </value>
        public bool? Intersect { get; set; }
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public string Position { get; set; }
        /// <summary>
        /// Gets or sets the callbacks.
        /// </summary>
        /// <value>
        /// The callbacks.
        /// </value>
        public string Callbacks { get; set; }
        /// <summary>
        /// Gets or sets the item sort.
        /// </summary>
        /// <value>
        /// The item sort.
        /// </value>
        public string ItemSort { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the title font family.
        /// </summary>
        /// <value>
        /// The title font family.
        /// </value>
        public String TitleFontFamily { get; set; }

        /// <summary>
        /// Gets or sets the size of the title font.
        /// </summary>
        /// <value>
        /// The size of the title font.
        /// </value>
        public double? TitleFontSize { get; set; }

        /// <summary>
        /// Gets or sets the title font style.
        /// </summary>
        /// <value>
        /// The title font style.
        /// </value>
        public string TitleFontStyle { get; set; }

        /// <summary>
        /// Gets or sets the color of the title font.
        /// </summary>
        /// <value>
        /// The color of the title font.
        /// </value>
        public string TitleFontColor { get; set; }

        /// <summary>
        /// Gets or sets the title spacing.
        /// </summary>
        /// <value>
        /// The title spacing.
        /// </value>
        public double? TitleSpacing { get; set; }

        /// <summary>
        /// Gets or sets the title margin bottom.
        /// </summary>
        /// <value>
        /// The title margin bottom.
        /// </value>
        public double? TitleMarginBottom { get; set; }

        /// <summary>
        /// Gets or sets the body font family.
        /// </summary>
        /// <value>
        /// The body font family.
        /// </value>
        public string BodyFontFamily { get; set; }

        /// <summary>
        /// Gets or sets the size of the body font.
        /// </summary>
        /// <value>
        /// The size of the body font.
        /// </value>
        public double? BodyFontSize { get; set; }

        /// <summary>
        /// Gets or sets the body font style.
        /// </summary>
        /// <value>
        /// The body font style.
        /// </value>
        public string BodyFontStyle { get; set; }

        /// <summary>
        /// Gets or sets the color of the body font.
        /// </summary>
        /// <value>
        /// The color of the body font.
        /// </value>
        public string BodyFontColor { get; set; }

        /// <summary>
        /// Gets or sets the body spacing.
        /// </summary>
        /// <value>
        /// The body spacing.
        /// </value>
        public double? BodySpacing { get; set; }

        /// <summary>
        /// Gets or sets the footer font family.
        /// </summary>
        /// <value>
        /// The footer font family.
        /// </value>
        public string FooterFontFamily { get; set; }

        /// <summary>
        /// Gets or sets the size of the footer font.
        /// </summary>
        /// <value>
        /// The size of the footer font.
        /// </value>
        public double? FooterFontSize { get; set; }

        /// <summary>
        /// Gets or sets the footer font style.
        /// </summary>
        /// <value>
        /// The footer font style.
        /// </value>
        public string FooterFontStyle { get; set; }

        /// <summary>
        /// Gets or sets the color of the footer font.
        /// </summary>
        /// <value>
        /// The color of the footer font.
        /// </value>
        public string FooterFontColor { get; set; }

        /// <summary>
        /// Gets or sets the footer spacing.
        /// </summary>
        /// <value>
        /// The footer spacing.
        /// </value>
        public double? FooterSpacing { get; set; }

        /// <summary>
        /// Gets or sets the footer margin top.
        /// </summary>
        /// <value>
        /// The footer margin top.
        /// </value>
        public double? FooterMarginTop { get; set; }

        /// <summary>
        /// Gets or sets the x padding.
        /// </summary>
        /// <value>
        /// The x padding.
        /// </value>
        public double? XPadding { get; set; }

        /// <summary>
        /// Gets or sets the y padding.
        /// </summary>
        /// <value>
        /// The y padding.
        /// </value>
        public double? YPadding { get; set; }

        /// <summary>
        /// Gets or sets the caret padding.
        /// </summary>
        /// <value>
        /// The caret padding.
        /// </value>
        public double? CaretPadding { get; set; }

        /// <summary>
        /// Gets or sets the size of the caret.
        /// </summary>
        /// <value>
        /// The size of the caret.
        /// </value>
        public double? CaretSize { get; set; }

        /// <summary>
        /// Gets or sets the corner radius.
        /// </summary>
        /// <value>
        /// The corner radius.
        /// </value>
        public double? CornerRadius { get; set; }

        /// <summary>
        /// Gets or sets the multi key background.
        /// </summary>
        /// <value>
        /// The multi key background.
        /// </value>
        public string MultiKeyBackground { get; set; }

        /// <summary>
        /// Gets or sets the display colors.
        /// </summary>
        /// <value>
        /// The display colors.
        /// </value>
        public bool? DisplayColors { get; set; }

        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>
        /// The color of the border.
        /// </value>
        public string BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the width of the border.
        /// </summary>
        /// <value>
        /// The width of the border.
        /// </value>
        public double? BorderWidth { get; set; }
    }
}
