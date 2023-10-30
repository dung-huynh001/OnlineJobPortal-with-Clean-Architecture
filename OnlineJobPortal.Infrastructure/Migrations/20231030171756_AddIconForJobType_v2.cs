using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class AddIconForJobType_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobTypeIcon",
                value: "fa-user-shield");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "JobTypeIcon", "JobTypeName" },
                values: new object[] { "fa-wifi", "Internet of things(IoT)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "JobTypeIcon", "JobTypeName" },
                values: new object[] { "fa-paint-brush", "Designer" });
        }
    }
}
