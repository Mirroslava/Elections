using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectionLand.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElectionId",
                table: "Elections",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Elections",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Elections_ElectionId",
                table: "Elections",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Elections_UserId",
                table: "Elections",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Elections_Elections_ElectionId",
                table: "Elections",
                column: "ElectionId",
                principalTable: "Elections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Elections_Users_UserId",
                table: "Elections",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elections_Elections_ElectionId",
                table: "Elections");

            migrationBuilder.DropForeignKey(
                name: "FK_Elections_Users_UserId",
                table: "Elections");

            migrationBuilder.DropIndex(
                name: "IX_Elections_ElectionId",
                table: "Elections");

            migrationBuilder.DropIndex(
                name: "IX_Elections_UserId",
                table: "Elections");

            migrationBuilder.DropColumn(
                name: "ElectionId",
                table: "Elections");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Elections");
        }
    }
}
