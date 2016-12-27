using Microsoft.AspNetCore.Mvc;
using Chart.Mvc.Charts;
using Chart.Mvc6.Sample.ViewModels;
using Chart.Mvc.Sample.Models;

namespace Chart.Mvc6.Sample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ComplexChartsViewModel model = new ComplexChartsViewModel();
            model.LineChart = this.GetLineChart();
            model.BarChart = this.GetBarChart();
            model.RadarChart = this.GetRadarChart();
            model.PolarAreaChart = this.GetPolarAreaChart();
            model.PieChart = this.GetPieChart();
            model.DoughnutChart = this.GetDoughnutChart();

            return View(model);
        }

        private LineChart GetLineChart()
        {
            var chart = new LineChart();
            chart.ComplexData.Labels.AddRange(FakeComplexChartData.Labels);
            chart.ComplexData.Datasets.AddRange(FakeComplexChartData.Datasets);

            return chart;
        }

        private BarChart GetBarChart()
        {
            var chart = new BarChart();
            chart.ComplexData.Labels.AddRange(FakeComplexChartData.Labels);
            chart.ComplexData.Datasets.AddRange(FakeComplexChartData.Datasets);

            return chart;
        }

        private RadarChart GetRadarChart()
        {
            var chart = new RadarChart();
            chart.ComplexData.Labels.AddRange(FakeComplexChartData.Labels);
            chart.ComplexData.Datasets.AddRange(FakeComplexChartData.Datasets);

            return chart;
        }

        private PolarAreaChart GetPolarAreaChart()
        {
            var chart = new PolarAreaChart();
            chart.ComplexData.Labels.AddRange(FakeComplexChartData.Labels);
            chart.ComplexData.Datasets.AddRange(FakeComplexChartData.Datasets);

            return chart;
        }

        private PieChart GetPieChart()
        {
            var chart = new PieChart();
            chart.ComplexData.Labels.AddRange(FakeComplexChartData.Labels);
            chart.ComplexData.Datasets.AddRange(FakeComplexChartData.Datasets);

            return chart;
        }

        private DoughnutChart GetDoughnutChart()
        {
            var chart = new DoughnutChart();
            chart.ComplexData.Labels.AddRange(FakeComplexChartData.Labels);
            chart.ComplexData.Datasets.AddRange(FakeComplexChartData.Datasets);

            return chart;
        }
    }
}
