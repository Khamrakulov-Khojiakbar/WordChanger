using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinformsMicrosoft.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_complaints_IllnessCategory_IllnessCategoryId",
                table: "complaints");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IllnessCategory",
                table: "IllnessCategory");

            migrationBuilder.RenameTable(
                name: "IllnessCategory",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_complaints_illnessCategory_IllnessCategoryId",
                table: "complaints");

            migrationBuilder.DropPrimaryKey(
                name: "PK_illnessCategory",
                table: "illnessCategory");

            migrationBuilder.RenameTable(
                name: "illnessCategory",
                newName: "IllnessCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IllnessCategory",
                table: "IllnessCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_complaints_IllnessCategory_IllnessCategoryId",
                table: "complaints",
                column: "IllnessCategoryId",
                principalTable: "IllnessCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
