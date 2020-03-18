using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFData.Migrations.History
{
    public partial class InitH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataChangeHistories",
                columns: table => new
                {
                    DataChangeHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityType = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    SerilzeDate = table.Column<string>(nullable: true),
                    RegsiterationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataChangeHistories", x => x.DataChangeHistoryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataChangeHistories");
        }
    }
}
