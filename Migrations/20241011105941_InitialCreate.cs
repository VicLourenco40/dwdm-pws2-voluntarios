using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dwdm_pws2_voluntarios.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voluntario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Apelido = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Nif = table.Column<int>(type: "INTEGER", nullable: false),
                    Armazem = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voluntario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voluntario");
        }
    }
}
