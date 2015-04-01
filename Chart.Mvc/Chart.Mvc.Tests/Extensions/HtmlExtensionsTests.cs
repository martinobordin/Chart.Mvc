using System;
using System.Web.Mvc;
using Chart.Mvc.ComplexChart;
using Chart.Mvc.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chart.Mvc.Tests.Extensions
{
      [TestClass]
    public class HtmlExtensionsTests
    {
          [TestMethod]
          public void CanCreateEmptyBarChart()
          {
              var htmlHelper = new HtmlHelper(new ViewContext(), new ViewPage());
              var chartString = htmlHelper.CreateChart("myCanvasId", new BarChart());
              Assert.IsFalse(string.IsNullOrWhiteSpace(chartString.ToString()));
          }
    }
}
