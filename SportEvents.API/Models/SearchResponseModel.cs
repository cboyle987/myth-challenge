using EntityFramework.Models;

namespace SportEvents.API.Models
{
    public class SearchResponseModel
    {
        public int Count { get; set; }
        public List<EventData> Results { get; set; }
    }
}
