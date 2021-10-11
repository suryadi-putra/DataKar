using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataKar.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "karyawans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telepon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TLahir = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_karyawans", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "karyawans");
        }
    }
}
