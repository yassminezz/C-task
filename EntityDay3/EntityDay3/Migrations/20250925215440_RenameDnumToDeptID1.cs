using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityDay3.Migrations
{
    /// <inheritdoc />
    public partial class RenameDnumToDeptID1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_DepartmentDeptID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_DepartmentDeptID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptID",
                table: "Projects");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DeptID",
                table: "Projects",
                column: "DeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_DeptID",
                table: "Projects",
                column: "DeptID",
                principalTable: "Departments",
                principalColumn: "DeptID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_DeptID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_DeptID",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptID",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DepartmentDeptID",
                table: "Projects",
                column: "DepartmentDeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_DepartmentDeptID",
                table: "Projects",
                column: "DepartmentDeptID",
                principalTable: "Departments",
                principalColumn: "DeptID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
