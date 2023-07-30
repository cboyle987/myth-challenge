using System.ComponentModel;
namespace SportEvents.API.Models
{
    public class SearchRequestModel
    {
        [DefaultValue(null)]
        public string? Description { get; set; }
        [DefaultValue(null)]
        public string? SportId { get; set; }
        [DefaultValue(0)]
        public int Type{ get; set; }
        [DefaultValue(null)]
        public string? SportsDisciplineId { get; set; }
    }
}
