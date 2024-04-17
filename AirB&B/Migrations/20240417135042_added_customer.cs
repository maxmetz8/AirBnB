using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirB_B.Migrations
{
    /// <inheritdoc />
    public partial class added_customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "NdeJong@gmail.com", "Nora", "De Jong" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
