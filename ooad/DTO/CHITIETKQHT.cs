using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ooad.DTO
{
    class CHITIETKQHT
    {
        [JsonProperty("idketquahoctap")]
        public long Idketquahoctap { get; set; }

        [JsonProperty("idsv")]
        public long Idsv { get; set; }

        [JsonProperty("idnhomlop")]
        public string Idnhomlop { get; set; }

        [JsonProperty("idhocphan")]
        public string Idhocphan { get; set; }

        [JsonProperty("quatrinh")]
        public double Quatrinh { get; set; }

        [JsonProperty("thuchanh")]
        public double Thuchanh { get; set; }

        [JsonProperty("thi")]
        public double Thi { get; set; }

        [JsonProperty("ketqua")]
        public double Ketqua { get; set; }

        [JsonProperty("tenhocphan")]
        public string Tenhocphan { get; set; }

        [JsonProperty("sotinchi")]
        public long Sotinchi { get; set; }

        public static List<CHITIETKQHT> FromJson(string json) => JsonConvert.DeserializeObject<List<CHITIETKQHT>>(json, ooad.DTO.Converter.Settings);


    }
}
