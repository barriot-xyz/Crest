using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Converters
{
    internal static class ModelConverter
    {
        public static TModel FromJson<TModel>(this string json)
        {
            using var textReader = new StringReader(json);
            using var jsonReader = new JsonTextReader(textReader);

            try
            {
                var model = CrestConfiguration.Serializer.Deserialize<TModel>(jsonReader);

                if (model is null)
                    throw new JsonSerializationException("Unable to parse model from provided string.");

                return model!;
            }
            catch (Exception ex) when (ex is JsonException) { throw; }
        }

        public static string ToJson<TModel>(this TModel model)
        {
            using var textWriter = new StringWriter();

            CrestConfiguration.Serializer.Serialize(textWriter, model);

            return textWriter.ToString();
        }
    }
}
