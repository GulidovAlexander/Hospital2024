using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorClient.Migrations
{
    /// <inheritdoc />
    public partial class AddedPatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportSerial = table.Column<int>(type: "int", nullable: false),
                    PassportNumber = table.Column<int>(type: "int", nullable: false),
                    PlaceOfWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsurencePolicyNumber = table.Column<long>(type: "bigint", nullable: false),
                    InsurencePolicyPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsurencyCompany = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
