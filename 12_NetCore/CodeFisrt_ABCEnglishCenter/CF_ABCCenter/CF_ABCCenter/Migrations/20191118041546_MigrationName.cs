using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CF_ABCCenter.Migrations
{
    public partial class MigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageName = table.Column<string>(maxLength: 100, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    LanguageModelLanguageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_Languages_Languages_LanguageModelLanguageId",
                        column: x => x.LanguageModelLanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    LevelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LevelName = table.Column<string>(maxLength: 100, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    LevelModelLevelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.LevelId);
                    table.ForeignKey(
                        name: "FK_Levels_Levels_LevelModelLevelId",
                        column: x => x.LevelModelLevelId,
                        principalTable: "Levels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    IMG = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Sex = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    LevelId = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Languages_LanguageModelLanguageId",
                table: "Languages",
                column: "LanguageModelLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_LevelModelLevelId",
                table: "Levels",
                column: "LevelModelLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LanguageId",
                table: "Students",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LevelId",
                table: "Students",
                column: "LevelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Levels");
        }
    }
}
