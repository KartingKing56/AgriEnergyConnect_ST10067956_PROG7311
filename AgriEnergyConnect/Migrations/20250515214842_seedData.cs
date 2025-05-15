using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgriEnergyConnect.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeNumber", "FirstName", "LastName", "Password", "Position", "Username" },
                values: new object[,]
                {
                    { 1, 0, "admin", "admin", "Admin", "Admin", "Admin" },
                    { 2, 1, "employee", "employee", "Employee", "Employee", "Employee" },
                    { 3, 2002, "Karen", "Johnson", "pass456", "Employee", "employee_karen" },
                    { 4, 2003, "Steve", "Wilson", "pass789", "Employee", "employee_steve" },
                    { 5, 2004, "Linda", "Martinez", "pass101", "Employee", "employee_linda" },
                    { 6, 2005, "Mark", "Brown", "pass202", "Employee", "employee_mark" }
                });

            migrationBuilder.InsertData(
                table: "Farmers",
                columns: new[] { "FarmerId", "Address", "CompanyName", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "TypeOfProduce", "Username" },
                values: new object[,]
                {
                    { 1, "123 Farm Lane", "Green Farms", "john@example.com", "farmer", "farmer", "Farmer", "555-1234", "Fruits", "Farmer" },
                    { 2, "456 Wheat Rd", "Golden Fields", "alice@example.com", "Alice", "Smith", "farmer2pass", "555-5678", "Grains", "golden_fields" },
                    { 3, "789 Organic St", "Sunrise Organics", "michael@example.com", "Michael", "Thompson", "farmer3pass", "555-7890", "Vegetables", "sunrise_organics" },
                    { 4, "321 Fresh Ave", "Harvest Fresh", "emma@example.com", "Emma", "Williams", "farmer4pass", "555-1111", "Dairy", "harvest_fresh" },
                    { 5, "654 Meadow Rd", "Silver Meadows", "daniel@example.com", "Daniel", "Brown", "farmer5pass", "555-2222", "Livestock", "silver_meadows" },
                    { 6, "987 Grain St", "Pure Grains", "sophia@example.com", "Sophia", "Garcia", "farmer6pass", "555-3333", "Grains", "pure_grains" },
                    { 7, "741 Berry Lane", "Blueberry Farm", "david@example.com", "David", "Martinez", "farmer7pass", "555-4444", "Berries", "blueberry_farm" },
                    { 8, "852 Harvest Rd", "Organic Harvest", "olivia@example.com", "Olivia", "Hernandez", "farmer8pass", "555-5555", "Vegetables", "organic_harvest" },
                    { 9, "963 Pasture St", "Pasture Perfect", "jacob@example.com", "Jacob", "Lopez", "farmer9pass", "555-6666", "Dairy", "pasture_perfect" },
                    { 10, "159 Leaf Rd", "Green Leaf Farms", "ava@example.com", "Ava", "Rodriguez", "farmer10pass", "555-7777", "Herbs", "green_leaf" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "FarmerId", "HarvestDate", "PricePerKg", "ProductCode", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m, "APL123", "Organic Apples" },
                    { 2, 3, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.00m, "TOM789", "Fresh Tomatoes" },
                    { 3, 2, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.75m, "CRN234", "Sweet Corn" },
                    { 4, 4, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.10m, "CAR567", "Organic Carrots" },
                    { 5, 7, new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.00m, "STR789", "Fresh Strawberries" },
                    { 6, 7, new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.00m, "BLU567", "Blueberries" },
                    { 7, 3, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.50m, "BPR321", "Bell Peppers" },
                    { 8, 2, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.50m, "WHT456", "Golden Wheat" },
                    { 9, 6, new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.20m, "RCE987", "Brown Rice" },
                    { 10, 6, new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.80m, "BRL654", "Barley" },
                    { 11, 8, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.75m, "CHA321", "Chia Seeds" },
                    { 12, 5, new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.40m, "SUN789", "Sunflower Seeds" },
                    { 13, 9, new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.00m, "MLK102", "Whole Milk" },
                    { 14, 9, new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.99m, "CHE221", "Cheddar Cheese" },
                    { 15, 4, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.00m, "EGG321", "Free-Range Eggs" },
                    { 16, 5, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.50m, "BEEF222", "Grass-Fed Beef" },
                    { 17, 5, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.75m, "CHK333", "Pasture-Raised Chicken" },
                    { 18, 9, new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.50m, "GMLK777", "Organic Goat Milk" },
                    { 19, 10, new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.99m, "BSL555", "Fresh Basil" },
                    { 20, 10, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.00m, "ROS444", "Rosemary" },
                    { 21, 6, new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.50m, "HNY999", "Fresh Honey" },
                    { 22, 5, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.25m, "ALM555", "Almonds" },
                    { 23, 3, new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.50m, "CUC303", "Cucumber" },
                    { 24, 1, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.99m, "PIN202", "Pineapple" },
                    { 25, 4, new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.75m, "PMP808", "Pumpkin" },
                    { 26, 5, new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.99m, "WAL555", "Walnuts" },
                    { 27, 2, new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.25m, "LET777", "Lettuce" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumn: "FarmerId",
                keyValue: 10);
        }
    }
}
