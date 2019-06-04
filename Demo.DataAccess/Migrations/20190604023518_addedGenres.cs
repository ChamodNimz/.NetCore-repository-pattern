using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.DataAccess.Migrations
{
    public partial class addedGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Author_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Books_BookId",
                table: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Genre_BookId",
                table: "Genre");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Genre",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookId",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Author_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_BookId",
                table: "Books",
                column: "BookId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Author_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_BookId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Genre",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Books",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Genre_BookId",
                table: "Genre",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Author_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Books_BookId",
                table: "Genre",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
