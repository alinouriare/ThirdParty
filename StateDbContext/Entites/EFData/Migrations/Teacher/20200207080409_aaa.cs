using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFData.Migrations.Teacher
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InsertBy",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdateBytBy",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updatedate",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdateBytBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Updatedate",
                table: "Students");
        }
    }
}
