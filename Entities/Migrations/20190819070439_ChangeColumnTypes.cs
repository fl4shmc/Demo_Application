using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DemoApplication.Entities.Migrations
{
    public partial class ChangeColumnTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Student",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                );

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Student",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                );

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Teacher",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                );

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Teacher",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                );

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Program",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                );

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Program",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
