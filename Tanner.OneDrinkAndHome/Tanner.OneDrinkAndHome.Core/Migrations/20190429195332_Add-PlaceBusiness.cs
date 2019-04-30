using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tanner.OneDrinkAndHome.Core.Migrations
{
    public partial class AddPlaceBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PlaceID",
                table: "Party",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Party_PlaceID",
                table: "Party",
                column: "PlaceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Party_Place_PlaceID",
                table: "Party",
                column: "PlaceID",
                principalTable: "Place",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Party_Place_PlaceID",
                table: "Party");

            migrationBuilder.DropTable(
                name: "Place");

            migrationBuilder.DropIndex(
                name: "IX_Party_PlaceID",
                table: "Party");

            migrationBuilder.DropColumn(
                name: "PlaceID",
                table: "Party");
        }
    }
}
