using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StaticKimlikKarti.Migrations
{
    /// <inheritdoc />
    public partial class DbYeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "user",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "user",
                newName: "Role");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "user",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "user",
                newName: "Email");
        }
    }
}
