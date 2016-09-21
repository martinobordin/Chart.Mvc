using Chart.Mvc.ComplexChart;
using Chart.Mvc.SimpleChart;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chart.Mvc.Extensions;

namespace Chart.Mvc6.TagHelpers
{
    public class LineChartTagHelper : TagHelper
    {
        public LineChart Chart { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var chartData = this.GetChartData();
            string canvasId = "chartCanvas";
            string canvasHtml = "<canvas id='" + canvasId +"' width='" + Width + "' height='" + Height + "'></canvas>";
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("<script type='text/javascript'>");
            stringBuilder.AppendFormat("var ctx = document.getElementById(\"{0}\").getContext(\"2d\");", canvasId);
            stringBuilder.AppendFormat("var data = JSON.parse('{0}');", chartData.Item1);
            stringBuilder.AppendFormat("var options = JSON.parse('{0}');", chartData.Item2);
            stringBuilder.Append("var " + canvasId + "_chart = new Chart(ctx)." + chartData.Item3 + "(data, options);");
            stringBuilder.Append("</script>");  

            output.Content.SetHtmlContent(canvasHtml + stringBuilder.ToString());
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
