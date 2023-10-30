using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class AddIconForJobType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobTypeIcon",
                table: "JobTypes",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobTypeIcon",
                value: "fa-laptop-code");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobTypeIcon",
                value: "fa-mobile-alt");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobTypeIcon",
                value: "fa-check-double");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobTypeIcon",
                value: "fa-chart-pie");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobTypeIcon",
                value: "fa-vial");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "JobTypeIcon",
                value: "fa-paint-brush");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "JobTypeIcon",
                value: "fa-tasks");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "JobTypeIcon",
                value: "fa-users");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "JobTypeIcon",
                value: "fa-paint-brush");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "JobTypeIcon",
                value: "fa-server");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "JobTypeIcon",
                value: "fa-cogs");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "JobTypeIcon",
                value: "fa-shield-alt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTypeIcon",
                table: "JobTypes");
        }
    }
}
