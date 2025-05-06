using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddBidCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BidCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 37, 41, 65, DateTimeKind.Utc).AddTicks(1029), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 39, 41, 65, DateTimeKind.Utc).AddTicks(1040), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 36, 41, 65, DateTimeKind.Utc).AddTicks(1048), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 37, 41, 65, DateTimeKind.Utc).AddTicks(1054), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 40, 41, 65, DateTimeKind.Utc).AddTicks(1057), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 37, 41, 65, DateTimeKind.Utc).AddTicks(1063), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 35, 41, 65, DateTimeKind.Utc).AddTicks(1085), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 37, 41, 65, DateTimeKind.Utc).AddTicks(1088), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 38, 41, 65, DateTimeKind.Utc).AddTicks(1092), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 41, 41, 65, DateTimeKind.Utc).AddTicks(1097), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 40, 41, 65, DateTimeKind.Utc).AddTicks(1100), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 37, 41, 65, DateTimeKind.Utc).AddTicks(1106), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 37, 41, 65, DateTimeKind.Utc).AddTicks(1109), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 38, 41, 65, DateTimeKind.Utc).AddTicks(1115), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 37, 41, 65, DateTimeKind.Utc).AddTicks(1118), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 41, 41, 65, DateTimeKind.Utc).AddTicks(1123), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 36, 41, 65, DateTimeKind.Utc).AddTicks(1127), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 36, 41, 65, DateTimeKind.Utc).AddTicks(1169), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 39, 41, 65, DateTimeKind.Utc).AddTicks(1172), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 37, 41, 65, DateTimeKind.Utc).AddTicks(1177), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 38, 41, 65, DateTimeKind.Utc).AddTicks(1181), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 40, 41, 65, DateTimeKind.Utc).AddTicks(1186), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 43, 41, 65, DateTimeKind.Utc).AddTicks(1189), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 40, 41, 65, DateTimeKind.Utc).AddTicks(1194), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 41, 41, 65, DateTimeKind.Utc).AddTicks(1196), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 37, 41, 65, DateTimeKind.Utc).AddTicks(1199), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 38, 41, 65, DateTimeKind.Utc).AddTicks(1204), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuctionEndTime", "BidCount" },
                values: new object[] { new DateTime(2025, 5, 6, 9, 41, 41, 65, DateTimeKind.Utc).AddTicks(1207), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BidCount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 52, 7, 478, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 49, 7, 478, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 53, 7, 478, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 48, 7, 478, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 51, 7, 478, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 54, 7, 478, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 53, 7, 478, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 51, 7, 478, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 54, 7, 478, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 49, 7, 478, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 49, 7, 478, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 52, 7, 478, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 51, 7, 478, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 53, 7, 478, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 56, 7, 478, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 53, 7, 478, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 54, 7, 478, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 50, 7, 478, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 51, 7, 478, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "AuctionEndTime",
                value: new DateTime(2025, 5, 4, 12, 54, 7, 478, DateTimeKind.Utc).AddTicks(9980));
        }
    }
}
