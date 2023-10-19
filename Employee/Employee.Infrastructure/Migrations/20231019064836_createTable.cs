using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class createTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Emp");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Emp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    SellPrice = table.Column<double>(type: "float", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryName", "Created", "CreatedBy", "Currency", "LastModified", "LastModifiedBy", "Status" },
                values: new object[] { 1, "Bangladesh", new DateTimeOffset(new DateTime(2023, 10, 19, 12, 48, 36, 623, DateTimeKind.Unspecified).AddTicks(6657), new TimeSpan(0, 6, 0, 0, 0)), "1", "BDT", new DateTimeOffset(new DateTime(2023, 10, 19, 12, 48, 36, 623, DateTimeKind.Unspecified).AddTicks(6685), new TimeSpan(0, 6, 0, 0, 0)), null, 1 });

            migrationBuilder.InsertData(
                schema: "Emp",
                table: "Product",
                columns: new[] { "Id", "BarCode", "CountryId", "Created", "CreatedBy", "Description", "ImagePath", "LastModified", "LastModifiedBy", "ProductName", "Rating", "SellPrice", "Status", "price" },
                values: new object[] { 1, "qoooo", 1, new DateTimeOffset(new DateTime(2023, 10, 19, 12, 48, 36, 623, DateTimeKind.Unspecified).AddTicks(9176), new TimeSpan(0, 6, 0, 0, 0)), "1", "aaaaaaaaaaaaaaaaaaaa", "", new DateTimeOffset(new DateTime(2023, 10, 19, 12, 48, 36, 623, DateTimeKind.Unspecified).AddTicks(9184), new TimeSpan(0, 6, 0, 0, 0)), null, "xyzz", 5.5, 30.0, 1, 20.0 });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CountryId", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "StateName", "Status" },
                values: new object[] { 1, 1, new DateTimeOffset(new DateTime(2023, 10, 19, 12, 48, 36, 624, DateTimeKind.Unspecified).AddTicks(893), new TimeSpan(0, 6, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(2023, 10, 19, 12, 48, 36, 624, DateTimeKind.Unspecified).AddTicks(900), new TimeSpan(0, 6, 0, 0, 0)), null, "Dhaka", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId",
                table: "Employees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StateId",
                table: "Employees",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CountryId",
                schema: "Emp",
                table: "Product",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductName",
                schema: "Emp",
                table: "Product",
                column: "ProductName");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Emp");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
