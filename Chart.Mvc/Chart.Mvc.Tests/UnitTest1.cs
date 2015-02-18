using System;
using Chart.Mvc.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chart.Mvc.Tests
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void CanSerializeToJson()
        {
            var json = DateTime.Now.ToJson();
            Assert.IsFalse(string.IsNullOrWhiteSpace(json));
        }
    }
}
