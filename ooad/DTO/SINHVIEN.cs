using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace ooad.DTO
{
    class SINHVIEN
    {
        [JsonProperty("idsv")]
        public long Idsv { get; set; }

        [JsonProperty("hoten")]
        public string Hoten { get; set; }

        [JsonProperty("ngaysinh")]
        public string Ngaysinh { get; set; }

        [JsonProperty("gioitinh")]
        public string Gioitinh { get; set; }

        [JsonProperty("noisinh")]
        public string Noisinh { get; set; }

        [JsonProperty("hktt")]
        public string Hktt { get; set; }

        [JsonProperty("idkhoa")]
        public long Idkhoa { get; set; }

        [JsonProperty("ktx")]
        public string Ktx { get; set; }

        [JsonProperty("bixoa")]
        public string Bixoa { get; set; }

        [JsonProperty("lydoxoa")]
        public string Lydoxoa { get; set; }

        [JsonProperty("anh")]
        public string Anh { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        public static List<SINHVIEN> FromJson(string json) => JsonConvert.DeserializeObject<List<SINHVIEN>>(json, ooad.DTO.Converter.Settings);

        public static SINHVIEN FromJsonToObject(string json) => JsonConvert.DeserializeObject<SINHVIEN>(json, ooad.DTO.Converter.Settings);

    }
}
