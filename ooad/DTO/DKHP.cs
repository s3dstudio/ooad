using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    class DKHP
    {

        [JsonProperty("idnhomlop")]
        public string Idnhomlop { get; set; }

        [JsonProperty("tenhocphan")]
        public string Tenhocphan { get; set; }

        [JsonProperty("khoaquanly")]
        public string Khoaquanly { get; set; }

        [JsonProperty("sotinchi")]
        public long Sotinchi { get; set; }

        [JsonProperty("giangvien")]
        public string Giangvien { get; set; }

        [JsonProperty("thu")]
        public long Thu { get; set; }

        [JsonProperty("tietbatdau")]
        public long Tietbatdau { get; set; }

        [JsonProperty("tietketthuc")]
        public long Tietketthuc { get; set; }
        [JsonProperty("idtkbnhomlop")]
        public long Idtkbnhomlop { get; set; }

        public static List<DKHP> FromJson(string json) => JsonConvert.DeserializeObject<List<DKHP>>(json, Converter.Settings);

    }
}
