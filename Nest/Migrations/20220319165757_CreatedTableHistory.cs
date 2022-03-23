using Microsoft.EntityFrameworkCore.Migrations;

namespace Nest.Migrations
{
    public partial class CreatedTableHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_performances",
                table: "performances");

            migrationBuilder.RenameTable(
                name: "performances",
                newName: "Performances");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Performances",
                table: "Performances",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "histories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_histories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "histories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Performances",
                table: "Performances");

            migrationBuilder.RenameTable(
                name: "Performances",
                newName: "performances");

            migrationBuilder.AddPrimaryKey(
                name: "PK_performances",
                table: "performances",
                column: "Id");
        }
    }
}
