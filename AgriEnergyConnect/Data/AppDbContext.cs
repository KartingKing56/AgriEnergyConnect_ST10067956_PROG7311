using Microsoft.EntityFrameworkCore;
using AgriEnergyConnect.Models;

namespace AgriEnergyConnect.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne<Farmer>()
                .WithMany()
                .HasForeignKey(p => p.FarmerId);

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, Username = "Admin", Password = "Admin", FirstName = "admin", LastName = "admin", EmployeeNumber = 0, Position = "Admin" },
                new Employee { EmployeeId = 2, Username = "Employee", Password = "Employee", FirstName = "employee", LastName = "employee", EmployeeNumber = 1, Position = "Employee" },
                new Employee { EmployeeId = 3, Username = "employee_karen", Password = "pass456", FirstName = "Karen", LastName = "Johnson", EmployeeNumber = 2002, Position = "Employee" },
                new Employee { EmployeeId = 4, Username = "employee_steve", Password = "pass789", FirstName = "Steve", LastName = "Wilson", EmployeeNumber = 2003, Position = "Employee" },
                new Employee { EmployeeId = 5, Username = "employee_linda", Password = "pass101", FirstName = "Linda", LastName = "Martinez", EmployeeNumber = 2004, Position = "Employee" },
                new Employee { EmployeeId = 6, Username = "employee_mark", Password = "pass202", FirstName = "Mark", LastName = "Brown", EmployeeNumber = 2005, Position = "Employee" }
            );

            modelBuilder.Entity<Farmer>().HasData(
                new Farmer { FarmerId = 1, Username = "Farmer", Password = "Farmer", FirstName = "farmer", LastName = "farmer", CompanyName = "Green Farms", Address = "123 Farm Lane", PhoneNumber = "555-1234", Email = "john@example.com", TypeOfProduce = "Fruits" },
                new Farmer { FarmerId = 2, Username = "golden_fields", Password = "farmer2pass", FirstName = "Alice", LastName = "Smith", CompanyName = "Golden Fields", Address = "456 Wheat Rd", PhoneNumber = "555-5678", Email = "alice@example.com", TypeOfProduce = "Grains" },
                new Farmer { FarmerId = 3, Username = "sunrise_organics", Password = "farmer3pass", FirstName = "Michael", LastName = "Thompson", CompanyName = "Sunrise Organics", Address = "789 Organic St", PhoneNumber = "555-7890", Email = "michael@example.com", TypeOfProduce = "Vegetables" },
                new Farmer { FarmerId = 4, Username = "harvest_fresh", Password = "farmer4pass", FirstName = "Emma", LastName = "Williams", CompanyName = "Harvest Fresh", Address = "321 Fresh Ave", PhoneNumber = "555-1111", Email = "emma@example.com", TypeOfProduce = "Dairy" },
                new Farmer { FarmerId = 5, Username = "silver_meadows", Password = "farmer5pass", FirstName = "Daniel", LastName = "Brown", CompanyName = "Silver Meadows", Address = "654 Meadow Rd", PhoneNumber = "555-2222", Email = "daniel@example.com", TypeOfProduce = "Livestock" },
                new Farmer { FarmerId = 6, Username = "pure_grains", Password = "farmer6pass", FirstName = "Sophia", LastName = "Garcia", CompanyName = "Pure Grains", Address = "987 Grain St", PhoneNumber = "555-3333", Email = "sophia@example.com", TypeOfProduce = "Grains" },
                new Farmer { FarmerId = 7, Username = "blueberry_farm", Password = "farmer7pass", FirstName = "David", LastName = "Martinez", CompanyName = "Blueberry Farm", Address = "741 Berry Lane", PhoneNumber = "555-4444", Email = "david@example.com", TypeOfProduce = "Berries" },
                new Farmer { FarmerId = 8, Username = "organic_harvest", Password = "farmer8pass", FirstName = "Olivia", LastName = "Hernandez", CompanyName = "Organic Harvest", Address = "852 Harvest Rd", PhoneNumber = "555-5555", Email = "olivia@example.com", TypeOfProduce = "Vegetables" },
                new Farmer { FarmerId = 9, Username = "pasture_perfect", Password = "farmer9pass", FirstName = "Jacob", LastName = "Lopez", CompanyName = "Pasture Perfect", Address = "963 Pasture St", PhoneNumber = "555-6666", Email = "jacob@example.com", TypeOfProduce = "Dairy" },
                new Farmer { FarmerId = 10, Username = "green_leaf", Password = "farmer10pass", FirstName = "Ava", LastName = "Rodriguez", CompanyName = "Green Leaf Farms", Address = "159 Leaf Rd", PhoneNumber = "555-7777", Email = "ava@example.com", TypeOfProduce = "Herbs" }
            );

            modelBuilder.Entity<Product>().HasData(
                // Fruits & Vegetables
                new Product { ProductId = 1, ProductName = "Organic Apples", ProductCode = "APL123", PricePerKg = 4.99M, HarvestDate = new DateTime(2025, 04, 15), FarmerId = 1 },
                new Product { ProductId = 2, ProductName = "Fresh Tomatoes", ProductCode = "TOM789", PricePerKg = 3.00M, HarvestDate = new DateTime(2025, 02, 10), FarmerId = 3 },
                new Product { ProductId = 3, ProductName = "Sweet Corn", ProductCode = "CRN234", PricePerKg = 2.75M, HarvestDate = new DateTime(2025, 06, 05), FarmerId = 2 },
                new Product { ProductId = 4, ProductName = "Organic Carrots", ProductCode = "CAR567", PricePerKg = 2.10M, HarvestDate = new DateTime(2025, 05, 18), FarmerId = 4 },
                new Product { ProductId = 5, ProductName = "Fresh Strawberries", ProductCode = "STR789", PricePerKg = 6.00M, HarvestDate = new DateTime(2025, 07, 08), FarmerId = 7 },
                new Product { ProductId = 6, ProductName = "Blueberries", ProductCode = "BLU567", PricePerKg = 7.00M, HarvestDate = new DateTime(2025, 07, 22), FarmerId = 7 },
                new Product { ProductId = 7, ProductName = "Bell Peppers", ProductCode = "BPR321", PricePerKg = 3.50M, HarvestDate = new DateTime(2025, 06, 30), FarmerId = 3 },

                // Grains & Seeds
                new Product { ProductId = 8, ProductName = "Golden Wheat", ProductCode = "WHT456", PricePerKg = 2.50M, HarvestDate = new DateTime(2025, 03, 20), FarmerId = 2 },
                new Product { ProductId = 9, ProductName = "Brown Rice", ProductCode = "RCE987", PricePerKg = 3.20M, HarvestDate = new DateTime(2025, 08, 15), FarmerId = 6 },
                new Product { ProductId = 10, ProductName = "Barley", ProductCode = "BRL654", PricePerKg = 2.80M, HarvestDate = new DateTime(2025, 09, 05), FarmerId = 6 },
                new Product { ProductId = 11, ProductName = "Chia Seeds", ProductCode = "CHA321", PricePerKg = 10.75M, HarvestDate = new DateTime(2025, 05, 12), FarmerId = 8 },
                new Product { ProductId = 12, ProductName = "Sunflower Seeds", ProductCode = "SUN789", PricePerKg = 5.40M, HarvestDate = new DateTime(2025, 06, 28), FarmerId = 5 },

                // Dairy & Livestock
                new Product { ProductId = 13, ProductName = "Whole Milk", ProductCode = "MLK102", PricePerKg = 4.00M, HarvestDate = new DateTime(2025, 07, 20), FarmerId = 9 },
                new Product { ProductId = 14, ProductName = "Cheddar Cheese", ProductCode = "CHE221", PricePerKg = 8.99M, HarvestDate = new DateTime(2025, 07, 31), FarmerId = 9 },
                new Product { ProductId = 15, ProductName = "Free-Range Eggs", ProductCode = "EGG321", PricePerKg = 6.00M, HarvestDate = new DateTime(2025, 01, 25), FarmerId = 4 },
                new Product { ProductId = 16, ProductName = "Grass-Fed Beef", ProductCode = "BEEF222", PricePerKg = 10.50M, HarvestDate = new DateTime(2025, 06, 12), FarmerId = 5 },
                new Product { ProductId = 17, ProductName = "Pasture-Raised Chicken", ProductCode = "CHK333", PricePerKg = 8.75M, HarvestDate = new DateTime(2025, 06, 25), FarmerId = 5 },
                new Product { ProductId = 18, ProductName = "Organic Goat Milk", ProductCode = "GMLK777", PricePerKg = 5.50M, HarvestDate = new DateTime(2025, 04, 30), FarmerId = 9 },

                // Herbs & Specialty Items
                new Product { ProductId = 19, ProductName = "Fresh Basil", ProductCode = "BSL555", PricePerKg = 12.99M, HarvestDate = new DateTime(2025, 03, 15), FarmerId = 10 },
                new Product { ProductId = 20, ProductName = "Rosemary", ProductCode = "ROS444", PricePerKg = 14.00M, HarvestDate = new DateTime(2025, 05, 05), FarmerId = 10 },
                new Product { ProductId = 21, ProductName = "Fresh Honey", ProductCode = "HNY999", PricePerKg = 15.50M, HarvestDate = new DateTime(2025, 08, 01), FarmerId = 6 },
                new Product { ProductId = 22, ProductName = "Almonds", ProductCode = "ALM555", PricePerKg = 11.25M, HarvestDate = new DateTime(2025, 06, 10), FarmerId = 5 },

                // More produce to reach 40 items
                new Product { ProductId = 23, ProductName = "Cucumber", ProductCode = "CUC303", PricePerKg = 2.50M, HarvestDate = new DateTime(2025, 04, 22), FarmerId = 3 },
                new Product { ProductId = 24, ProductName = "Pineapple", ProductCode = "PIN202", PricePerKg = 5.99M, HarvestDate = new DateTime(2025, 06, 11), FarmerId = 1 },
                new Product { ProductId = 25, ProductName = "Pumpkin", ProductCode = "PMP808", PricePerKg = 4.75M, HarvestDate = new DateTime(2025, 10, 05), FarmerId = 4 },
                new Product { ProductId = 26, ProductName = "Walnuts", ProductCode = "WAL555", PricePerKg = 9.99M, HarvestDate = new DateTime(2025, 09, 20), FarmerId = 5 },
                new Product { ProductId = 27, ProductName = "Lettuce", ProductCode = "LET777", PricePerKg = 3.25M, HarvestDate = new DateTime(2025, 05, 19), FarmerId = 2 }
            );
        }
    }
}