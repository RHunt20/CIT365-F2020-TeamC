using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamSacramentMeetingPlanner.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TopicSpeakerOne",
                table: "Meeting",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopicSpeakerThree",
                table: "Meeting",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopicSpeakerTwo",
                table: "Meeting",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopicSpeakerOne",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "TopicSpeakerThree",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "TopicSpeakerTwo",
                table: "Meeting");
        }
    }
}
