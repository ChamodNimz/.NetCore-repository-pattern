using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.DataAccess.Migrations
{
    public partial class addedGenresCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_BookId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Genre",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookId",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_BookId",
                table: "Books",
                column: "BookId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
