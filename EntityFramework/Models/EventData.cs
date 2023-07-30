using System.Text.Json.Serialization;

namespace EntityFramework.Models
{
    public class EventData
    {
        public string Id { get; set; }
        public string? Description { get; set; }
        public int Type { get; set; }
        public DateTime? StartDateLocal { get; set; }
        public bool StartDateLocalSpecified { get; set; }
        public DateTime? ScheduledStartTimeUtc { get; set; }
        public bool ScheduledStartTimeUtcSpecified { get; set; }
        public DateTime? EndTime { get; set; }
        public bool EndTimeSpecified { get; set; }
        public int Status { get; set; }
        public ICollection<EventState>? State { get; set; }
        public string? CurrentState { get; set; }
        public int Attendance { get; set; }
        public bool AttendanceSpecified { get; set; }
        public string? SportId { get; set; }
        public string? VenuId { get; set; }
        public string? StartVenuId { get; set; }
        public string? FinishVenuId { get; set; }
        public string? PhaseId { get; set; }
        public ICollection<SportsOrganization>? SportsOrganizations { get; set; }
        public ICollection<ParentChildRelation>? ParentSportEvents { get; set; }
        public ICollection<ParentChildRelation>? ChildSportEvents { get; set; }
        public WeatherConditions? WeatherConditions { get; set; }
        public string? EventAttributes { get; set; }
        public string? SportsDisciplineId { get; set; }
        public string? SportsGenderId { get; set; }
        public int SiblingOrder { get; set; }
        public bool SiblingOrderSpecified { get; set; }
        public int ScheduleStatus { get; set; }
        public bool ScheduleStatusSpecified { get; set; }
        public int ResultStatus { get; set; }
        public bool ResultStatusSpecified { get; set; }
        public string? Properties { get; set; }
        public NavigationInfo? NavigationInfo { get; set; }
        public int EventTypeDetail { get; set; }
        public bool EventTypeDetailSpecified { get; set; }
        public string? DirectParentSportsEventId { get; set; }
        public string? HomeParticipantId { get; set; }
        public string? AwayParticipantId { get; set; }
        public int ParticipantType { get; set; }
        public bool ParticipantTypeSpecified { get; set; }
        public DateAndTimeInfo? DateAndTimeInfo { get; set; }
        public string? TranslationReferenceId { get; set; }
        public string? Sports { get; set; }
        public string? Venues { get; set; }
        public ICollection<RelatedSportsEvents>? RelatedSportsEvents { get; set; }
        public Meta? Meta { get; set; }
        public string? Xids { get; set; }
    }

    

    public class RelatedSportsEvents
    {
        public string RelatedEventId { get; set; } = null!;
        public string EventId { get; set; } = null!;
        [JsonIgnore]
        public EventData? RelatedEvent { get; set; }
        [JsonIgnore]
        public EventData? Event { get; set; }
        public string? Type { get; set; }
        public string? TypeDetail { get; set; }
        public string? Depth { get; set; }
        public NavigationInfo? NavigationInfo { get; set; }
    }

    

    public class ParentChildRelation
    {
        public string ParentId { get; set; } = null!;
        public string ChildId { get; set; } = null!;
        [JsonIgnore]
        public virtual EventData? Parent { get; set; }
        [JsonIgnore]
        public virtual EventData? Child { get; set; }
    }

}
