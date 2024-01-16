using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinformsMicrosoft.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_complaints_illnessCategory_IllnessCategoryId",
                table: "complaints");

            migrationBuilder.DropPrimaryKey(
                name: "PK_illnessCategory",
                table: "illnessCategory");

            migrationBuilder.RenameTable(
                name: "illnessCategory",
                newName: "illnesscategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_illnesscategory",
                table: "illnesscategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_complaints_illnesscategory_IllnessCategoryId",
                table: "complaints",
                column: "IllnessCategoryId",
                principalTable: "illnesscategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_complaints_illnesscategory_IllnessCategoryId",
                table: "complaints");

            migrationBuilder.DropPrimaryKey(
                name: "PK_illnesscategory",
                table: "illnesscategory");

            migrationBuilder.RenameTable(
                name: "illnesscategory",
                newName: "illnessCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_illnessCategory",
                table: "illnessCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_complaints_illnessCategory_IllnessCategoryId",
                table: "complaints",
                column: "IllnessCategoryId",
                principalTable: "illnessCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
