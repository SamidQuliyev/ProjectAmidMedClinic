using Microsoft.EntityFrameworkCore.Migrations;

namespace AmidmedClinic.Migrations
{
    public partial class ChangeExpensesTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ByWho",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ByWho",
                table: "Expenses");
        }
    }
}
