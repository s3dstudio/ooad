using Newtonsoft.Json;
using System.Collections.Generic;

namespace ooad.DTO
{
    class CHUYENNGANH
    {
        [JsonProperty("idchuyennganh")]
        public long Idchuyennganh { get; set; }

        [JsonProperty("tenchuyennganh")]
        public string Tenchuyennganh { get; set; }

        [JsonProperty("idkhoa")]
        public long Idkhoa { get; set; }

        public static List<CHUYENNGANH> FromJson(string json) => JsonConvert.DeserializeObject<List<CHUYENNGANH>>(json, ooad.DTO.Converter.Settings);
    
    }
}
