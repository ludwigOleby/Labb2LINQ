using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2LINQ.Migrations
{
    public partial class initmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ämnen",
                columns: table => new
                {
                    ÄmneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ämnen", x => x.ÄmneID);
                });

            migrationBuilder.CreateTable(
                name: "Klasser",
                columns: table => new
                {
                    KlassID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlassNamn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klasser", x => x.KlassID);
                });

            migrationBuilder.CreateTable(
                name: "lärare",
                columns: table => new
                {
                    LärarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LärarNamn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lärare", x => x.LärarID);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentNamn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "lärareÄmnen",
                columns: table => new
                {
                    LärarID = table.Column<int>(nullable: false),
                    ÄmneID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lärareÄmnen", x => new { x.ÄmneID, x.LärarID });
                    table.ForeignKey(
                        name: "FK_lärareÄmnen_lärare_LärarID",
                        column: x => x.LärarID,
                        principalTable: "lärare",
                        principalColumn: "LärarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lärareÄmnen_Ämnen_ÄmneID",
                        column: x => x.ÄmneID,
                        principalTable: "Ämnen",
                        principalColumn: "ÄmneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "studentÄmne",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false),
                    ÄmneID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentÄmne", x => new { x.ÄmneID, x.StudentID });
                    table.ForeignKey(
                        name: "FK_studentÄmne_student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentÄmne_Ämnen_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Ämnen",
                        principalColumn: "ÄmneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lärareÄmnen_LärarID",
                table: "lärareÄmnen",
                column: "LärarID");

            migrationBuilder.CreateIndex(
                name: "IX_studentÄmne_StudentID",
                table: "studentÄmne",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klasser");

            migrationBuilder.DropTable(
                name: "lärareÄmnen");

            migrationBuilder.DropTable(
                name: "studentÄmne");

            migrationBuilder.DropTable(
                name: "lärare");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "Ämnen");
        }
    }
}
