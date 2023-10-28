using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class UpdateJobPostEntity_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "JobPosts");

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "JobPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "JobPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_DistrictId_ProvinceId",
                table: "JobPosts",
                columns: new[] { "DistrictId", "ProvinceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Districts_DistrictId_ProvinceId",
                table: "JobPosts",
                columns: new[] { "DistrictId", "ProvinceId" },
                principalTable: "Districts",
                principalColumns: new[] { "Id", "ProvinceId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Districts_DistrictId_ProvinceId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_DistrictId_ProvinceId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "JobPosts");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "JobPosts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
