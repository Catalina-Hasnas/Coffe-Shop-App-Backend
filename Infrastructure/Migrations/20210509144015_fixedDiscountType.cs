using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class fixedDiscountType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Promotions",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Discount",
                value: 50.55m);

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Discount",
                value: 20m);

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Discount",
                value: 70.3m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Discount",
                table: "Promotions",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Discount",
                value: 50.55f);

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Discount",
                value: 20f);

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Discount",
                value: 70.3f);
        }
    }
}
