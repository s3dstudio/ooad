using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    class USER
    {

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("idrole")]
        public long Idrole { get; set; }
        public static List<USER> FromJson(string json) => JsonConvert.DeserializeObject<List<USER>>(json, ooad.DTO.Converter.Settings);

        public static USER FromJsonToObject(string json) => JsonConvert.DeserializeObject<USER>(json, ooad.DTO.Converter.Settings);
    }
}
