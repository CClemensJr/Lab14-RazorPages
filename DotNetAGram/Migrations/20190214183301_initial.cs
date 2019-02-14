using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetAGram.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "Description", "ImageURL", "Title" },
                values: new object[,]
                {
                    { 1, "Gunner and Yuna playing in snow at the dog park for the first time.", "https://placeimg.com/640/480/animals", "Dogs in the Snow" },
                    { 2, "Gunner and Yuna playing at the beach for the first time.", "https://placeimg.com/640/480/animals", "Dogs at the Beach" },
                    { 3, "Gunner and Yuna playing in a volcano for the first time.", "https://placeimg.com/640/480/animals", "Dogs in the Volcano" },
                    { 4, "Gunner and Yuna playing in the jungle for the first time.", "https://placeimg.com/640/480/animals", "Dogs in the Jungle" },
                    { 5, "Gunner and Yuna playing in the White House for the first time.", "https://placeimg.com/640/480/animals", "Dogs in the Whitehouse" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
