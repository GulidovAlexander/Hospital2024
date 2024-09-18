using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorClient.Migrations
{
    /// <inheritdoc />
    public partial class RenameVisitDateForMedicalRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisiteData",
                table: "MedicalRecords",
                newName: "VisiteDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisiteDate",
                table: "MedicalRecords",
                newName: "VisiteData");
        }
    }
}
