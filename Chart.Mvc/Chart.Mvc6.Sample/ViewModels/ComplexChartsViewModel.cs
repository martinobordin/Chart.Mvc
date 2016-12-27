using Chart.Mvc.Charts;

namespace Chart.Mvc6.Sample.ViewModels
{
    public class ComplexChartsViewModel
    {
        public LineChart LineChart { get; set; }
        public BarChart BarChart { get; set; }
        public RadarChart RadarChart { get; set; }
        public PolarAreaChart PolarAreaChart { get; set; }
        public PieChart PieChart { get; set; }
        public DoughnutChart DoughnutChart { get; set; }
    }
}
