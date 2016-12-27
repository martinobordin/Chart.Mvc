using Chart.Mvc.Charts;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Text;
using System.Threading.Tasks;
using Chart.Mvc.Extensions;

namespace Chart.Mvc6.TagHelpers
{
    public abstract class ChartTagHelperBase<TChartOptions> : TagHelper
        where TChartOptions : ChartOptions
    {
        public string Canvas { get; set; }
        public ChartBase<TChartOptions> Chart { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var chartData = this.GetChartData();
            //string canvasId = "chartCanvas_" + Guid.NewGuid().ToString().Replace("-", "");
            //string canvasHtml = "<canvas id='" + canvasId + "' width='" + Width + "' height='" + Height + "'></canvas>";
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("<script type='text/javascript'>");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.AppendFormat("var ctx = document.getElementById(\"{0}\").getContext(\"2d\");", Canvas);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.AppendFormat("var data = JSON.parse('{0}');", chartData.Item1);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.AppendFormat("var options = JSON.parse('{0}');", chartData.Item2);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("var " + Canvas + "_chart = new Chart(ctx, { type:'" + chartData.Item3.ToCamelCase() + "', data: data, options: options });");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("</script>");

            return Task.FromResult(output.Content.SetHtmlContent(stringBuilder.ToString()));
        }

        private Tuple<string, string, string> GetChartData()
        {
            string chartType = this.Chart.ChartType.ToString();
            string jsonData = this.Chart.ComplexData.ToJson();
            string jsonOptions = this.Chart.ChartConfiguration.ToJson();

            return new Tuple<string, string, string>(jsonData, jsonOptions, chartType);
        }
    }
}
