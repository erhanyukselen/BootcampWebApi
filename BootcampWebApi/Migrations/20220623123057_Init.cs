using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootcampWebApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bootcamps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bootcamps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BootcampId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bootcamps",
                columns: new[] { "Id", "Date", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 23, 12, 30, 57, 621, DateTimeKind.Utc).AddTicks(3766), "Arvato1" },
                    { 2, new DateTime(2022, 6, 23, 12, 30, 57, 621, DateTimeKind.Utc).AddTicks(3769), "Arvato2" },
                    { 3, new DateTime(2022, 6, 23, 12, 30, 57, 621, DateTimeKind.Utc).AddTicks(3770), "Arvato3" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BootcampId", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 0, "Ahmet", false },
                    { 2, 0, "Mehmet", false },
                    { 3, 0, "Enes", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bootcamps");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
