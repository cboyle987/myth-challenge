using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class SportOrgKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentChildRelation_Events_ChildId",
                table: "ParentChildRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentChildRelation_Events_ParentId",
                table: "ParentChildRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedSportsEvents_Events_EventId",
                table: "RelatedSportsEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedSportsEvents_Events_RelatedEventId",
                table: "RelatedSportsEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedSportsEvents_NavigationInfo_NavigationInfoId",
                table: "RelatedSportsEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_SportsOrganization_Events_EventDataId",
                table: "SportsOrganization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SportsOrganization",
                table: "SportsOrganization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelatedSportsEvents",
                table: "RelatedSportsEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParentChildRelation",
                table: "ParentChildRelation");

            migrationBuilder.RenameTable(
                name: "RelatedSportsEvents",
                newName: "Relations");

            migrationBuilder.RenameTable(
                name: "ParentChildRelation",
                newName: "ParentRelations");

            migrationBuilder.RenameIndex(
                name: "IX_RelatedSportsEvents_NavigationInfoId",
                table: "Relations",
                newName: "IX_Relations_NavigationInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_RelatedSportsEvents_EventId",
                table: "Relations",
                newName: "IX_Relations_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_ParentChildRelation_ChildId",
                table: "ParentRelations",
                newName: "IX_ParentRelations_ChildId");

            migrationBuilder.AlterColumn<string>(
                name: "EventDataId",
                table: "SportsOrganization",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportsOrganization",
                table: "SportsOrganization",
                columns: new[] { "SportsOrganizationId", "EventDataId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relations",
                table: "Relations",
                columns: new[] { "RelatedEventId", "EventId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParentRelations",
                table: "ParentRelations",
                columns: new[] { "ParentId", "ChildId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ParentRelations_Events_ChildId",
                table: "ParentRelations",
                column: "ChildId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentRelations_Events_ParentId",
                table: "ParentRelations",
                column: "ParentId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relations_Events_EventId",
                table: "Relations",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relations_Events_RelatedEventId",
                table: "Relations",
                column: "RelatedEventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relations_NavigationInfo_NavigationInfoId",
                table: "Relations",
                column: "NavigationInfoId",
                principalTable: "NavigationInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SportsOrganization_Events_EventDataId",
                table: "SportsOrganization",
                column: "EventDataId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentRelations_Events_ChildId",
                table: "ParentRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentRelations_Events_ParentId",
                table: "ParentRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Relations_Events_EventId",
                table: "Relations");

            migrationBuilder.DropForeignKey(
                name: "FK_Relations_Events_RelatedEventId",
                table: "Relations");

            migrationBuilder.DropForeignKey(
                name: "FK_Relations_NavigationInfo_NavigationInfoId",
                table: "Relations");

            migrationBuilder.DropForeignKey(
                name: "FK_SportsOrganization_Events_EventDataId",
                table: "SportsOrganization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SportsOrganization",
                table: "SportsOrganization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Relations",
                table: "Relations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParentRelations",
                table: "ParentRelations");

            migrationBuilder.RenameTable(
                name: "Relations",
                newName: "RelatedSportsEvents");

            migrationBuilder.RenameTable(
                name: "ParentRelations",
                newName: "ParentChildRelation");

            migrationBuilder.RenameIndex(
                name: "IX_Relations_NavigationInfoId",
                table: "RelatedSportsEvents",
                newName: "IX_RelatedSportsEvents_NavigationInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Relations_EventId",
                table: "RelatedSportsEvents",
                newName: "IX_RelatedSportsEvents_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_ParentRelations_ChildId",
                table: "ParentChildRelation",
                newName: "IX_ParentChildRelation_ChildId");

            migrationBuilder.AlterColumn<string>(
                name: "EventDataId",
                table: "SportsOrganization",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportsOrganization",
                table: "SportsOrganization",
                column: "SportsOrganizationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelatedSportsEvents",
                table: "RelatedSportsEvents",
                columns: new[] { "RelatedEventId", "EventId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParentChildRelation",
                table: "ParentChildRelation",
                columns: new[] { "ParentId", "ChildId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ParentChildRelation_Events_ChildId",
                table: "ParentChildRelation",
                column: "ChildId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentChildRelation_Events_ParentId",
                table: "ParentChildRelation",
                column: "ParentId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedSportsEvents_Events_EventId",
                table: "RelatedSportsEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedSportsEvents_Events_RelatedEventId",
                table: "RelatedSportsEvents",
                column: "RelatedEventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedSportsEvents_NavigationInfo_NavigationInfoId",
                table: "RelatedSportsEvents",
                column: "NavigationInfoId",
                principalTable: "NavigationInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SportsOrganization_Events_EventDataId",
                table: "SportsOrganization",
                column: "EventDataId",
                principalTable: "Events",
                principalColumn: "Id");
        }
    }
}
