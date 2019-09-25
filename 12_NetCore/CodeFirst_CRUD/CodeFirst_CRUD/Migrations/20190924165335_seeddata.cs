using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_CRUD.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Avatar", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[] { 1, "New York", null, "XYZ Inc", "Developer", "John", 30000f });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Avatar", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[] { 2, "New York", null, "ABC Inc", "Manager", "Chris", 50000f });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Avatar", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[] { 3, "New Delhi", null, "XYZ Inc", "Consultant", "Mukesh", 20000f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);
        }
    }
}
