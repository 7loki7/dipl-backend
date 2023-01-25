using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseAPI.Migrations
{
    public partial class AddUsernameCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ExpenseDetails");

            migrationBuilder.AddColumn<string>(
                name: "UsernameCheck",
                table: "ExpenseDetails",
                type: "nvarchar(15)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsernameCheck",
                table: "ExpenseDetails");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ExpenseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
