using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Utils
{
        public class StringToDoubleConverter : JsonConverter<double>
        {
            public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.String)
                {
                    var stringValue = reader.GetString();
                    if (double.TryParse(stringValue, out var value))
                    {
                        return value;
                    }
                    throw new JsonException($"Unable to convert \"{stringValue}\" to double.");
                }

                return reader.GetDouble();
            }

            public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value.ToString());
            }
    }
}
