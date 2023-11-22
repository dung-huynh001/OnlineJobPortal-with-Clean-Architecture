using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class AddSaveCandidateEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaveCandidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveCandidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaveCandidates_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaveCandidates_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9674), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9677), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9682), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9688), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9691), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9693), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9695), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9702), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9704), new DateTime(2023, 11, 22, 20, 59, 26, 246, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2764), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2765), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2766), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2773), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2777), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2779), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2781), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2796), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2797), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2802), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2805), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2821), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2829), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2833), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2839), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2842), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2845), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2846), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2850), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2851), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2861), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2863), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2864), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2865), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2866), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2868), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2872), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2874), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2875), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2877), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2879), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2883), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2884), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2888), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2892), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2893), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2898), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2899), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2903), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2905), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2907), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2908), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2909), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2921), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2925), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2926), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2928), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2929), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2930), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2933), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2934), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2935), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2937), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2938), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2939), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2943), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2945), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2946), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2947), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2949), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2953), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2955), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2958), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2961), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2962), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2965), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2967), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2971), new DateTime(2023, 11, 22, 20, 59, 26, 250, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.CreateIndex(
                name: "IX_SaveCandidates_CandidateId",
                table: "SaveCandidates",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_SaveCandidates_CompanyId",
                table: "SaveCandidates",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaveCandidates");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1685), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1697), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1699), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1701), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1702), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1705), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1707), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1708), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1710), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1713), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1714), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1715), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1717), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1719), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1721), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 11, 21, 2, 39, 44, 293, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1291), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1301), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1302), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1304), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1305), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1307), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1308), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1310), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1311), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1313), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1314), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1316), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1317), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1318), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1320), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1321), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1322), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1324), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1325), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1327), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1328), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1329), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1330), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1332), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1333), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1335), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1337), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1338), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1339), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1340), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1342), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1381), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1383), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1385), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1387), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1390), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1391), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1392), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1393), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1395), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1396), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1397), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1398), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1400), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1401), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1402), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1405), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1406), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1407), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1408), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1410), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1411), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1412), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1413), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1415), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1416), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1417), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1420), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1421), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1422), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1424), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1426), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1427), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1428), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1429), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1431), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1432), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1433), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1435), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1436), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1437), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1438), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1440), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1441), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1442), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1444), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1445), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1446), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1447), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1449), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1450), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1451), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1452), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1454), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1455), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1456), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1457), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1459), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1460), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1461), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1462), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1464), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1465), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1466), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1468), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1469), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1470), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1471), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1473), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1474), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1475), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1476), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1478), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1479), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1480), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1481), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1482), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1484), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1485), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1489), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1490), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1491), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1493), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1494), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1495), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1496), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1497), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1539), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1542), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1544), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1547), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1548), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1549), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1550), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1552), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1553), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1554), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1555), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1556), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1558), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1559), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1560), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1562), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1563), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1564), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1567), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1568), new DateTime(2023, 11, 21, 2, 39, 44, 296, DateTimeKind.Local).AddTicks(1568) });
        }
    }
}
