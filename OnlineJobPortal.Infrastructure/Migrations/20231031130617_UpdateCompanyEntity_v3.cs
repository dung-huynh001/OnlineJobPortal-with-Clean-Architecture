using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class UpdateCompanyEntity_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hotline",
                table: "Companies",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hotline",
                table: "Companies");
        }
    }
}
