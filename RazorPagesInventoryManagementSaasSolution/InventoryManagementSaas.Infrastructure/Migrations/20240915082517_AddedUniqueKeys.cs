using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSaas.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedUniqueKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tenant_Host",
                schema: "dbo",
                table: "Tenant",
                column: "Host",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tenant_Name",
                schema: "dbo",
                table: "Tenant",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_Name",
                schema: "dbo",
                table: "Supplier",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_Name",
                schema: "dbo",
                table: "Inventory",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_Name",
                schema: "dbo",
                table: "Company",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_Name",
                schema: "dbo",
                table: "Category",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tenant_Host",
                schema: "dbo",
                table: "Tenant");

            migrationBuilder.DropIndex(
                name: "IX_Tenant_Name",
                schema: "dbo",
                table: "Tenant");

            migrationBuilder.DropIndex(
                name: "IX_Supplier_Name",
                schema: "dbo",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_Name",
                schema: "dbo",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Company_Name",
                schema: "dbo",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Category_Name",
                schema: "dbo",
                table: "Category");
        }
    }
}
