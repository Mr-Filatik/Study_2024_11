using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shared.Database.MainDatabase.Migrations
{
    /// <inheritdoc />
    public partial class _0005_Add_fluent_api : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_main_messages_Users_AuthorId",
                table: "main_messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_main_messages",
                table: "main_messages");

            migrationBuilder.RenameTable(
                name: "main_messages",
                newName: "m_main_messages");

            migrationBuilder.RenameIndex(
                name: "IX_main_messages_AuthorId",
                table: "m_main_messages",
                newName: "IX_m_main_messages_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_main_messages",
                table: "m_main_messages",
                column: "UniqId");

            migrationBuilder.AddForeignKey(
                name: "FK_m_main_messages_Users_AuthorId",
                table: "m_main_messages",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_main_messages_Users_AuthorId",
                table: "m_main_messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_main_messages",
                table: "m_main_messages");

            migrationBuilder.RenameTable(
                name: "m_main_messages",
                newName: "main_messages");

            migrationBuilder.RenameIndex(
                name: "IX_m_main_messages_AuthorId",
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
    }
}
