namespace Chart.Mvc.Converters
{
    using System;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SingleOrComplexValueConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(ISingleOrComplexValue).IsAssignableFrom(objectType);
        }

        public override bool CanRead => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var singleOrComplexValue = (ISingleOrComplexValue)value;
            var token = JToken.FromObject(JToken.FromObject(singleOrComplexValue.Value));
            token.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
