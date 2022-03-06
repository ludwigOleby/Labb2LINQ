using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2LINQ.Migrations
{
    public partial class Nykoppling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studentgrupp",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false),
                    LärarID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentgrupp", x => new { x.LärarID, x.StudentID });
                    table.ForeignKey(
                        name: "FK_Studentgrupp_lärare_LärarID",
                        column: x => x.LärarID,
                        principalTable: "lärare",
                        principalColumn: "LärarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Studentgrupp_student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studentgrupp_StudentID",
                table: "Studentgrupp",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studentgrupp");
        }
    }
}
