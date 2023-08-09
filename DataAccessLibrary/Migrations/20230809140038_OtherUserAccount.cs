using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLibrary.Migrations
{
    /// <inheritdoc />
    public partial class OtherUserAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OtherUserAccounts",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherUserAccounts", x => new { x.UserId, x.AccountId });
                    table.ForeignKey(
                        name: "FK_OtherUserAccounts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherUserAccounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OtherUserAccounts_AccountId",
                table: "OtherUserAccounts",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OtherUserAccounts");
        }
    }
}
