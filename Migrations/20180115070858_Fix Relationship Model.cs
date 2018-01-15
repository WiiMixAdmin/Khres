using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Khres.Migrations
{
    public partial class FixRelationshipModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Employees_EmployeeId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_EmployeeId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Positions");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PositionId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Positions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_EmployeeId",
                table: "Positions",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Employees_EmployeeId",
                table: "Positions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
