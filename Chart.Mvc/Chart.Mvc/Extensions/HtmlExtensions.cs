namespace Chart.Mvc.Extensions
{
    using System.Text;
    using System.Web.Mvc;

    using Chart.Mvc.Charts;

    /// <summary>
    /// The html extensions.
    /// </summary>
    public static class HtmlExtensions
    {
        public static MvcHtmlString DebugChart(this HtmlHelper htmlHelper, string canvasId, LineChartData dataSet, LineChartOptions options = null)
        {
            var chart = new LineChart { Data = dataSet, Options = options };
            return CreateDebugChart(canvasId, chart);
        }

        public static MvcHtmlString LineChart(this HtmlHelper htmlHelper, string canvasId, LineChartData dataSet, LineChartOptions options = null)
        {
            var chart = new LineChart { Data = dataSet, Options = options };
            return CreateChart(canvasId, chart);
        }

        /////// <summary>
        /////// The create chart.
        /////// </summary>
        /////// <param name="htmlHelper">
        /////// The html helper.
        /////// </param>
        /////// <param name="canvasId">
        /////// The canvas id.
        /////// </param>
        /////// <param name="complexChart">
        /////// The complex chart.
        /////// </param>
        /////// <returns>
        /////// The <see cref="MvcHtmlString"/>.
        /////// </returns>
        ////public static MvcHtmlString CreateChart<TComplexChartOptions>(this HtmlHelper htmlHelper, string canvasId, ComplexChartBase<TComplexChartOptions> complexChart) where TComplexChartOptions : ComplexChartOptions
        ////{
        ////    return CreateChart(canvasId, complexChart.ChartType.ToString(), complexChart.ComplexData.ToJson(), complexChart.ChartConfiguration.ToJson());
        ////}

        /////// <summary>
        /////// The create chart.
        /////// </summary>
        /////// <param name="htmlHelper">
        /////// The html helper.
        /////// </param>
        /////// <param name="canvasId">
        /////// The canvas id.
        /////// </param>
        /////// <param name="simpleChart">
        /////// The simple chart.
        /////// </param>
        /////// <returns>
        /////// The <see cref="MvcHtmlString"/>.
        /////// </returns>
        ////public static MvcHtmlString CreateChart<TSimpleChartOptions>(this HtmlHelper htmlHelper, string canvasId, SimpleChartBase<TSimpleChartOptions> simpleChart) where TSimpleChartOptions : SimpleChartOptions
        ////{
        ////    return CreateChart(canvasId, simpleChart.ChartType.ToString(), simpleChart.Data.ToJson(), simpleChart.ChartConfiguration.ToJson());
        ////}

        /// <summary>
        /// Creates the chart.
        /// </summary>
        /// <typeparam name="TChartData">The type of the chart data.</typeparam>
        /// <typeparam name="TChartOptions">The type of the chart options.</typeparam>
        /// <param name="canvasId">The canvas identifier.</param>
        /// <param name="chart">The chart.</param>
        /// <returns></returns>
        private static MvcHtmlString CreateChart<TChartData, TChartOptions>(string canvasId, BaseChart<TChartData, TChartOptions> chart)
        {
            var tag = new TagBuilder("script");
            tag.Attributes.Add("type", "text/javascript");
            tag.InnerHtml = BuildChartScript(canvasId, chart);
            return new MvcHtmlString(tag.ToString());
        }

        private static MvcHtmlString CreateDebugChart<TChartData, TChartOptions>(string canvasId, BaseChart<TChartData, TChartOptions> chart)
        {
            var tag = new TagBuilder("div")
                          {
                              InnerHtml = BuildChartScript(canvasId, chart)
                          };
            return new MvcHtmlString(tag.ToString());
        }

        private static string BuildChartScript<TChartData, TChartOptions>(string canvasId, BaseChart<TChartData, TChartOptions> chart)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"var ctx = document.getElementById(\"{canvasId}\").getContext(\"2d\");");
            stringBuilder.Append($"var data = JSON.parse('{chart.Data.ToJson()}');");
            stringBuilder.Append($"var options = JSON.parse('{chart.Options.ToJson()}');");
            stringBuilder.Append($"var {canvasId}_chart = new Chart(ctx, {{ type: '{chart.ChartType.ToString().ToLower()}', data: data, options: options}})");
            return stringBuilder.ToString();
        }
    }
}
