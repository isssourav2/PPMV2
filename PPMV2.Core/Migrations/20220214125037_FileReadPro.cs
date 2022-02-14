using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPMV2.Core.Migrations
{
    public partial class FileReadPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileReads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileProcessingTemplateId = table.Column<int>(type: "int", nullable: false),
                    BasedOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellOrHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellOrHeaderValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DearchValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadFromNextColCell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SheetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileReads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileReads_FileProcessingTemplates_FileProcessingTemplateId",
                        column: x => x.FileProcessingTemplateId,
                        principalTable: "FileProcessingTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileReads_FileProcessingTemplateId",
                table: "FileReads",
                column: "FileProcessingTemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileReads");
        }
    }
}
