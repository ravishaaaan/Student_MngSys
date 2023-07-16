using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GropuProject.Migrations.Person1
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "StudentModules");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "StudentModules",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
