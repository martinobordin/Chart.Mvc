namespace Chart.Mvc.Tests
{
    using System;

    using Chart.Mvc.Extensions;
    using Chart.Mvc.Options;

    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public partial class SerializationTests
    {
        [TestMethod]
        public void CanSerializePaddingValue()
        {
            var padding1 = new T1OrT2Value<double, Padding>(0.5);
            var jsonString1 = padding1.ToJson();
            Assert.AreEqual("0.5", jsonString1);

            var padding2 = new T1OrT2Value<double, Padding>(new Padding(0.5, 1, 1.5, 2));
            var jsonString2 = padding2.ToJson();
            Assert.AreEqual("{\"Bottom\":2.0,\"Top\":1.0,\"Right\":1.5,\"Left\":0.5}", jsonString2);
        }

        [TestMethod]
        public void CanSerializeToJson()
        {
            var json = DateTime.Now.ToJson();
            Assert.IsFalse(string.IsNullOrWhiteSpace(json));
        }

        [TestMethod]
        public void CanSerializeTwoPrimitiveT1OrT2ValueConfigurations()
        {
            var t1OrT2Value1 = new T1OrT2Value<double?, string>(0.6);
            var jsonString1 = t1OrT2Value1.ToJson();
            Assert.AreEqual("0.6", jsonString1);

            var t1OrT2Value2 = new T1OrT2Value<double?, string>("abc");
            var jsonString2 = t1OrT2Value2.ToJson();
            Assert.AreEqual("\"abc\"", jsonString2);

            var t1OrT2Value3 = new T1OrT2Value<string, string[]>("abc");
            var jsonString3 = t1OrT2Value3.ToJson();
            Assert.AreEqual("\"abc\"", jsonString3);

            var t1OrT2Value4 = new T1OrT2Value<string, string[]>(new [] {"abc", "cde" });
            var jsonString4 = t1OrT2Value4.ToJson();
            Assert.AreEqual("[\"abc\",\"cde\"]", jsonString4);
        }
    }
}
