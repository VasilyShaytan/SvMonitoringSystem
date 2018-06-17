using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SvMonitoringSystem.Migrations
{
    public partial class RemoveCapacity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverallDimensions",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "UsefulVolume",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "СarryingСapacity",
                table: "Vehicles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OverallDimensions",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsefulVolume",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "СarryingСapacity",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0);
        }
    }
}
