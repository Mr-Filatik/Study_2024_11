using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shared.Database.MainDatabase.Migrations
{
    /// <inheritdoc />
    public partial class _0004_Add_attributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_AuthorId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "main_messages");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "main_messages",
                newName: "message_body");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "main_messages",
                newName: "UniqId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_AuthorId",
                table: "main_messages",
                newName: "IX_main_messages_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_main_messages",
                table: "main_messages",
                column: "UniqId");

            migrationBuilder.AddForeignKey(
                name: "FK_main_messages_Users_AuthorId",
                table: "main_messages",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_main_messages_Users_AuthorId",
                table: "main_messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_main_messages",
                table: "main_messages");

            migrationBuilder.RenameTable(
                name: "main_messages",
                newName: "Messages");

            migrationBuilder.RenameColumn(
                name: "message_body",
                table: "Messages",
                newName: "Body");

            migrationBuilder.RenameColumn(
                name: "UniqId",
                table: "Messages",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_main_messages_AuthorId",
                table: "Messages",
                newName: "IX_Messages_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_AuthorId",
                table: "Messages",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
