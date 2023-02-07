using Microsoft.EntityFrameworkCore.Migrations;

namespace AmidmedClinic.Migrations
{
    public partial class ChangePatientsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_PatientNumbers_PatientNumberId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "PatientNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientNumberId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientNumberId",
                table: "Patients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientNumberId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PatientNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientNumbers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientNumberId",
                table: "Patients",
                column: "PatientNumberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_PatientNumbers_PatientNumberId",
                table: "Patients",
                column: "PatientNumberId",
                principalTable: "PatientNumbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
