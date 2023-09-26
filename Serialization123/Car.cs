using Newtonsoft.Json;

namespace Serialization123
{
    public class Car
    {
        [JsonProperty("CarModel")]
        public string? Model { get; set; }
        public string? Vendor { get; set; }
      //  [JsonIgnore]
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Model}  {Vendor}  {Year}";
        }
    }
}