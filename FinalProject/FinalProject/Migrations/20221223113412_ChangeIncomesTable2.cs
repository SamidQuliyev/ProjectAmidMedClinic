using Microsoft.EntityFrameworkCore.Migrations;

namespace AmidmedClinic.Migrations
{
    public partial class ChangeIncomesTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sender",
                table: "Incomes",
                newName: "ByWho");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ByWho",
                table: "Incomes",
                newName: "Sender");
        }
    }
}
