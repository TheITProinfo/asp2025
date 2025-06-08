using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Migrations
{
    /// <inheritdoc />
    public partial class AddemployeeImage02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "Employees",
                newName: "PhotoFileName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoFileName",
                table: "Employees",
                newName: "PhotoPath");
        }
    }
}
