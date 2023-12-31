﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GropuProject.Migrations.Person1
{
    /// <inheritdoc />
    public partial class pw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProName = table.Column<string>(type: "TEXT", nullable: false),
                    ProPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    SalesTax = table.Column<int>(type: "INTEGER", nullable: false),
                    ProQuantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
