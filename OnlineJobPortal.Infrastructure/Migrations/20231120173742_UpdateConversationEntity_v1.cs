using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class UpdateConversationEntity_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobPostId",
                table: "Conversations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2764), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2766), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2777), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2778), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2781), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 11, 21, 0, 37, 42, 288, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(369), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(372), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(374), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(375), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(377), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(379), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(380), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(382), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(385), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(386), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(388), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(390), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(391), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(392), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(395), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(396), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(397), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(400), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(402), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(403), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(407), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(408), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(413), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(416), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(418), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(422), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(423), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(425), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(428), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(431), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(433), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(435), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(436), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(437), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(444), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(445), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(446), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(447), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(448), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(451), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(452), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(453), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(454), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(456), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(457), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(458), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(459), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(462), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(465), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(468), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(471), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(472), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(475), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(478), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(479), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(480), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(481), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(482), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(483), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(484), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(486), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(488), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(489), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(490), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(491), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(492), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(493), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(495), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(496), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(499), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(502), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(503), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(505), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(507), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(510), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(511), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(513), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(514), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(515), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(516), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(520), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(522), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(531), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(532), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(535), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(536), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(537), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(538), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(539), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(541), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(543), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(544), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(545), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(546), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(548), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(549), new DateTime(2023, 11, 21, 0, 37, 42, 291, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_JobPostId",
                table: "Conversations",
                column: "JobPostId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Conversations_JobPosts_JobPostId",
                table: "Conversations",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversations_JobPosts_JobPostId",
                table: "Conversations");

            migrationBuilder.DropIndex(
                name: "IX_Conversations_JobPostId",
                table: "Conversations");

            migrationBuilder.DropColumn(
                name: "JobPostId",
                table: "Conversations");

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(434), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(448), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(451), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(452), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(455), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(457), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(458), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(459), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(462), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(468), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(471), new DateTime(2023, 11, 20, 16, 24, 15, 778, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8824), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8826), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8838), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8881), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8883), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8888), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8893), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8895), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8897), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8901), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8903), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8912), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8913), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8914), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8916), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8917), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8921), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8923), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8925), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8928), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8941), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8944), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8946), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8947), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8953), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8955), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8964), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8967), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8968), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8972), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8973), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8974), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8978), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8979), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8981), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8983), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8986), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8988), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8989), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8992), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8995), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8997), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(8999), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9003), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9004), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9005), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9006), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9007), new DateTime(2023, 11, 20, 16, 24, 15, 780, DateTimeKind.Local).AddTicks(9008) });
        }
    }
}
