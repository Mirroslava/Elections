using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectionLand.Migrations
{
    public partial class AddNewColomn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elections_Elections_ElectionId",
                table: "Elections");

            migrationBuilder.DropIndex(
                name: "IX_Elections_ElectionId",
                table: "Elections");

            migrationBuilder.DropColumn(
                name: "ElectionId",
                table: "Elections");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElectionId",
                table: "StatusToUsers",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_StatusToUsers_ElectionId",
                table: "StatusToUsers",
                column: "ElectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusToUsers_Elections_ElectionId",
                table: "StatusToUsers",
                column: "ElectionId",
                principalTable: "Elections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatusToUsers_Elections_ElectionId",
                table: "StatusToUsers");

            migrationBuilder.DropIndex(
                name: "IX_StatusToUsers_ElectionId",
                table: "StatusToUsers");

            migrationBuilder.DropColumn(
                name: "ElectionId",
                table: "StatusToUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ElectionId",
                table: "Elections",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Elections_ElectionId",
                table: "Elections",
                column: "ElectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Elections_Elections_ElectionId",
                table: "Elections",
                column: "ElectionId",
                principalTable: "Elections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
