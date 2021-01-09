using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    class TKB
    {
        [JsonProperty("idnhomlop")]
        public string Idnhomlop { get; set; }

        [JsonProperty("tennhomlop")]
        public string Tennhomlop { get; set; }

        [JsonProperty("thoigianmo")]
        public DateTimeOffset Thoigianmo { get; set; }

        [JsonProperty("thu")]
        public long Thu { get; set; }

        [JsonProperty("tietbatdau")]
        public long Tietbatdau { get; set; }

        [JsonProperty("tietketthuc")]
        public long Tietketthuc { get; set; }

        public static List<TKB> FromJson(string json) => JsonConvert.DeserializeObject<List<TKB>>(json, ooad.DTO.Converter.Settings);


    }
}
