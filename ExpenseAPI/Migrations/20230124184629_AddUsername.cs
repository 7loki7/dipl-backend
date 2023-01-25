using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseAPI.Migrations
{
    public partial class AddUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsernameCheck",
                table: "ExpenseDetails",
                newName: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "ExpenseDetails",
                newName: "UsernameCheck");
        }
    }
}
