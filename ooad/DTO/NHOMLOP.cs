using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    class NHOMLOP
    {
        [JsonProperty("idhocphan")]
        public string Idhocphan { get; set; }

        [JsonProperty("ten")]
        public string Ten { get; set; }

        [JsonProperty("thoigianmo")]
        public DateTimeOffset Thoigianmo { get; set; }

        [JsonProperty("idnhomlop")]
        public string Idnhomlop { get; set; }

        public static List<NHOMLOP> FromJson(string json) => JsonConvert.DeserializeObject<List<NHOMLOP>>(json, ooad.DTO.Converter.Settings);
    
    }
}
