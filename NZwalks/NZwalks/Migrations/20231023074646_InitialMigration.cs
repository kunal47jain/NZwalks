using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZwalks.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    Lat = table.Column<double>(type: "float", nullable: false),
                    Long = table.Column<double>(type: "float", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Walkdifficultie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    length = table.Column<double>(type: "float", nullable: false),
                    RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    walkdifficultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Walkdifficultie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Walks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    length = table.Column<double>(type: "float", nullable: false),
                    Regionid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    walkdifficultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Walks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Walks_Regions_RegionsId",
                        column: x => x.RegionsId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Walks_Walkdifficultie_walkdifficultyId",
                        column: x => x.walkdifficultyId,
                        principalTable: "Walkdifficultie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Walks_RegionsId",
                table: "Walks",
                column: "RegionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Walks_walkdifficultyId",
                table: "Walks",
                column: "walkdifficultyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Walks");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Walkdifficultie");
        }
    }
}
