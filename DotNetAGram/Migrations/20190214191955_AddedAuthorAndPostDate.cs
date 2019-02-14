using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetAGram.Migrations
{
    public partial class AddedAuthorAndPostDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Posts",
                newName: "Author");

            migrationBuilder.AddColumn<DateTime>(
                name: "PostDate",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Author", "PostDate" },
                values: new object[] { "ChattleBrand65", new DateTime(2019, 2, 14, 11, 19, 55, 9, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Author", "PostDate" },
                values: new object[] { "ChattleBrand65", new DateTime(2019, 2, 14, 11, 19, 55, 12, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Author", "PostDate" },
                values: new object[] { "ChattleBrand65", new DateTime(2019, 2, 14, 11, 19, 55, 12, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Author", "PostDate" },
                values: new object[] { "ChattleBrand65", new DateTime(2019, 2, 14, 11, 19, 55, 12, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Author", "PostDate" },
                values: new object[] { "ChattleBrand65", new DateTime(2019, 2, 14, 11, 19, 55, 12, DateTimeKind.Local).AddTicks(1606) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostDate",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Posts",
                newName: "Title");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                column: "Title",
                value: "Dogs in the Snow");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                column: "Title",
                value: "Dogs at the Beach");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                column: "Title",
                value: "Dogs in the Volcano");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                column: "Title",
                value: "Dogs in the Jungle");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                column: "Title",
                value: "Dogs in the Whitehouse");
        }
    }
}
