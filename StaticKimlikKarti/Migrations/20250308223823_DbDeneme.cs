using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StaticKimlikKarti.Migrations
{
    /// <inheritdoc />
    public partial class DbDeneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gorev",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarih = table.Column<byte>(type: "tinyint", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    yazigirin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gorev", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gorev");
        }
    }
}
