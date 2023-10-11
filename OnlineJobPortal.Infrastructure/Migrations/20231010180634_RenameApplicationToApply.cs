using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class RenameApplicationToApply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Candidates_CandidateId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_JobPosts_JobPostId",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.RenameTable(
                name: "Applications",
                newName: "Applys");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_JobPostId",
                table: "Applys",
                newName: "IX_Applys_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_CandidateId",
                table: "Applys",
                newName: "IX_Applys_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applys",
                table: "Applys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applys_Candidates_CandidateId",
                table: "Applys",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applys_JobPosts_JobPostId",
                table: "Applys",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applys_Candidates_CandidateId",
                table: "Applys");

            migrationBuilder.DropForeignKey(
                name: "FK_Applys_JobPosts_JobPostId",
                table: "Applys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applys",
                table: "Applys");

            migrationBuilder.RenameTable(
                name: "Applys",
                newName: "Applications");

            migrationBuilder.RenameIndex(
                name: "IX_Applys_JobPostId",
                table: "Applications",
                newName: "IX_Applications_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_Applys_CandidateId",
                table: "Applications",
                newName: "IX_Applications_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Candidates_CandidateId",
                table: "Applications",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_JobPosts_JobPostId",
                table: "Applications",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
