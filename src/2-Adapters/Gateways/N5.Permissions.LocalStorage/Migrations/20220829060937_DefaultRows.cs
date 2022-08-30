using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N5.Permissions.SQLServer.Migrations
{
    public partial class DefaultRows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "PermissionTypeId", "Description" },
                values: new object[,]
                {
                    { "1", "Basic" },
                    { "2", "Advance" },
                    { "3", "Expert" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "PermissionTypeId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "PermissionTypeId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "PermissionTypeId",
                keyValue: "3");
        }
    }
}
