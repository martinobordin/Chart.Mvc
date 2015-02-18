using System.Collections.Generic;
using Chart.Mvc.SimpleChart;

namespace Chart.Mvc.Sample.Models
{
    public static class FakeSimpleChartData
    {
        public static IEnumerable<SimpleData> Data
        {
            get
            {
                return new List<SimpleData>
                {
                    new SimpleData
                    {
                        Value = 300,
                        Color = "#F7464A",
                        Highlight = "#FF5A5E",
                        Label = "Red"
                    },
                    new SimpleData
                    {
                        Value = 50,
                        Color = "#46BFBD",
                        Highlight = "#5AD3D1",
                        Label = "Green"
                    },
                    new SimpleData
                    {
                        Value = 100,
                        Color = "#FDB45C",
                        Highlight = "#FFC870",
                        Label = "Yellow"
                    }
                };
            }
        }
    }
}