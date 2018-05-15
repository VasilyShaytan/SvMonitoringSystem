using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SvMonitoringSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicParameters",
                columns: table => new
                {
                    BasicParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Acronym = table.Column<string>(nullable: true),
                    DataRange = table.Column<string>(nullable: true),
                    DataSource = table.Column<string>(nullable: true),
                    Pgl = table.Column<int>(nullable: false),
                    Pgn = table.Column<int>(nullable: false),
                    SpnName = table.Column<string>(nullable: true),
                    SpnNameRu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicParameters", x => x.BasicParameterId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Mark = table.Column<string>(nullable: true),
                    ModelType = table.Column<string>(nullable: true),
                    OverallDimensions = table.Column<string>(nullable: true),
                    UsefulVolume = table.Column<int>(nullable: false),
                    VehicleType = table.Column<string>(nullable: true),
                    YearIssue = table.Column<int>(nullable: false),
                    СarryingСapacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    ParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BasicParameterId = table.Column<int>(nullable: false),
                    BasicParameterTimeValue = table.Column<DateTime>(nullable: false),
                    BasicParameterValue = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.ParameterId);
                    table.ForeignKey(
                        name: "FK_Parameters_BasicParameters_BasicParameterId",
                        column: x => x.BasicParameterId,
                        principalTable: "BasicParameters",
                        principalColumn: "BasicParameterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parameters_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parameters_BasicParameterId",
                table: "Parameters",
                column: "BasicParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_Parameters_VehicleId",
                table: "Parameters",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "BasicParameters");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
