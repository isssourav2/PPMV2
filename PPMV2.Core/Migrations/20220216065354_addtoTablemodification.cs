using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPMV2.Core.Migrations
{
    public partial class addtoTablemodification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DearchValue",
                table: "FileReads",
                newName: "SearchValue");

            migrationBuilder.AddColumn<string>(
                name: "ConnectionType",
                table: "Connections",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConnectionType",
                table: "Connections");

            migrationBuilder.RenameColumn(
                name: "SearchValue",
                table: "FileReads",
                newName: "DearchValue");
        }
    }
}
