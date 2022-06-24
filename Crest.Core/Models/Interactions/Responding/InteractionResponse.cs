using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class InteractionResponse
    {
        [JsonProperty("type")]
        public ResponseType Type { get; set; }

        [JsonProperty("data")]
        public CallbackData? Data { get; set; }

        /// <summary>
        ///     Creates a new instance of an interaction response.
        /// </summary>
        /// <param name="type">The type of response.</param>
        /// <param name="data">The data that this response may include.</param>
        public InteractionResponse(ResponseType type, CallbackData? data = null)
        {
            Type = type;
            Data = data;
        }

        /// <summary>
        ///     Turns the current response into a serialized object.
        /// </summary>
        /// <returns>The serialized string of the response object.</returns>
        public string Serialize()
        {
            var json = new StringBuilder();
            using (var text = new StringWriter(json))
            using (var writer = new JsonTextWriter(text))
                ClientConfiguration.Serializer.Serialize(writer, this);

            return json.ToString();
        }
    }
}
