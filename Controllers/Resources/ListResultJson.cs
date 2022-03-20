using System;
using System.Text.Json.Serialization;

namespace MYNDi.VP.Controllers.Resources
{
    public class ListResultJson
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}