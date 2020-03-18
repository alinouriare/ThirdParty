using Microsoft.EntityFrameworkCore.Migrations;

namespace EFData.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "JobDatas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "JobDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
