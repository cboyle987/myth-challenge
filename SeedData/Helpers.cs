using EntityFramework.Models;
using SeedData.models;

namespace SeedData
{
    public static class Helpers
    {
        public static EventData MapEventData(SuppliedJson e)
        {
            return new EventData
            {
                Id = e.id,
                Description = e.description,
                Type = e.type,
                StartDateLocal = e.start_date_local,
                StartDateLocalSpecified = e.start_date_localSpecified,
                ScheduledStartTimeUtc = e.scheduled_start_time_utc,
                ScheduledStartTimeUtcSpecified = e.scheduled_start_time_utcSpecified,
                EndTime = e.end_time,
                EndTimeSpecified = e.end_timeSpecified,
                Status = e.status,
                State = e.state?.Select(s => new EventState
                {
                    EventStateId = Guid.NewGuid().ToString(),
                    Key = s.key,
                    Value = s.value,
                }).ToList(),
                CurrentState = e.current_state,
                Attendance = e.attendance,
                AttendanceSpecified = e.attendanceSpecified,
                SportId = e.sport_id,
                VenuId = e.venue_id,
                StartVenuId = e.start_venue_id,
                FinishVenuId = e.finish_venue_id,
                PhaseId = e.phase_id,
                SportsOrganizations = e.sports_organization_ids?.Select(org => new SportsOrganization { SportsOrganizationId = org }).ToList(),
                WeatherConditions = e.weather_conditions != null ? new WeatherConditions
                {
                    BaseballHomePlateWindDirection = e.weather_conditions.baseball_home_plate_wind_direction,
                    BaseballHomePlateWindDirectionSpecified = e.weather_conditions.baseball_home_plate_wind_directionSpecified,
                    Id = Guid.NewGuid().ToString(),
                    TemperatureFahrenheit = e.weather_conditions.temperature_fahrenheit,
                    TemperatureFahrenheitSpecified = e.weather_conditions.temperature_fahrenheitSpecified,
                    TemperatureCelsius = e.weather_conditions.temperature_celsius,
                    TemperatureCelsiusSpecified = e.weather_conditions.temperature_celsiusSpecified,
                    WindSpeedMiles = e.weather_conditions.wind_speed_miles,
                    WindSpeedMilesSpecified = e.weather_conditions.wind_speed_milesSpecified,
                    WindSpeedKilometers = e.weather_conditions.wind_speed_kilometers,
                    WindSpeedKilometersSpecified = e.weather_conditions.wind_speed_kilometersSpecified,
                    WindDirection = e.weather_conditions.wind_direction,
                    WindDirectionSpecified = e.weather_conditions.wind_directionSpecified,
                    WeatherType = e.weather_conditions.weather_type,
                    TailWindSpeed = e.weather_conditions.tail_wind_speed
                } : null,
                EventAttributes = e.event_attributes,
                SportsDisciplineId = e.sports_discipline_id,
                SportsGenderId = e.sports_gender_id,
                SiblingOrder = e.sibling_order,
                SiblingOrderSpecified = e.sibling_orderSpecified,
                ScheduleStatus = e.schedule_status,
                ScheduleStatusSpecified = e.schedule_statusSpecified,
                ResultStatus = e.result_status,
                Properties = e.properties != null ? e.properties.ToString() : null,
                EventTypeDetail = e.event_type_detail,
                EventTypeDetailSpecified = e.event_type_detailSpecified,
                DirectParentSportsEventId = e.direct_parent_sports_event_id,
                HomeParticipantId = e.home_participant_id,
                AwayParticipantId = e.away_participant_id,
                ParticipantType = e.participant_type,
                ParticipantTypeSpecified = e.participant_typeSpecified,
                DateAndTimeInfo = e.date_and_time_info != null ? new DateAndTimeInfo
                {
                    Id = Guid.NewGuid().ToString(),
                    ScheduledStartTimeUtc = e.date_and_time_info.scheduled_start_time_utc,
                    ScheduledStartTimeUtcSpecified = e.date_and_time_info.scheduled_start_time_utcSpecified,
                    ScheduledEndTimeUtc = e.date_and_time_info.scheduled_end_time_utc,
                    ScheduledEndTimeUtcSpecified = e.date_and_time_info.scheduled_end_time_utcSpecified,
                    ActualEndTimeUtc = e.date_and_time_info.actual_end_time_utc,
                    ActualEndTimeUtcSpecified = e.date_and_time_info.actual_end_time_utcSpecified,
                    ActualStartTimeUtc = e.date_and_time_info.actual_start_time_utc,
                    ActualStartTimeUtcSpecified = e.date_and_time_info.actual_start_time_utcSpecified,
                    StartDateLocal = e.date_and_time_info.start_date_local,
                    StartDateLocalSpecified = e.date_and_time_info.start_date_localSpecified,
                    EndDateLocal = e.date_and_time_info.end_date_local,
                    EndDateLocalSpecified = e.date_and_time_info.end_date_localSpecified

                } : null,
                TranslationReferenceId = e.translation_reference_id,
                Sports = e.sports,
                Venues = e.venues,
                Meta = e.meta != null ? new EntityFramework.Models.Meta
                {
                    Id = Guid.NewGuid().ToString(),
                    UpdateId = e.meta.update_id,
                    UpdateIdSpecified = e.meta.update_idSpecified,
                    UpdateAction = e.meta.update_action,
                    UpdateDate = e.meta.update_date,
                    Language = e.meta.language,
                } : null,
                Xids = e.xids


            };
        }

        public static List<ParentChildRelation> MapParentChildRelation(string childId, string[] parentIds)
        {
            var relations = new List<ParentChildRelation>();
            foreach(var parentId in parentIds) {
                relations.Add(new ParentChildRelation
                {
                    ChildId = childId,
                    ParentId = parentId,
                });
            }
            return relations;
        }

        public static List<RelatedSportsEvents> MapRelatedEvents(string eventId, Related_Sports_Events[] relatedEvents)
        {
            var relations = new List<RelatedSportsEvents>();
            if (relatedEvents != null)
            {
                foreach (var relatedEvent in relatedEvents)
                {
                    relations.Add(new RelatedSportsEvents
                    {
                        EventId = eventId,
                        RelatedEventId = relatedEvent.id,
                        Type = relatedEvent.type,
                        TypeDetail = relatedEvent.type_detail,
                        Depth = relatedEvent.depth,
                        NavigationInfo = relatedEvent.navigation_info != null ? new NavigationInfo
                        {
                            Id = Guid.NewGuid().ToString(),
                            HasStandings = relatedEvent.navigation_info.has_standings,
                            IsKnockout = relatedEvent.navigation_info.is_knockout
                        } : null
                    });
                }
            }
            
            
            return relations;
        }
    }
}
