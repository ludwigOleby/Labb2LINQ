using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2LINQ.Migrations
{
    public partial class kopplingklasser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KlasserKlassID",
                table: "student",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_student_KlasserKlassID",
                table: "student",
                column: "KlasserKlassID");

            migrationBuilder.AddForeignKey(
                name: "FK_student_Klasser_KlasserKlassID",
                table: "student",
                column: "KlasserKlassID",
                principalTable: "Klasser",
                principalColumn: "KlassID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_student_Klasser_KlasserKlassID",
                table: "student");

            migrationBuilder.DropIndex(
                name: "IX_student_KlasserKlassID",
                table: "student");

            migrationBuilder.DropColumn(
                name: "KlasserKlassID",
                table: "student");
        }
    }
}
