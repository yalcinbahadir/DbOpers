using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ColumnDesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name:"FullName",
                table:"Employees", 
                nullable:true);
            migrationBuilder.Sql(@"update Employees set fullname= firstname+' '+lastname;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
