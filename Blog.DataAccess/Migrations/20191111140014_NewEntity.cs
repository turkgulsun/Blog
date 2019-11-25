using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.DataAccess.Migrations
{
    public partial class NewEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "ClassLanguages",
                type: "nvarchar(Max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "ClassLanguages",
                type: "nvarchar(Max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "ClassLanguages",
                type: "nvarchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Class",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Class",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "ClassLanguages");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "ClassLanguages");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "ClassLanguages");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Class");
        }
    }
}
