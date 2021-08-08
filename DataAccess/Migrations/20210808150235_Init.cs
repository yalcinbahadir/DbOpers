using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMarried = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 1, "Genk", "IT" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 2, "Tongeren", "HR" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 3, "Hasselt", "Production" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DepartmentId", "Description", "Email", "FirstName", "Gender", "ImageUrl", "IsMarried", "LastName", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Description of John", "John@test.com", "John&", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 23, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Description of Hans", "Sam@test.com", "Natalie", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 22, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Description of Tom", "John@test.com", "Arya", 0, "https://via.placeholder.com/150", false, "Zomer", 2500.5678m },
                    { 12, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Description of Donald", "Donald@test.com", "Silvia", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 11, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Description of Ceyn", "Ceyn@test.com", "Patricia", 1, "https://via.placeholder.com/150", true, "Winter", 2500.5678m },
                    { 10, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Description of Hans", "Sam@test.com", "Natalie", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 9, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Description of Tom", "John@test.com", "Arya", 0, "https://via.placeholder.com/150", false, "Zomer", 2500.5678m },
                    { 21, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Description of Donald", "Donald@test.com", "Roni", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 20, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Description of Ceyn", "Ceyn@test.com", "Mark", 1, "https://via.placeholder.com/150", true, "Winter", 2500.5678m },
                    { 19, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Description of Hans", "Sam@test.com", "Hans", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 18, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Description of Tom", "John@test.com", "Tom", 0, "https://via.placeholder.com/150", false, "Zomer", 2500.5678m },
                    { 8, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Description of Donald", "Donald@test.com", "Roni", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 7, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Description of Ceyn", "Ceyn@test.com", "Mark", 1, "https://via.placeholder.com/150", true, "Winter", 2500.5678m },
                    { 6, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Description of Hans", "Sam@test.com", "Hans", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 5, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Description of Tom", "John@test.com", "Tom", 0, "https://via.placeholder.com/150", false, "Zomer", 2500.5678m },
                    { 17, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Description of Donald", "Donald@test.com", "Donald", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 16, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Description of Ceyn", "Ceyn@test.com", "Ceyn", 1, "https://via.placeholder.com/150", true, "Winter", 2500.5678m },
                    { 15, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Description of Sam", "Sam@test.com", "Sam", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 14, new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Description of John", "John@test.com", "John&", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 4, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Description of Donald", "Donald@test.com", "Donald", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 3, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Description of Ceyn", "Ceyn@test.com", "Ceyn", 1, "https://via.placeholder.com/150", true, "Winter", 2500.5678m },
                    { 2, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Description of Sam", "Sam@test.com", "Sam", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m },
                    { 24, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Description of Ceyn", "Ceyn@test.com", "Patricia", 1, "https://via.placeholder.com/150", true, "Winter", 2500.5678m },
                    { 25, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Description of Donald", "Donald@test.com", "Silvia", 0, "https://via.placeholder.com/150", false, "Winter", 2500.5678m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
