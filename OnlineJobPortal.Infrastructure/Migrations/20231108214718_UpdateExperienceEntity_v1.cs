using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class UpdateExperienceEntity_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proficiency",
                table: "ForeignLanguage");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ExperienceId",
                table: "Skills",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ExperienceId",
                table: "Projects",
                column: "ExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Experiences_ExperienceId",
                table: "Projects",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Experiences_ExperienceId",
                table: "Skills",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Experiences_ExperienceId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Experiences_ExperienceId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ExperienceId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ExperienceId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "Proficiency",
                table: "ForeignLanguage",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }
    }
}
