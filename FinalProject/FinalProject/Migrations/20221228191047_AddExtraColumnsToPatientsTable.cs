using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmidmedClinic.Migrations
{
    public partial class AddExtraColumnsToPatientsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laboratories");

            migrationBuilder.DropColumn(
                name: "IsDeactive",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "IsDeactive",
                table: "Expenses");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Patients");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeactive",
                table: "Incomes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeactive",
                table: "Expenses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Laboratories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratories", x => x.Id);
                });
        }
    }
}
