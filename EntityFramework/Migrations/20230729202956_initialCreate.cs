using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateAndTimeInfo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScheduledStartTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduledStartTimeUtcSpecified = table.Column<bool>(type: "bit", nullable: false),
                    ScheduledEndTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduledEndTimeUtcSpecified = table.Column<bool>(type: "bit", nullable: false),
                    ActualStartTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualStartTimeUtcSpecified = table.Column<bool>(type: "bit", nullable: false),
                    ActualEndTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualEndTimeUtcSpecified = table.Column<bool>(type: "bit", nullable: false),
                    StartDateLocal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDateLocalSpecified = table.Column<bool>(type: "bit", nullable: false),
                    EndDateLocal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateLocalSpecified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateAndTimeInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meta",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdateId = table.Column<long>(type: "bigint", nullable: false),
                    UpdateIdSpecified = table.Column<bool>(type: "bit", nullable: false),
                    UpdateAction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NavigationInfo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasStandings = table.Column<bool>(type: "bit", nullable: false),
                    IsKnockout = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavigationInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherConditions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TemperatureFahrenheit = table.Column<int>(type: "int", nullable: false),
                    TemperatureFahrenheitSpecified = table.Column<bool>(type: "bit", nullable: false),
                    TemperatureCelsius = table.Column<float>(type: "real", nullable: false),
                    TemperatureCelsiusSpecified = table.Column<bool>(type: "bit", nullable: false),
                    WindSpeedMiles = table.Column<int>(type: "int", nullable: false),
                    WindSpeedMilesSpecified = table.Column<bool>(type: "bit", nullable: false),
                    WindSpeedKilometers = table.Column<float>(type: "real", nullable: false),
                    WindSpeedKilometersSpecified = table.Column<bool>(type: "bit", nullable: false),
                    WindDirection = table.Column<int>(type: "int", nullable: false),
                    WindDirectionSpecified = table.Column<bool>(type: "bit", nullable: false),
                    WeatherType = table.Column<int>(type: "int", nullable: false),
                    WeatherTypeSpecified = table.Column<bool>(type: "bit", nullable: false),
                    TailWindSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseballHomePlateWindDirection = table.Column<int>(type: "int", nullable: false),
                    BaseballHomePlateWindDirectionSpecified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    StartDateLocal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDateLocalSpecified = table.Column<bool>(type: "bit", nullable: false),
                    ScheduledStartTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ScheduledStartTimeUtcSpecified = table.Column<bool>(type: "bit", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTimeSpecified = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CurrentState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attendance = table.Column<int>(type: "int", nullable: false),
                    AttendanceSpecified = table.Column<bool>(type: "bit", nullable: false),
                    SportId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenuId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartVenuId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinishVenuId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhaseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeatherConditionsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EventAttributes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportsDisciplineId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportsGenderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiblingOrder = table.Column<int>(type: "int", nullable: false),
                    SiblingOrderSpecified = table.Column<bool>(type: "bit", nullable: false),
                    ScheduleStatus = table.Column<int>(type: "int", nullable: false),
                    ScheduleStatusSpecified = table.Column<bool>(type: "bit", nullable: false),
                    ResultStatus = table.Column<int>(type: "int", nullable: false),
                    ResultStatusSpecified = table.Column<bool>(type: "bit", nullable: false),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NavigationInfoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EventTypeDetail = table.Column<int>(type: "int", nullable: false),
                    EventTypeDetailSpecified = table.Column<bool>(type: "bit", nullable: false),
                    DirectParentSportsEventId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeParticipantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AwayParticipantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParticipantType = table.Column<int>(type: "int", nullable: false),
                    ParticipantTypeSpecified = table.Column<bool>(type: "bit", nullable: false),
                    DateAndTimeInfoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TranslationReferenceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sports = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Venues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Xids = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_DateAndTimeInfo_DateAndTimeInfoId",
                        column: x => x.DateAndTimeInfoId,
                        principalTable: "DateAndTimeInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_Meta_MetaId",
                        column: x => x.MetaId,
                        principalTable: "Meta",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_NavigationInfo_NavigationInfoId",
                        column: x => x.NavigationInfoId,
                        principalTable: "NavigationInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_WeatherConditions_WeatherConditionsId",
                        column: x => x.WeatherConditionsId,
                        principalTable: "WeatherConditions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EventState",
                columns: table => new
                {
                    EventStateId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDataId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventState", x => x.EventStateId);
                    table.ForeignKey(
                        name: "FK_EventState_Events_EventDataId",
                        column: x => x.EventDataId,
                        principalTable: "Events",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ParentChildRelation",
                columns: table => new
                {
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChildId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentChildRelation", x => new { x.ParentId, x.ChildId });
                    table.ForeignKey(
                        name: "FK_ParentChildRelation_Events_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentChildRelation_Events_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelatedSportsEvents",
                columns: table => new
                {
                    RelatedEventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Depth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NavigationInfoId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedSportsEvents", x => new { x.RelatedEventId, x.EventId });
                    table.ForeignKey(
                        name: "FK_RelatedSportsEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelatedSportsEvents_Events_RelatedEventId",
                        column: x => x.RelatedEventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelatedSportsEvents_NavigationInfo_NavigationInfoId",
                        column: x => x.NavigationInfoId,
                        principalTable: "NavigationInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SportsOrganization",
                columns: table => new
                {
                    SportsOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventDataId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsOrganization", x => x.SportsOrganizationId);
                    table.ForeignKey(
                        name: "FK_SportsOrganization_Events_EventDataId",
                        column: x => x.EventDataId,
                        principalTable: "Events",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_DateAndTimeInfoId",
                table: "Events",
                column: "DateAndTimeInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_MetaId",
                table: "Events",
                column: "MetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_NavigationInfoId",
                table: "Events",
                column: "NavigationInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_WeatherConditionsId",
                table: "Events",
                column: "WeatherConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_EventState_EventDataId",
                table: "EventState",
                column: "EventDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentChildRelation_ChildId",
                table: "ParentChildRelation",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedSportsEvents_EventId",
                table: "RelatedSportsEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedSportsEvents_NavigationInfoId",
                table: "RelatedSportsEvents",
                column: "NavigationInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsOrganization_EventDataId",
                table: "SportsOrganization",
                column: "EventDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventState");

            migrationBuilder.DropTable(
                name: "ParentChildRelation");

            migrationBuilder.DropTable(
                name: "RelatedSportsEvents");

            migrationBuilder.DropTable(
                name: "SportsOrganization");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "DateAndTimeInfo");

            migrationBuilder.DropTable(
                name: "Meta");

            migrationBuilder.DropTable(
                name: "NavigationInfo");

            migrationBuilder.DropTable(
                name: "WeatherConditions");
        }
    }
}
