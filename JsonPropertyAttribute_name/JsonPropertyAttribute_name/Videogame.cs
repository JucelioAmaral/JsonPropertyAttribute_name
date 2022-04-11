using Newtonsoft.Json;
using System;

namespace JsonPropertyAttribute_name
{
    public class Videogame
    {
        [JsonProperty("name of Videogame")]
        public string Name { get; set; }

        [JsonProperty("release date")]
        public DateTime ReleaseDate { get; set; }
    }
}
