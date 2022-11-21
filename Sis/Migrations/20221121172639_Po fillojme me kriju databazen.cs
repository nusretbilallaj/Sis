using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sis.Migrations
{
    /// <inheritdoc />
    public partial class Pofillojmemekrijudatabazen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Komunat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komunat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studentet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KomunaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studentet_Komunat_KomunaId",
                        column: x => x.KomunaId,
                        principalTable: "Komunat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studentet_KomunaId",
                table: "Studentet",
                column: "KomunaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studentet");

            migrationBuilder.DropTable(
                name: "Komunat");
        }
    }
}
