using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    class KHOAHOC
    {
        [JsonProperty("idkhoahoc")]
        public long Idkhoahoc { get; set; }

        [JsonProperty("namkhoahoc")]
        public long Namkhoahoc { get; set; }

        public static List<KHOAHOC> FromJson(string json) => JsonConvert.DeserializeObject<List<KHOAHOC>>(json, ooad.DTO.Converter.Settings);
    }
}

