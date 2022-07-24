using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileWithDataAccess.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileExpriences_profiles_ProfileId",
                table: "ProfileExpriences");

            migrationBuilder.DropColumn(
                name: "ProfiletId",
                table: "ProfileExpriences");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "ProfileExpriences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileExpriences_profiles_ProfileId",
                table: "ProfileExpriences",
                column: "ProfileId",
                principalTable: "profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileExpriences_profiles_ProfileId",
                table: "ProfileExpriences");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "ProfileExpriences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProfiletId",
                table: "ProfileExpriences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileExpriences_profiles_ProfileId",
                table: "ProfileExpriences",
                column: "ProfileId",
                principalTable: "profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
