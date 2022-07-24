using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileWithDataAccess.Migrations
{
    public partial class addcurrent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Current",
                table: "ProfileExpriences",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Skill",
                table: "ProfileExpriences",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Current",
                table: "ProfileExpriences");

            migrationBuilder.DropColumn(
                name: "Skill",
                table: "ProfileExpriences");
        }
    }
}
