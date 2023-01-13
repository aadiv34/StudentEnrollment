using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollment.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDBStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CId",
                table: "students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SId",
                table: "students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "SId",
                table: "students");
        }
    }
}
