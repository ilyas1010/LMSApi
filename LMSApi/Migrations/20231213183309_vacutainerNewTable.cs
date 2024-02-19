using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSApi.Migrations
{
    /// <inheritdoc />
    public partial class vacutainerNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vacutainers",
                columns: table => new
                {
                    VacutainerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacutainerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacutainers", x => x.VacutainerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacutainers");
        }
    }
}
