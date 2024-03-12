using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcertApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class addImageToConcertModelMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcertImage",
                table: "Concerts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcertImage",
                table: "Concerts");
        }
    }
}
