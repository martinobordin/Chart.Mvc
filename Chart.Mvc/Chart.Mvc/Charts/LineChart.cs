namespace Chart.Mvc.Charts
{
    using System;

    /// <summary>
    /// The line chart
    /// </summary>
    public class LineChart : BaseChart<LineChartData, LineChartOptions>
    {
        /// <summary>
        /// Gets the type of the chart.
        /// </summary>
        /// <value>
        /// The type of the chart.
        /// </value>
        public override ChartType ChartType => ChartType.Line;
    }

    public class LineChartData
    {
        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public string[] Labels { get; set; }

        /// <summary>
        /// Gets or sets the datasets.
        /// </summary>
        /// <value>
        /// The datasets.
        /// </value>
        public LineChartDataSet[] Datasets { get; set; }
    }

    public class LineChartDataSet
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public T1OrT2Value<double?, double?[]> Data { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Labels { get; set; }

        /// <summary>
        /// Gets or sets the x axis identifier.
        /// </summary>
        /// <value>
        /// The x axis identifier.
        /// </value>
        public string XAxisId { get; set; }

        /// <summary>
        /// Gets or sets the y axis identifier.
        /// </summary>
        /// <value>
        /// The y axis identifier.
        /// </value>
        public string YAxisId { get; set; }

        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        public string BackgroundColor { get; set; }

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

        /// <summary>
        /// Gets or sets the border dash.
        /// </summary>
        /// <value>
        /// The border dash.
        /// </value>
        public double?[] BorderDash { get; set; }

        /// <summary>
        /// Gets or sets the border dash offset.
        /// </summary>
        /// <value>
        /// The border dash offset.
        /// </value>
        public double BorderDashOffset { get; set; }

        /// <summary>
        /// Gets or sets the border cap style.
        /// </summary>
        /// <value>
        /// The border cap style.
        /// </value>
        public string BorderCapStyle { get; set; }

        /// <summary>
        /// Gets or sets the border join style.
        /// </summary>
        /// <value>
        /// The border join style.
        /// </value>
        public string BorderJoinStyle { get; set; }

        /// <summary>
        /// Gets or sets the cubic interpolation mode.
        /// </summary>
        /// <value>
        /// The cubic interpolation mode.
        /// </value>
        public string CubicInterpolationMode { get; set; }
        

        /// <summary>
        /// Gets or sets the fill.
        /// </summary>
        /// <value>
        /// The fill.
        /// </value>
        public T1OrT2Value<bool?, string> Fill { get; set; }

        /// <summary>
        /// Gets or sets the line tension.
        /// </summary>
        /// <value>
        /// The line tension.
        /// </value>
        public double? LineTension { get; set; }

        /// <summary>
        /// Gets or sets the color of the point background.
        /// </summary>
        /// <value>
        /// The color of the point background.
        /// </value>
        public T1OrT2Value<string, string[]> PointBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the point border.
        /// </summary>
        /// <value>
        /// The color of the point border.
        /// </value>
        public T1OrT2Value<string, string[]> PointBorderColor { get; set; }

        /// <summary>
        /// Gets or sets the width of the point border.
        /// </summary>
        /// <value>
        /// The width of the point border.
        /// </value>
        public T1OrT2Value<double?, double?[]> PointBorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the point radius.
        /// </summary>
        /// <value>
        /// The point radius.
        /// </value>
        public T1OrT2Value<double?, double?[]> PointRadius { get; set; }

        /// <summary>
        /// Gets or sets the point style.
        /// </summary>
        /// <value>
        /// The point style.
        /// </value>
        public T1OrT2Value<string, string[]> PointStyle { get; set; }

        /// <summary>
        /// Gets or sets the point hit radius.
        /// </summary>
        /// <value>
        /// The point hit radius.
        /// </value>
        public T1OrT2Value<double?, double?[]> PointHitRadius { get; set; }

        /// <summary>
        /// Gets or sets the color of the point hover background.
        /// </summary>
        /// <value>
        /// The color of the point hover background.
        /// </value>
        public T1OrT2Value<string, string[]> PointHoverBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the point hover border.
        /// </summary>
        /// <value>
        /// The color of the point hover border.
        /// </value>
        public T1OrT2Value<string, string[]> PointHoverBorderColor { get; set; }

        /// <summary>
        /// Gets or sets the width of the point hover border.
        /// </summary>
        /// <value>
        /// The width of the point hover border.
        /// </value>
        public T1OrT2Value<double?, double?[]> PointHoverBorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the point hover radius.
        /// </summary>
        /// <value>
        /// The point hover radius.
        /// </value>
        public T1OrT2Value<double?, double?[]> PointHoverRadius { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show line].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show line]; otherwise, <c>false</c>.
        /// </value>
        public bool? ShowLine { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [span gaps].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [span gaps]; otherwise, <c>false</c>.
        /// </value>
        public bool? SpanGaps { get; set; }

        /// <summary>
        /// Gets or sets the stepped line.
        /// </summary>
        /// <value>
        /// The stepped line.
        /// </value>
        public T1OrT2Value<bool?, string> SteppedLine { get; set; }
    }

    public class LineChartOptions : GlobalChartOptions
    {
        /// <summary>
        /// Gets or sets the show lines.
        /// </summary>
        /// <value>
        /// The show lines.
        /// </value>
        public bool? ShowLines { get; set; }

        /// <summary>
        /// Gets or sets the span gaps.
        /// </summary>
        /// <value>
        /// The span gaps.
        /// </value>
        public bool? SpanGaps { get; set; }
        
    }
}
