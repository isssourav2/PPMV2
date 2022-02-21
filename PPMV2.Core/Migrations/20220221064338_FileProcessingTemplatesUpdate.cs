using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPMV2.Core.Migrations
{
    public partial class FileProcessingTemplatesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobName",
                table: "FileProcessingTemplates",
                newName: "Username");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "FileProcessingTemplates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CSVDelimiter",
                table: "FileProcessingTemplates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsManipulation",
                table: "FileProcessingTemplates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "FileProcessingTemplates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreprocessedDeliveryPath",
                table: "FileProcessingTemplates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RiskCoreImportTemplateId",
                table: "FileProcessingTemplates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "FileProcessingTemplates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TextDelimiter",
                table: "FileProcessingTemplates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "FileProcessingTemplates");

            migrationBuilder.DropColumn(
                name: "CSVDelimiter",
                table: "FileProcessingTemplates");

            migrationBuilder.DropColumn(
                name: "IsManipulation",
                table: "FileProcessingTemplates");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "FileProcessingTemplates");

            migrationBuilder.DropColumn(
                name: "PreprocessedDeliveryPath",
                table: "FileProcessingTemplates");

            migrationBuilder.DropColumn(
                name: "RiskCoreImportTemplateId",
                table: "FileProcessingTemplates");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "FileProcessingTemplates");

            migrationBuilder.DropColumn(
                name: "TextDelimiter",
                table: "FileProcessingTemplates");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "FileProcessingTemplates",
                newName: "JobName");
        }
    }
}
