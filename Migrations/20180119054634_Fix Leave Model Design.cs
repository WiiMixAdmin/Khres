using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Khres.Migrations
{
    public partial class FixLeaveModelDesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLeaves_Employees_EmployeeId",
                table: "EmployeeLeaves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeLeaves",
                table: "EmployeeLeaves");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeLeaves_LeaveId",
                table: "EmployeeLeaves");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeLeaves");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Leaves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeLeaves",
                table: "EmployeeLeaves",
                columns: new[] { "LeaveId", "LeaveTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_EmployeeId",
                table: "Leaves",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leaves_Employees_EmployeeId",
                table: "Leaves",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leaves_Employees_EmployeeId",
                table: "Leaves");

            migrationBuilder.DropIndex(
                name: "IX_Leaves_EmployeeId",
                table: "Leaves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeLeaves",
                table: "EmployeeLeaves");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Leaves");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeLeaves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeLeaves",
                table: "EmployeeLeaves",
                columns: new[] { "EmployeeId", "LeaveId", "LeaveTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaves_LeaveId",
                table: "EmployeeLeaves",
                column: "LeaveId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLeaves_Employees_EmployeeId",
                table: "EmployeeLeaves",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
