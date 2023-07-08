using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class car_eklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelYil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kilometre = table.Column<double>(type: "float", nullable: false),
                    YakitTürü = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BagajHacmi = table.Column<double>(type: "float", nullable: false),
                    Şanzıman = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arac", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arac");
        }
    }
}
