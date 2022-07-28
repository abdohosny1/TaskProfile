using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileWithDataAccess.Migrations
{
    public partial class adduserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "ProfileExpriences",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ProfileExpriences");
        }
    }
}
