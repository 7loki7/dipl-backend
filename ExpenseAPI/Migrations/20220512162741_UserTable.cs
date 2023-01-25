using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseAPI.Migrations
{
    public partial class UserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
