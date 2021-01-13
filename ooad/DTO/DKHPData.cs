using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    class DKHPData
    {
        [JsonProperty("iddkhp")]
        public long Iddkhp { get; set; }
        [JsonProperty("idsv")]
        public long Idsv { get; set; }
        [JsonProperty("idtkbnhomlop")]
        public long Idtkbnhomlop { get; set; }

        public static List<DKHPData> FromJson(string json) => JsonConvert.DeserializeObject<List<DKHPData>>(json, ooad.DTO.Converter.Settings);

    }
}
