using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2LINQ.Migrations
{
    public partial class fixedfkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentÄmne_Ämnen_StudentID",
                table: "studentÄmne");

            migrationBuilder.AddForeignKey(
                name: "FK_studentÄmne_Ämnen_ÄmneID",
                table: "studentÄmne",
                column: "ÄmneID",
                principalTable: "Ämnen",
                principalColumn: "ÄmneID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentÄmne_Ämnen_ÄmneID",
                table: "studentÄmne");

            migrationBuilder.AddForeignKey(
                name: "FK_studentÄmne_Ämnen_StudentID",
                table: "studentÄmne",
                column: "StudentID",
                principalTable: "Ämnen",
                principalColumn: "ÄmneID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
