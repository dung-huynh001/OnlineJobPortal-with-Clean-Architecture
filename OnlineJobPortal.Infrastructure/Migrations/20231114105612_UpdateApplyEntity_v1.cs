using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class UpdateApplyEntity_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Applys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CoverLetter",
                table: "Applys",
                type: "ntext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CvUrl",
                table: "Applys",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverLetter",
                table: "Applys");

            migrationBuilder.DropColumn(
                name: "CvUrl",
                table: "Applys");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Applys",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
