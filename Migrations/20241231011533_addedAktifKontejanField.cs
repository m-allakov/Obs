using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obs.Migrations
{
    /// <inheritdoc />
    public partial class addedAktifKontejanField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AktifKontenjan",
                table: "Siniflar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AktifKontenjan",
                table: "Siniflar");
        }
    }
}
