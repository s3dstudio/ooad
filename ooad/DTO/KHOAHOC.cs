using System.Collections.Generic;
using Newtonsoft.Json;

namespace ooad.DTO
{
    public class KHOAHOC
    {
        [JsonProperty("idkhoahoc")]
        public long Idkhoahoc { get; set; }

        [JsonProperty("namkhoahoc")]
        public long Namkhoahoc { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        public static List<KHOAHOC> FromJson(string json) => JsonConvert.DeserializeObject<List<KHOAHOC>>(json, ooad.DTO.Converter.Settings);
    }
}

