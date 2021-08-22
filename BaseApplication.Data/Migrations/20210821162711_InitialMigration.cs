using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseApplication.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[] { 1, new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(6999), "C# ile ilgili güncel bilgiler", true, false, new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7254), "C#" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[] { 2, new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7492), "C++ ile ilgili güncel bilgiler", true, false, new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7493), "C++" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[] { 3, new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7496), "JavaScript ile ilgili güncel bilgiler", true, false, new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7497), "JavaScript" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedDate", "Thumbnail", "Title" },
                values: new object[] { 1, 1, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(749), new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(490), true, false, new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(756), "default.jpg", "C# 9.0 makalesi" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedDate", "Thumbnail", "Title" },
                values: new object[] { 2, 2, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(765), new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(764), true, false, new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(766), "default.jpg", "C++ 11 ve 19 Yenilikleri" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedDate", "Thumbnail", "Title" },
                values: new object[] { 3, 3, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(771), new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(769), true, false, new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(771), "default.jpg", "JavaScript Makalesi" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
