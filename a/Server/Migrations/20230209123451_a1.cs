using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace a.Server.Migrations
{
    /// <inheritdoc />
    public partial class a1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "بروید ای حریفان بکشید یار ما را . به من آورید آخر صنم گریز پا رادم سخت گرم دارد که به جادوی و افسون . بزند گره بر آب او و ببند او هوا ر ا ", "./img/a.jpg", 11, "بکشید یار ما را" },
                    { 2, "به ترانه های شیرین به بهانه های زرین . بکشید سوی خانه مه خوب خوش لقا را", "./img/b.jpg", 33, "به ترانه های شیرین" },
                    { 3, "وگر او به وعده گوید که دمی دگر بیایم . همه وعده مکر باشد بفریبد او شما را", "./img/c.jpg", 3, "دمی دگر" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
