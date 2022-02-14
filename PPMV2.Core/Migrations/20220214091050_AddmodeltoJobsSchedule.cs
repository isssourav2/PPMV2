using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPMV2.Core.Migrations
{
    public partial class AddmodeltoJobsSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FileProcessingTemplatesId",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FileProcessingTemplatesId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FileProcessingTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiskCoreTemplateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileProcessingTemplates", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_FileProcessingTemplatesId",
                table: "Tags",
                column: "FileProcessingTemplatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_FileProcessingTemplatesId",
                table: "Applications",
                column: "FileProcessingTemplatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_FileProcessingTemplates_FileProcessingTemplatesId",
                table: "Applications",
                column: "FileProcessingTemplatesId",
                principalTable: "FileProcessingTemplates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_FileProcessingTemplates_FileProcessingTemplatesId",
                table: "Tags",
                column: "FileProcessingTemplatesId",
                principalTable: "FileProcessingTemplates",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_FileProcessingTemplates_FileProcessingTemplatesId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_FileProcessingTemplates_FileProcessingTemplatesId",
                table: "Tags");

            migrationBuilder.DropTable(
                name: "FileProcessingTemplates");

            migrationBuilder.DropIndex(
                name: "IX_Tags_FileProcessingTemplatesId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Applications_FileProcessingTemplatesId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "FileProcessingTemplatesId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "FileProcessingTemplatesId",
                table: "Applications");
        }
    }
}
