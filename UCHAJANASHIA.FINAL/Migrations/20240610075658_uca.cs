using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCHAJANASHIA.FINAL.Migrations
{
    /// <inheritdoc />
    public partial class uca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birhtday = table.Column<DateOnly>(type: "date", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToyColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToyWeight = table.Column<float>(type: "real", nullable: true),
                    OwnerCatID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Toy_Cat_OwnerCatID",
                        column: x => x.OwnerCatID,
                        principalTable: "Cat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Toy_OwnerCatID",
                table: "Toy",
                column: "OwnerCatID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Toy");

            migrationBuilder.DropTable(
                name: "Cat");
        }
    }
}
