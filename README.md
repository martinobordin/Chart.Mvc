[![Stories in Ready](https://badge.waffle.io/martinobordin/Chart.Mvc.svg?label=ready&title=Ready)](http://waffle.io/martinobordin/Chart.Mvc)

# Chart.Mvc
A .NET wrapper to generate charts using the popular _Chart.Js_ library (http://www.chartjs.org).

## Sample
You can see the library in action here: http://www.martinobordin.it/Chart.Mvc

## Installation
Install using Nuget or compile binary from https://github.com/martinobordin/Chart.Mvc.git.

        PM> Install-Package Chart.Mvc

## How do I use it?
To use the library you just need to:
* include a reference to _Chart.Js_ library (provided in Nuget Package or downloadable from http://www.chartjs.org, )
* insert a **canvas** in your HTML 
* call the method **Html.CreateChart()**, passing the canvas name and the chart object you want to use

        @{
            var barChart = new BarChart();
            barChart.ComplexData.Labels.AddRange(new []{ "January", "February",  "March", "April", "May", "June", "July"});
            barChart.ComplexData.Datasets.AddRange(new List<ComplexDataset>
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
                                  });
        }
        
        <canvas id="myCanvas" width="400" height="400"></canvas>
        @Html.CreateChart("myCanvas", barChart)

**Note:** 
* Be sure to call CreateChart AFTER the reference to Chart.js file
* The generated chart object will be named like the canvas plus "_chart" suffix (for the example above: myCanvas_chart). In this way you can attach handlers and call method like generateLegend().

The chart object contains information like chart type, labels, data and visualization options.
Property names are the same of the original _Chart.Js_, so it should be easy to use them.

Currently all the 6 types of _Charts.Js_ charts are supported and fully configurable:
* Line chart (**BarChart** class with **BarChartOptions**)
* Bar chart (**LineChart** class with **LineChartOptions**)
* Radar chart (**RadarChart** class with **RadarChartOptions**)
* Polar area chart (**PolarAreaChart** class with **PolarAreaChartOptions**)
* Pie charts (**PieChart** class with **PieChartOptions**)
* Doughnut charts (**DoughnutChart** class with **DoughnutChartOptions**)

## Disclaimer
The software is provided "AS IS". I didn't full test it (_Chart.Js_ has tons of options) and you'd need to properly escape strings containing JavaScript and be sure to pass correct parameters (valid colors values, etc) . 

To contribute and improve the code just contact me!
