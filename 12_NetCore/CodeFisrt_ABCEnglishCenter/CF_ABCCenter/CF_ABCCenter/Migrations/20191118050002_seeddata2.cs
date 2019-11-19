using Microsoft.EntityFrameworkCore.Migrations;

namespace CF_ABCCenter.Migrations
{
    public partial class seeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "IsDelete", "LanguageName" },
                values: new object[] { 1, false, "English" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "IsDelete", "LanguageName" },
                values: new object[] { 2, false, "Laos" });
        }
    }
}
