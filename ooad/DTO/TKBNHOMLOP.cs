using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    class TKBNHOMLOP
    {
        [JsonProperty("idtkbnhomlop")]
        public long Idtkbnhomlop { get; set; }

        [JsonProperty("hocky")]
        public string Hocky { get; set; }

        [JsonProperty("idgiangvien")]
        public long Idgiangvien { get; set; }

        [JsonProperty("tuan")]
        public string Tuan { get; set; }

        [JsonProperty("idphonglt")]
        public long Idphonglt { get; set; }

        [JsonProperty("idphongth")]
        public long Idphongth { get; set; }

        [JsonProperty("idnhomlop")]
        public string Idnhomlop { get; set; }

        [JsonProperty("thu")]
        public long Thu { get; set; }

        [JsonProperty("tietbatdau")]
        public long Tietbatdau { get; set; }

        [JsonProperty("tietketthuc")]
        public long Tietketthuc { get; set; }

        public static List<TKBNHOMLOP> FromJson(string json) => JsonConvert.DeserializeObject<List<TKBNHOMLOP>>(json, ooad.DTO.Converter.Settings);

    }
}
