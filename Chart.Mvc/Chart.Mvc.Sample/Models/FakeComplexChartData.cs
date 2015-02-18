using System.Collections.Generic;
using Chart.Mvc.ComplexChart;

namespace Chart.Mvc.Sample.Models
{
    public static class FakeComplexChartData
    {
        public static IEnumerable<string> Labels
        {
            get
            {
                return new[]
                           {
                               "January", 
                               "February", 
                               "March", 
                               "April", 
                               "May", 
                               "June", 
                               "July"
                           };
            }
        }

        public static IEnumerable<ComplexDataset> Datasets
        {
            get
            {
                return new List<ComplexDataset>
                           { 
                               new ComplexDataset
                                   {
                                       Data = new List<double> { 65, 59, 80, 81, 56, 55, 40 },
                                       Label = "My First dataset",
                                       FillColor = "rgba(220,220,220,0.2)",
                                       StrokeColor = "rgba(220,220,220,1)",
                                       PointColor = "rgba(220,220,220,1)",
                                       PointStrokeColor = "#fff",
                                       PointHighlightFill = "#fff",
                                       PointHighlightStroke = "rgba(220,220,220,1)",
                                   }, 
                               new ComplexDataset
                                   {
                                       Data = new List<double> { 28, 48, 40, 19, 86, 27, 90 },
                                       Label = "My Second dataset",
                                       FillColor = "rgba(151,187,205,0.2)",
                                       StrokeColor = "rgba(151,187,205,1)",
                                       PointColor = "rgba(151,187,205,1)",
                                       PointStrokeColor = "#fff",
                                       PointHighlightFill = "#fff",
                                       PointHighlightStroke = "rgba(151,187,205,1)",
                                   }
                           };
            }
        }
    }
}
