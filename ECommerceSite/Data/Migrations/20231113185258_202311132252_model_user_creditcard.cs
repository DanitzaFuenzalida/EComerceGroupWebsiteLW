using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class _202311132252_model_user_creditcard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreditCardNumber",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreditCardNumber",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Interests",
                table: "User");
        }
    }
}
