using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgodaTest.Models
{
    public class NumberRequestDTO
    {
        [JsonProperty("numbers")]
        public int[] Numbers { get; set; }
    }

    public class NumberResponseDTO
    {
        [JsonProperty("GCD")]
        public int GCD { get; set; }
    }
}
