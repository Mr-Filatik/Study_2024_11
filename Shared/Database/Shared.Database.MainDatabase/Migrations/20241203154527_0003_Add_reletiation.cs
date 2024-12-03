using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shared.Database.MainDatabase.Migrations
{
    /// <inheritdoc />
    public partial class _0003_Add_reletiation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AuthorId",
                table: "Messages",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_AuthorId",
                table: "Messages",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_AuthorId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_AuthorId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Messages");
        }
    }
}
