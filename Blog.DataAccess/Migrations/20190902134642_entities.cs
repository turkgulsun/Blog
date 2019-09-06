using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.DataAccess.Migrations
{
    public partial class entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_ClassType_ClassTypeId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassLanguage_Class_ClassId",
                table: "ClassLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassLanguage_Language_LanguageId",
                table: "ClassLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_Content_Class_ClassId",
                table: "Content");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentLanguage_Content_ContentId",
                table: "ContentLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentLanguage_Language_LanguageId",
                table: "ContentLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                table: "Language");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContentLanguage",
                table: "ContentLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Content",
                table: "Content");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassType",
                table: "ClassType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassLanguage",
                table: "ClassLanguage");

            migrationBuilder.RenameTable(
                name: "Language",
                newName: "Languages");

            migrationBuilder.RenameTable(
                name: "ContentLanguage",
                newName: "ContentLanguages");

            migrationBuilder.RenameTable(
                name: "Content",
                newName: "Contents");

            migrationBuilder.RenameTable(
                name: "ClassType",
                newName: "ClassTypes");

            migrationBuilder.RenameTable(
                name: "ClassLanguage",
                newName: "ClassLanguages");

            migrationBuilder.RenameIndex(
                name: "IX_ContentLanguage_LanguageId",
                table: "ContentLanguages",
                newName: "IX_ContentLanguages_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ContentLanguage_ContentId",
                table: "ContentLanguages",
                newName: "IX_ContentLanguages_ContentId");

            migrationBuilder.RenameIndex(
                name: "IX_Content_ClassId",
                table: "Contents",
                newName: "IX_Contents_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassLanguage_LanguageId",
                table: "ClassLanguages",
                newName: "IX_ClassLanguages_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassLanguage_ClassId",
                table: "ClassLanguages",
                newName: "IX_ClassLanguages_ClassId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Languages",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Culture",
                table: "Languages",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContentLanguages",
                table: "ContentLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contents",
                table: "Contents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassTypes",
                table: "ClassTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassLanguages",
                table: "ClassLanguages",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "List",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Sort = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetaTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Page = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sort = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Target = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Width = table.Column<int>(nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banners_List_ListId",
                        column: x => x.ListId,
                        principalTable: "List",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ListId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListLanguages_List_ListId",
                        column: x => x.ListId,
                        principalTable: "List",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: true),
                    Target = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_List_ListId",
                        column: x => x.ListId,
                        principalTable: "List",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetaTagLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    MetaTagId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaTagLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MetaTagLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetaTagLanguages_MetaTags_MetaTagId",
                        column: x => x.MetaTagId,
                        principalTable: "MetaTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BannerLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Url = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    BannerId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BannerLanguages_Banners_BannerId",
                        column: x => x.BannerId,
                        principalTable: "Banners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BannerLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MenuId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuLanguages_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BannerLanguages_BannerId",
                table: "BannerLanguages",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_BannerLanguages_LanguageId",
                table: "BannerLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Banners_ListId",
                table: "Banners",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_ListLanguages_LanguageId",
                table: "ListLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ListLanguages_ListId",
                table: "ListLanguages",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuLanguages_LanguageId",
                table: "MenuLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuLanguages_MenuId",
                table: "MenuLanguages",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ListId",
                table: "Menus",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_MetaTagLanguages_LanguageId",
                table: "MetaTagLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_MetaTagLanguages_MetaTagId",
                table: "MetaTagLanguages",
                column: "MetaTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_ClassTypes_ClassTypeId",
                table: "Class",
                column: "ClassTypeId",
                principalTable: "ClassTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassLanguages_Class_ClassId",
                table: "ClassLanguages",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassLanguages_Languages_LanguageId",
                table: "ClassLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentLanguages_Contents_ContentId",
                table: "ContentLanguages",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentLanguages_Languages_LanguageId",
                table: "ContentLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Class_ClassId",
                table: "Contents",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_ClassTypes_ClassTypeId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassLanguages_Class_ClassId",
                table: "ClassLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassLanguages_Languages_LanguageId",
                table: "ClassLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentLanguages_Contents_ContentId",
                table: "ContentLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentLanguages_Languages_LanguageId",
                table: "ContentLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Class_ClassId",
                table: "Contents");

            migrationBuilder.DropTable(
                name: "BannerLanguages");

            migrationBuilder.DropTable(
                name: "ListLanguages");

            migrationBuilder.DropTable(
                name: "MenuLanguages");

            migrationBuilder.DropTable(
                name: "MetaTagLanguages");

            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "MetaTags");

            migrationBuilder.DropTable(
                name: "List");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contents",
                table: "Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContentLanguages",
                table: "ContentLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassTypes",
                table: "ClassTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassLanguages",
                table: "ClassLanguages");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "Language");

            migrationBuilder.RenameTable(
                name: "Contents",
                newName: "Content");

            migrationBuilder.RenameTable(
                name: "ContentLanguages",
                newName: "ContentLanguage");

            migrationBuilder.RenameTable(
                name: "ClassTypes",
                newName: "ClassType");

            migrationBuilder.RenameTable(
                name: "ClassLanguages",
                newName: "ClassLanguage");

            migrationBuilder.RenameIndex(
                name: "IX_Contents_ClassId",
                table: "Content",
                newName: "IX_Content_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ContentLanguages_LanguageId",
                table: "ContentLanguage",
                newName: "IX_ContentLanguage_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ContentLanguages_ContentId",
                table: "ContentLanguage",
                newName: "IX_ContentLanguage_ContentId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassLanguages_LanguageId",
                table: "ClassLanguage",
                newName: "IX_ClassLanguage_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassLanguages_ClassId",
                table: "ClassLanguage",
                newName: "IX_ClassLanguage_ClassId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Language",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "Culture",
                table: "Language",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                table: "Language",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Content",
                table: "Content",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContentLanguage",
                table: "ContentLanguage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassType",
                table: "ClassType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassLanguage",
                table: "ClassLanguage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_ClassType_ClassTypeId",
                table: "Class",
                column: "ClassTypeId",
                principalTable: "ClassType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassLanguage_Class_ClassId",
                table: "ClassLanguage",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassLanguage_Language_LanguageId",
                table: "ClassLanguage",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Content_Class_ClassId",
                table: "Content",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentLanguage_Content_ContentId",
                table: "ContentLanguage",
                column: "ContentId",
                principalTable: "Content",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentLanguage_Language_LanguageId",
                table: "ContentLanguage",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
