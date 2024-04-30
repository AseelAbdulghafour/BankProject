using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchManager", "EmployeeCount", "LocationName" },
                values: new object[] { "Abdulrahman", 7, "Alshamyia" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchManager", "EmployeeCount", "LocationName" },
                values: new object[] { "Yousef Alhumaidan", 12, "Alkaldiya" });
        }
    }
}
