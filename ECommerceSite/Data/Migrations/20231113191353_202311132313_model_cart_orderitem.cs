using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class _202311132313_model_cart_orderitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Product");
        }
    }
}
