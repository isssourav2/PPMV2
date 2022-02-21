using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPMV2.Core.Migrations
{
    public partial class FileProcessingTemplatesUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "RiskCoreTemplateId",
                table: "FileProcessingTemplates",
                type: "uniqueidentifier",
                nullable: true
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RiskCoreTemplateId",
                table: "FileProcessingTemplates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}
