using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CHCManager.DataSet.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClinicianProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Clinicians");
        }
    }
}
