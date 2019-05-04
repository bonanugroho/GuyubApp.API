using Microsoft.EntityFrameworkCore.Migrations;

namespace GuyubApp.API.Migrations
{
    public partial class AddedMasterEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RTs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nama = table.Column<string>(nullable: true),
                    RwId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RTs_RWs_RwId",
                        column: x => x.RwId,
                        principalTable: "RWs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bloks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nama = table.Column<string>(nullable: true),
                    NamaJalan = table.Column<string>(nullable: true),
                    RtId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bloks_RTs_RtId",
                        column: x => x.RtId,
                        principalTable: "RTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rumahs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NoRumah = table.Column<string>(nullable: true),
                    NamaKKWarga = table.Column<string>(nullable: true),
                    Dihuni = table.Column<int>(nullable: false),
                    IPLSesuaiAturan = table.Column<int>(nullable: false),
                    IPLAktual = table.Column<int>(nullable: false),
                    BlokId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rumahs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rumahs_Bloks_BlokId",
                        column: x => x.BlokId,
                        principalTable: "Bloks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bloks_RtId",
                table: "Bloks",
                column: "RtId");

            migrationBuilder.CreateIndex(
                name: "IX_RTs_RwId",
                table: "RTs",
                column: "RwId");

            migrationBuilder.CreateIndex(
                name: "IX_Rumahs_BlokId",
                table: "Rumahs",
                column: "BlokId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rumahs");

            migrationBuilder.DropTable(
                name: "Bloks");

            migrationBuilder.DropTable(
                name: "RTs");
        }
    }
}
