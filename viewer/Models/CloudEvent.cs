
using Newtonsoft.Json;

namespace viewer.Models
{
    public class CloudEvent<T> where T : class
    {
        [JsonProperty("eventID")]
        public string EventId { get; set; }

        [JsonProperty("cloudEventsVersion")]
        public string CloudEventVersion { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("eventTypeVersion")]
        public string EventTypeVersion { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("eventTime")]
        public string EventTime { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
