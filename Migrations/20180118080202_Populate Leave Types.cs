using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Khres.Migrations
{
    public partial class PopulateLeaveTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {            
            migrationBuilder.Sql("INSERT INTO LeaveTypes(Label) VALUES('Annual Leave')");
            migrationBuilder.Sql("INSERT INTO LeaveTypes(Label) VALUES('Sick Leave')");
            migrationBuilder.Sql("INSERT INTO LeaveTypes(Label) VALUES('Special Leave')");
            migrationBuilder.Sql("INSERT INTO LeaveTypes(Label) VALUES('Public Holiday')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE LeaveTypes WHERE Id IN (SELECT Id FROM LeaveTypes WHERE Label IN ('Annual Leave', 'Sick Leave', 'Special Leave', 'Public Holiday'))");
        }
    }
}
