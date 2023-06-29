using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTP0473.Migrations
{
    /// <inheritdoc />
    public partial class DTPcau3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DTP_cau3",
                columns: table => new
                {
                    Masinhvien = table.Column<string>(type: "TEXT", nullable: false),
                    Hovaten = table.Column<string>(type: "TEXT", nullable: false),
                    Diachi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTP_cau3", x => x.Masinhvien);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTP_cau3");
        }
    }
}
