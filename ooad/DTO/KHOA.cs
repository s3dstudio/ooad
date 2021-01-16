using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    class KHOA
    {
        [JsonProperty("idkhoa")]
        public long Idkhoa { get; set; }

        [JsonProperty("tenkhoa")]
        public string Tenkhoa { get; set; }

        [JsonProperty("diachi")]
        public string Diachi { get; set; }

        [JsonProperty("sdt")]
        public string Sdt { get; set; }

        public static List<KHOA> FromJson(string json) => JsonConvert.DeserializeObject<List<KHOA>>(json, ooad.DTO.Converter.Settings);

    }
}
