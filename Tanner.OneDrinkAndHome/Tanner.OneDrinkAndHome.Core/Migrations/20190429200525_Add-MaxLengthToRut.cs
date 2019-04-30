using Microsoft.EntityFrameworkCore.Migrations;

namespace Tanner.OneDrinkAndHome.Core.Migrations
{
    public partial class AddMaxLengthToRut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RUT",
                table: "Customer",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RUT",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 12);
        }
    }
}
