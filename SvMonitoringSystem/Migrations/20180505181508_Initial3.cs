using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SvMonitoringSystem.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleGroupId",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleGroupId",
                table: "Vehicles",
                column: "VehicleGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleGroups_VehicleGroupId",
                table: "Vehicles",
                column: "VehicleGroupId",
                principalTable: "VehicleGroups",
                principalColumn: "VehicleGroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleGroups_VehicleGroupId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VehicleGroupId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleGroupId",
                table: "Vehicles");
        }
    }
}
