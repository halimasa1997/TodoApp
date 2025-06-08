using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApps.Migrations
{
    /// <inheritdoc />
    public partial class todoo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "piriority",
                table: "Todos",
                newName: "priority");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "priority",
                table: "Todos",
                newName: "priority");
        }
    }
}
