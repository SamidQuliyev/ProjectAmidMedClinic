using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmidmedClinic.Migrations
{
    public partial class CreateKassaTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kassa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    LastModifiedMoney = table.Column<int>(type: "int", nullable: false),
                    LastModified = table.Column<int>(type: "int", nullable: false),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kassa", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kassa",
                columns: new[] { "Id", "Balance", "LastModified", "LastModifiedMoney", "LastModifiedTime" },
                values: new object[] { 1, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kassa");
        }
    }
}
