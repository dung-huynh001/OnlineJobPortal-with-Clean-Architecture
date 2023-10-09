using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class RenameProfileToResume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateSkill_Profiles_ProfileId",
                table: "CandidateSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Profiles_ProfileId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Profiles_ProfileId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_ForeignLanguage_Profiles_ProfileId",
                table: "ForeignLanguage");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences");

            migrationBuilder.RenameTable(
                name: "Experiences",
                newName: "Experience");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "ForeignLanguage",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_ForeignLanguage_ProfileId",
                table: "ForeignLanguage",
                newName: "IX_ForeignLanguage_ResumeId");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Educations",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_Educations_ProfileId",
                table: "Educations",
                newName: "IX_Educations_ResumeId");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "CandidateSkill",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateSkill_ProfileId",
                table: "CandidateSkill",
                newName: "IX_CandidateSkill_ResumeId");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Experience",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_Experiences_ProfileId",
                table: "Experience",
                newName: "IX_Experience_ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experience",
                table: "Experience",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CareerGoal = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CandidateId",
                table: "Resumes",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateSkill_Resumes_ResumeId",
                table: "CandidateSkill",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Resumes_ResumeId",
                table: "Educations",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Resumes_ResumeId",
                table: "Experience",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForeignLanguage_Resumes_ResumeId",
                table: "ForeignLanguage",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateSkill_Resumes_ResumeId",
                table: "CandidateSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Resumes_ResumeId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Resumes_ResumeId",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_ForeignLanguage_Resumes_ResumeId",
                table: "ForeignLanguage");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experience",
                table: "Experience");

            migrationBuilder.RenameTable(
                name: "Experience",
                newName: "Experiences");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "ForeignLanguage",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_ForeignLanguage_ResumeId",
                table: "ForeignLanguage",
                newName: "IX_ForeignLanguage_ProfileId");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "Educations",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Educations_ResumeId",
                table: "Educations",
                newName: "IX_Educations_ProfileId");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "CandidateSkill",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateSkill_ResumeId",
                table: "CandidateSkill",
                newName: "IX_CandidateSkill_ProfileId");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "Experiences",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Experience_ResumeId",
                table: "Experiences",
                newName: "IX_Experiences_ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    CareerGoal = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CandidateId",
                table: "Profiles",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateSkill_Profiles_ProfileId",
                table: "CandidateSkill",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Profiles_ProfileId",
                table: "Educations",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Profiles_ProfileId",
                table: "Experiences",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForeignLanguage_Profiles_ProfileId",
                table: "ForeignLanguage",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
