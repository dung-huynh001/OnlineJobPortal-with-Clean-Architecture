using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class UpdateRelationshipCandidateResume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Resumes_CandidateId",
                table: "Resumes");

            migrationBuilder.AddColumn<string>(
                name: "CvUrl",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YearOfExperiences",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "Candidates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CandidateId",
                table: "Resumes",
                column: "CandidateId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Resumes_CandidateId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "CvUrl",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "YearOfExperiences",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Candidates");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CandidateId",
                table: "Resumes",
                column: "CandidateId");
        }
    }
}
