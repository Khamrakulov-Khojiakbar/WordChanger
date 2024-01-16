using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WinformsMicrosoft.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IllnessCategory",
                table: "complaints");

            migrationBuilder.AddColumn<int>(
                name: "IllnessCategoryId",
                table: "complaints",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "IllnessCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IllnessCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_complaints_IllnessCategoryId",
                table: "complaints",
                column: "IllnessCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_complaints_IllnessCategory_IllnessCategoryId",
                table: "complaints",
                column: "IllnessCategoryId",
                principalTable: "IllnessCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_complaints_IllnessCategory_IllnessCategoryId",
                table: "complaints");

            migrationBuilder.DropTable(
                name: "IllnessCategory");

            migrationBuilder.DropIndex(
                name: "IX_complaints_IllnessCategoryId",
                table: "complaints");

            migrationBuilder.DropColumn(
                name: "IllnessCategoryId",
                table: "complaints");

            migrationBuilder.AddColumn<string>(
                name: "IllnessCategory",
                table: "complaints",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
