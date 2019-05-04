using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuyubApp.API.Migrations
{
    public partial class AddedIuranEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IuranNonWajibs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TanggalTransaksi = table.Column<DateTime>(nullable: false),
                    Tahun = table.Column<int>(nullable: false),
                    Bulan = table.Column<int>(nullable: false),
                    Deskripsi = table.Column<string>(nullable: true),
                    IuranBayar = table.Column<int>(nullable: false),
                    RumahId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IuranNonWajibs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IuranNonWajibs_Rumahs_RumahId",
                        column: x => x.RumahId,
                        principalTable: "Rumahs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IuranWajibs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TanggalTransaksi = table.Column<DateTime>(nullable: false),
                    Tahun = table.Column<int>(nullable: false),
                    Bulan = table.Column<int>(nullable: false),
                    Nama = table.Column<string>(nullable: true),
                    IPLSesuaiAturan = table.Column<int>(nullable: false),
                    IPLAktual = table.Column<int>(nullable: false),
                    IPLBayar = table.Column<int>(nullable: false),
                    RumahId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IuranWajibs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IuranWajibs_Rumahs_RumahId",
                        column: x => x.RumahId,
                        principalTable: "Rumahs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IuranNonWajibs_RumahId",
                table: "IuranNonWajibs",
                column: "RumahId");

            migrationBuilder.CreateIndex(
                name: "IX_IuranWajibs_RumahId",
                table: "IuranWajibs",
                column: "RumahId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IuranNonWajibs");

            migrationBuilder.DropTable(
                name: "IuranWajibs");
        }
    }
}
