using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinformsMicrosoft.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_complaints_illnesscategory_IllnessCategoryId",
                table: "complaints");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "illnesscategory",
                newName: "categoryname");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "illnesscategory",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IllnessCategoryId",
                table: "complaints",
                newName: "illnesscategoryid");

            migrationBuilder.RenameColumn(
                name: "ComplaintName",
                table: "complaints",
                newName: "complaintname");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "complaints",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_complaints_IllnessCategoryId",
                table: "complaints",
                newName: "IX_complaints_illnesscategoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_complaints_illnesscategory_illnesscategoryid",
                table: "complaints",
                column: "illnesscategoryid",
                principalTable: "illnesscategory",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_complaints_illnesscategory_illnesscategoryid",
                table: "complaints");

            migrationBuilder.RenameColumn(
                name: "categoryname",
                table: "illnesscategory",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "illnesscategory",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "illnesscategoryid",
                table: "complaints",
                newName: "IllnessCategoryId");

            migrationBuilder.RenameColumn(
                name: "complaintname",
                table: "complaints",
                newName: "ComplaintName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "complaints",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_complaints_illnesscategoryid",
                table: "complaints",
                newName: "IX_complaints_IllnessCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_complaints_illnesscategory_IllnessCategoryId",
                table: "complaints",
                column: "IllnessCategoryId",
                principalTable: "illnesscategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
