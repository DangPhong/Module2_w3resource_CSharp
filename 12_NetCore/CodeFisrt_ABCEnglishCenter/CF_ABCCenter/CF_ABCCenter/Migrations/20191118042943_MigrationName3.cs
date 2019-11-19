using Microsoft.EntityFrameworkCore.Migrations;

namespace CF_ABCCenter.Migrations
{
    public partial class MigrationName3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Languages_LanguageModelLanguageId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Levels_Levels_LevelModelLevelId",
                table: "Levels");

            migrationBuilder.DropIndex(
                name: "IX_Levels_LevelModelLevelId",
                table: "Levels");

            migrationBuilder.DropIndex(
                name: "IX_Languages_LanguageModelLanguageId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "LevelModelLevelId",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "LanguageModelLanguageId",
                table: "Languages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LevelModelLevelId",
                table: "Levels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanguageModelLanguageId",
                table: "Languages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Levels_LevelModelLevelId",
                table: "Levels",
                column: "LevelModelLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_LanguageModelLanguageId",
                table: "Languages",
                column: "LanguageModelLanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Languages_LanguageModelLanguageId",
                table: "Languages",
                column: "LanguageModelLanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Levels_Levels_LevelModelLevelId",
                table: "Levels",
                column: "LevelModelLevelId",
                principalTable: "Levels",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
