using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamSacramentMeetingPlanner.Migrations
{
    public partial class columnChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SacramentHymnNumber",
                table: "Meeting",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RestHymnNumber",
                table: "Meeting",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OpeningHymnNumber",
                table: "Meeting",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ClosingHymn",
                table: "Meeting",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SacramentHymnNumber",
                table: "Meeting",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "RestHymnNumber",
                table: "Meeting",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpeningHymnNumber",
                table: "Meeting",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "ClosingHymn",
                table: "Meeting",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
