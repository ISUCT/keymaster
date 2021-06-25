namespace Infrastructure.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keys_Teachers_TeacherId",
                table: "Keys");

            migrationBuilder.DropIndex(
                name: "IX_Keys_TeacherId",
                table: "Keys");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Keys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Keys",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Keys_TeacherId",
                table: "Keys",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keys_Teachers_TeacherId",
                table: "Keys",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
