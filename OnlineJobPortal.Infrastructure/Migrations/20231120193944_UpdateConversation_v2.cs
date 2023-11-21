using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineJobPortal.Infrastructure.Migrations
{
    public partial class UpdateConversation_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversations_JobPosts_JobPostId",
                table: "Conversations");

            migrationBuilder.RenameColumn(
                name: "JobPostId",
                table: "Conversations",
                newName: "ApplyId");

            migrationBuilder.RenameIndex(
                name: "IX_Conversations_JobPostId",
                table: "Conversations",
                newName: "IX_Conversations_ApplyId");

            migrationBuilder.AddColumn<int>(
                name: "ConversationId",
                table: "Applys",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Conversations_Applys_ApplyId",
                table: "Conversations",
                column: "ApplyId",
                principalTable: "Applys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversations_Applys_ApplyId",
                table: "Conversations");

            migrationBuilder.DropColumn(
                name: "ConversationId",
                table: "Applys");

            migrationBuilder.RenameColumn(
                name: "ApplyId",
                table: "Conversations",
                newName: "JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_Conversations_ApplyId",
                table: "Conversations",
                newName: "IX_Conversations_JobPostId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Conversations_JobPosts_JobPostId",
                table: "Conversations",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
