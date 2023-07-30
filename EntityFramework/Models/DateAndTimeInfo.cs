namespace EntityFramework.Models
{

    public class DateAndTimeInfo
    {
        public string? Id { get; set; }
        public DateTime ScheduledStartTimeUtc { get; set; }
        public bool ScheduledStartTimeUtcSpecified { get; set; }
        public DateTime ScheduledEndTimeUtc { get; set; }
        public bool ScheduledEndTimeUtcSpecified { get; set; }
        public DateTime ActualStartTimeUtc { get; set; }
        public bool ActualStartTimeUtcSpecified { get; set; }
        public DateTime ActualEndTimeUtc { get; set; }
        public bool ActualEndTimeUtcSpecified { get; set; }
        public DateTime StartDateLocal { get; set; }
        public bool StartDateLocalSpecified { get; set; }
        public DateTime EndDateLocal { get; set; }
        public bool EndDateLocalSpecified { get; set; }
    }

}