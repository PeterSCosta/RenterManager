using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RenterManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDocumentToClientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "Clients");
        }
    }
}
