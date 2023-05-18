using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Helpers
{
    public class TypeIgnoringConverter : JsonConverter<Type>
    {
        public override Type Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Not supported, return null
            return null;
        }

        public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
        {
            // Not supported, write nothing
        }
    }

}
