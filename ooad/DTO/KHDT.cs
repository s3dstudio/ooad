using System.Collections.Generic;
using Newtonsoft.Json;

namespace ooad.DTO
{
    class KHDT
    {
        [JsonProperty("idkhdt")]
        public long Idkhdt { get; set; }

        [JsonProperty("tenkhdt")]
        public string Tenkhdt { get; set; }

        [JsonProperty("idhdt")]
        public long Idhdt { get; set; }

        [JsonProperty("idchuyennganh")]
        public long Idchuyennganh { get; set; }

        [JsonProperty("idlhdt")]
        public long Idlhdt { get; set; }

        [JsonProperty("idkhoahoc")]
        public long Idkhoahoc { get; set; }

        public static List<KHDT> FromJson(string json) => JsonConvert.DeserializeObject<List<KHDT>>(json, ooad.DTO.Converter.Settings);

    }
}
