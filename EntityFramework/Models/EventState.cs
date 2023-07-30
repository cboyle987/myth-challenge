using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class EventState
    {
        public string EventStateId { get; set; } = null!;
        public string? Key { get; set; }
        public string? Value { get; set; }

        [JsonIgnore]
        public string? EventDataId { get; set; }
        [JsonIgnore]
        public EventData? MyProperty { get; set; }
    }
}
