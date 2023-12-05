using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class UpdateNotificationEntity_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Notifications",
                type: "ntext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(604), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(873), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(875), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(876), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(878), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(883), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(884), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(886), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(888), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(890), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(893), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(894), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(896), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(948), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(950), new DateTime(2023, 11, 24, 18, 5, 1, 267, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8449), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8462), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8464), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8465), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8466), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8468), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8470), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8471), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8472), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8474), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8475), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8476), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8478), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8479), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8480), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8481), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8482), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8485), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8486), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8487), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8488), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8489), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8492), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8494), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8495), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8499), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8501), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8502), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8505), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8507), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8509), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8511), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8512), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8513), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8514), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8516), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8517), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8518), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8519), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8520), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8521), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8522), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8524), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8525), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8526), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8527), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8528), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8529), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8530), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8532), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8533), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8534), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8535), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8536), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8537), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8539), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8547), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8549), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8551), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8553), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8556), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8557), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8558), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8561), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8562), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8563), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8564), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8565), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8566), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8568), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8571), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8573), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8574), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8576), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8577), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8578), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8579), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8583), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8584), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8585), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8586), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8587), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8588), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8589), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8591), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8592), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8593), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8594), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8595), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8596), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8597), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8599), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8600), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8601), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8602), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8603), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8605), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8606), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8607), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8608), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8609), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8611), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8613), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8614), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8615), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8616), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8617), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8618), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8619), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8622), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8627), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8628), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8629), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8631), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8641), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8645), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8647), new DateTime(2023, 11, 24, 18, 5, 1, 270, DateTimeKind.Local).AddTicks(8647) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Notifications");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldNullable: true);

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
        }
    }
}
