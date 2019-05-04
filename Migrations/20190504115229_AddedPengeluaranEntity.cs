using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuyubApp.API.Migrations
{
    public partial class AddedPengeluaranEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pengeluarans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TanggalTransaksi = table.Column<DateTime>(nullable: false),
                    Tahun = table.Column<int>(nullable: false),
                    Bulan = table.Column<int>(nullable: false),
                    Tipe = table.Column<string>(nullable: true),
                    Deskripsi = table.Column<string>(nullable: true),
                    RpBayar = table.Column<int>(nullable: false),
                    RtId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pengeluarans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pengeluarans_RTs_RtId",
                        column: x => x.RtId,
                        principalTable: "RTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pengeluarans_RtId",
                table: "Pengeluarans",
                column: "RtId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pengeluarans");
        }
    }
}
