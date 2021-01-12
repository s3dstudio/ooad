using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    public class CHITIETKEHOACH
    {
        [JsonProperty("idchitietkhdt")]
        public long Idchitietkhdt { get; set; }

        [JsonProperty("idkhdt")]
        public long Idkhdt { get; set; }

        [JsonProperty("tenkhdt")]
        public string Tenkhdt { get; set; }

        [JsonProperty("idhdt")]
        public long Idhdt { get; set; }

        [JsonProperty("idhocphan")]
        public string Idhocphan { get; set; }

        [JsonProperty("tenhocphan")]
        public string Tenhocphan { get; set; }

        [JsonProperty("sotinchi")]
        public long Sotinchi { get; set; }

        [JsonProperty("sotietlythuyet")]
        public long Sotietlythuyet { get; set; }

        [JsonProperty("sotietthuchanh")]
        public long Sotietthuchanh { get; set; }

        [JsonProperty("sotiettuhoc")]
        public long Sotiettuhoc { get; set; }

        [JsonProperty("sotietthamquan")]
        public long Sotietthamquan { get; set; }
        public static List<CHITIETKEHOACH> FromJson(string json) => JsonConvert.DeserializeObject<List<CHITIETKEHOACH>>(json, ooad.DTO.Converter.Settings);

    }
}
