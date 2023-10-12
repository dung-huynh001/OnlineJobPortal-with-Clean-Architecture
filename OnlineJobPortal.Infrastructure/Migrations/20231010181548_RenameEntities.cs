using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class RenameEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateSkill_Resumes_ResumeId",
                table: "CandidateSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateSkill_Skills_SkillId",
                table: "CandidateSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_BussinessIndustry_BussinessIndustryId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Resumes_ResumeId",
                table: "Experience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experience",
                table: "Experience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateSkill",
                table: "CandidateSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BussinessIndustry",
                table: "BussinessIndustry");

            migrationBuilder.RenameTable(
                name: "Experience",
                newName: "Experiences");

            migrationBuilder.RenameTable(
                name: "CandidateSkill",
                newName: "CandidateSkills");

            migrationBuilder.RenameTable(
                name: "BussinessIndustry",
                newName: "BussinessIndustrys");

            migrationBuilder.RenameIndex(
                name: "IX_Experience_ResumeId",
                table: "Experiences",
                newName: "IX_Experiences_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateSkill_SkillId",
                table: "CandidateSkills",
                newName: "IX_CandidateSkills_SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateSkill_ResumeId",
                table: "CandidateSkills",
                newName: "IX_CandidateSkills_ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateSkills",
                table: "CandidateSkills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BussinessIndustrys",
                table: "BussinessIndustrys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateSkills_Resumes_ResumeId",
                table: "CandidateSkills",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateSkills_Skills_SkillId",
                table: "CandidateSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_BussinessIndustrys_BussinessIndustryId",
                table: "Companies",
                column: "BussinessIndustryId",
                principalTable: "BussinessIndustrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Resumes_ResumeId",
                table: "Experiences",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateSkills_Resumes_ResumeId",
                table: "CandidateSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateSkills_Skills_SkillId",
                table: "CandidateSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_BussinessIndustrys_BussinessIndustryId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Resumes_ResumeId",
                table: "Experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateSkills",
                table: "CandidateSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BussinessIndustrys",
                table: "BussinessIndustrys");

            migrationBuilder.RenameTable(
                name: "Experiences",
                newName: "Experience");

            migrationBuilder.RenameTable(
                name: "CandidateSkills",
                newName: "CandidateSkill");

            migrationBuilder.RenameTable(
                name: "BussinessIndustrys",
                newName: "BussinessIndustry");

            migrationBuilder.RenameIndex(
                name: "IX_Experiences_ResumeId",
                table: "Experience",
                newName: "IX_Experience_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateSkills_SkillId",
                table: "CandidateSkill",
                newName: "IX_CandidateSkill_SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateSkills_ResumeId",
                table: "CandidateSkill",
                newName: "IX_CandidateSkill_ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experience",
                table: "Experience",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateSkill",
                table: "CandidateSkill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BussinessIndustry",
                table: "BussinessIndustry",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateSkill_Resumes_ResumeId",
                table: "CandidateSkill",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateSkill_Skills_SkillId",
                table: "CandidateSkill",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_BussinessIndustry_BussinessIndustryId",
                table: "Companies",
                column: "BussinessIndustryId",
                principalTable: "BussinessIndustry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Resumes_ResumeId",
                table: "Experience",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
