using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPMV2.Core.Migrations
{
    public partial class MenuMasterIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleMenuMappings_MenuMasters_MenuId",
                table: "RoleMenuMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleMenuMappings_Roles_RoleId",
                table: "RoleMenuMappings");

            migrationBuilder.DropIndex(
                name: "IX_RoleMenuMappings_MenuId",
                table: "RoleMenuMappings");

            migrationBuilder.DropIndex(
                name: "IX_RoleMenuMappings_RoleId",
                table: "RoleMenuMappings");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "RoleMenuMappings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "RoleMenuMappings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuMappings_MenuId",
                table: "RoleMenuMappings",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuMappings_RoleId",
                table: "RoleMenuMappings",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleMenuMappings_MenuMasters_MenuId",
                table: "RoleMenuMappings",
                column: "MenuId",
                principalTable: "MenuMasters",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleMenuMappings_Roles_RoleId",
                table: "RoleMenuMappings",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId");
        }
    }
}
