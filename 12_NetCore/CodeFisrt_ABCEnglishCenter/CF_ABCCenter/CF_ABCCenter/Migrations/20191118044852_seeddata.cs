using Microsoft.EntityFrameworkCore.Migrations;

namespace CF_ABCCenter.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "IsDelete", "LanguageName" },
                values: new object[,]
                {
                    { 1, false, "English" },
                    { 2, false, "Laos" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "LevelId", "IsDelete", "LevelName" },
                values: new object[,]
                {
                    { 1, false, "A" },
                    { 2, false, "B" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 2);
        }
    }
}
