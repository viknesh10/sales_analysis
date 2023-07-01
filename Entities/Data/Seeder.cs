using Microsoft.EntityFrameworkCore;

namespace sales_analysis.Entities.Data
{
    public static class Seeder
    {
        public static void DataSeed(this ModelBuilder modelBuilder)
        {
            SeedLocationData(modelBuilder);
            SeedSalesData(modelBuilder);
        }

        static void SeedLocationData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
                new Location() { location_id = 1, name = "Chennai" },
                new Location() { location_id = 2, name = "Delhi" },
                new Location() { location_id = 3, name = "Mumbai" },
                new Location() { location_id = 4, name = "Bengaluru" },
                new Location() { location_id = 5, name = "Hyderabad" }
                );
        }

        static void SeedSalesData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesRecord>().HasData(
                new SalesRecord() { sales_id = 1, product_name = "VA1", location_id = 1, price = 8000, total_units = 10, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 2, product_name = "VA2", location_id = 1, price = 6000, total_units = 10, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 3, product_name = "VA3", location_id = 1, price = 9000, total_units = 10, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 4, product_name = "VA1", location_id = 2, price = 8000, total_units = 12, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 5, product_name = "VA2", location_id = 2, price = 6000, total_units = 30, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 6, product_name = "VA3", location_id = 2, price = 9000, total_units = 45, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 7, product_name = "VA1", location_id = 3, price = 8000, total_units = 15, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 8, product_name = "VA2", location_id = 3, price = 6000, total_units = 18, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 9, product_name = "VA3", location_id = 3, price = 9000, total_units = 8, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 10, product_name = "VA1", location_id = 4, price = 8000, total_units = 14, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 11, product_name = "VA2", location_id = 4, price = 6000, total_units = 20, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 12, product_name = "VA3", location_id = 4, price = 9000, total_units = 19, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 13, product_name = "VA1", location_id = 5, price = 8000, total_units = 22, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 14, product_name = "VA2", location_id = 5, price = 6000, total_units = 16, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { sales_id = 15, product_name = "VA3", location_id = 5, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 11) },

                new SalesRecord() { sales_id = 16, product_name = "VA1", location_id = 1, price = 8000, total_units = 20, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 17, product_name = "VA2", location_id = 1, price = 6000, total_units = 30, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 18, product_name = "VA3", location_id = 1, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 19, product_name = "VA1", location_id = 2, price = 8000, total_units = 14, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 20, product_name = "VA2", location_id = 2, price = 6000, total_units = 34, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 21, product_name = "VA3", location_id = 2, price = 9000, total_units = 56, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 22, product_name = "VA1", location_id = 3, price = 8000, total_units = 26, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 23, product_name = "VA2", location_id = 3, price = 6000, total_units = 33, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 24, product_name = "VA3", location_id = 3, price = 9000, total_units = 21, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 25, product_name = "VA1", location_id = 4, price = 8000, total_units = 30, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 26, product_name = "VA2", location_id = 4, price = 6000, total_units = 15, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 27, product_name = "VA3", location_id = 4, price = 9000, total_units = 18, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 28, product_name = "VA1", location_id = 5, price = 8000, total_units = 35, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 29, product_name = "VA2", location_id = 5, price = 6000, total_units = 18, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { sales_id = 30, product_name = "VA3", location_id = 5, price = 9000, total_units = 26, sales_date = new DateTime(2023, 6, 12) },

                new SalesRecord() { sales_id = 31, product_name = "VA1", location_id = 1, price = 8000, total_units = 45, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 32, product_name = "VA2", location_id = 1, price = 6000, total_units = 36, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 33, product_name = "VA3", location_id = 1, price = 9000, total_units = 78, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 34, product_name = "VA1", location_id = 2, price = 8000, total_units = 70, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 35, product_name = "VA2", location_id = 2, price = 6000, total_units = 67, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 36, product_name = "VA3", location_id = 2, price = 9000, total_units = 50, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 37, product_name = "VA1", location_id = 3, price = 8000, total_units = 50, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 38, product_name = "VA2", location_id = 3, price = 6000, total_units = 30, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 39, product_name = "VA3", location_id = 3, price = 9000, total_units = 70, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 40, product_name = "VA1", location_id = 4, price = 8000, total_units = 20, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 41, product_name = "VA2", location_id = 4, price = 6000, total_units = 13, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 42, product_name = "VA3", location_id = 4, price = 9000, total_units = 60, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 43, product_name = "VA1", location_id = 5, price = 8000, total_units = 33, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 44, product_name = "VA2", location_id = 5, price = 6000, total_units = 24, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { sales_id = 45, product_name = "VA3", location_id = 5, price = 9000, total_units = 17, sales_date = new DateTime(2023, 6, 13) },

                new SalesRecord() { sales_id = 46, product_name = "VA1", location_id = 1, price = 8000, total_units = 23, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 47, product_name = "VA2", location_id = 1, price = 6000, total_units = 12, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 48, product_name = "VA3", location_id = 1, price = 9000, total_units = 13, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 49, product_name = "VA1", location_id = 2, price = 8000, total_units = 100, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 50, product_name = "VA2", location_id = 2, price = 6000, total_units = 120, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 51, product_name = "VA3", location_id = 2, price = 9000, total_units = 43, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 52, product_name = "VA1", location_id = 3, price = 8000, total_units = 18, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 53, product_name = "VA2", location_id = 3, price = 6000, total_units = 17, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 54, product_name = "VA3", location_id = 3, price = 9000, total_units = 18, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 55, product_name = "VA1", location_id = 4, price = 8000, total_units = 22, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 56, product_name = "VA2", location_id = 4, price = 6000, total_units = 25, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 57, product_name = "VA3", location_id = 4, price = 9000, total_units = 20, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 58, product_name = "VA1", location_id = 5, price = 8000, total_units = 25, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 59, product_name = "VA2", location_id = 5, price = 6000, total_units = 35, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { sales_id = 60, product_name = "VA3", location_id = 5, price = 9000, total_units = 19, sales_date = new DateTime(2023, 6, 14) },

                new SalesRecord() { sales_id = 61, product_name = "VA1", location_id = 1, price = 8000, total_units = 4, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 62, product_name = "VA2", location_id = 1, price = 6000, total_units = 5, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 63, product_name = "VA3", location_id = 1, price = 9000, total_units = 6, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 64, product_name = "VA1", location_id = 2, price = 8000, total_units = 10, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 65, product_name = "VA2", location_id = 2, price = 6000, total_units = 32, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 66, product_name = "VA3", location_id = 2, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 67, product_name = "VA1", location_id = 3, price = 8000, total_units = 8, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 68, product_name = "VA2", location_id = 3, price = 6000, total_units = 15, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 69, product_name = "VA3", location_id = 3, price = 9000, total_units = 16, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 70, product_name = "VA1", location_id = 4, price = 8000, total_units = 16, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 71, product_name = "VA2", location_id = 4, price = 6000, total_units = 20, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 72, product_name = "VA3", location_id = 4, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 73, product_name = "VA1", location_id = 5, price = 8000, total_units = 23, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 74, product_name = "VA2", location_id = 5, price = 6000, total_units = 18, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { sales_id = 75, product_name = "VA3", location_id = 5, price = 9000, total_units = 36, sales_date = new DateTime(2023, 6, 15) },

                new SalesRecord() { sales_id = 76, product_name = "VA1", location_id = 1, price = 8000, total_units = 8, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 77, product_name = "VA2", location_id = 1, price = 6000, total_units = 9, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 78, product_name = "VA3", location_id = 1, price = 9000, total_units = 10, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 79, product_name = "VA1", location_id = 2, price = 8000, total_units = 54, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 80, product_name = "VA2", location_id = 2, price = 6000, total_units = 65, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 81, product_name = "VA3", location_id = 2, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 82, product_name = "VA1", location_id = 3, price = 8000, total_units = 12, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 83, product_name = "VA2", location_id = 3, price = 6000, total_units = 23, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 84, product_name = "VA3", location_id = 3, price = 9000, total_units = 11, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 85, product_name = "VA1", location_id = 4, price = 8000, total_units = 20, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 86, product_name = "VA2", location_id = 4, price = 6000, total_units = 17, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 87, product_name = "VA3", location_id = 4, price = 9000, total_units = 25, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 88, product_name = "VA1", location_id = 5, price = 8000, total_units = 18, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 89, product_name = "VA2", location_id = 5, price = 6000, total_units = 25, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { sales_id = 90, product_name = "VA3", location_id = 5, price = 9000, total_units = 35, sales_date = new DateTime(2023, 6, 16) },

                new SalesRecord() { sales_id = 91, product_name = "VA1", location_id = 1, price = 8000, total_units = 45, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 92, product_name = "VA2", location_id = 1, price = 6000, total_units = 44, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 93, product_name = "VA3", location_id = 1, price = 9000, total_units = 6, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 94, product_name = "VA1", location_id = 2, price = 8000, total_units = 32, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 95, product_name = "VA2", location_id = 2, price = 6000, total_units = 21, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 96, product_name = "VA3", location_id = 2, price = 9000, total_units = 44, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 97, product_name = "VA1", location_id = 3, price = 8000, total_units = 41, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 98, product_name = "VA2", location_id = 3, price = 6000, total_units = 43, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 99, product_name = "VA3", location_id = 3, price = 9000, total_units = 7, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 100, product_name = "VA1", location_id = 4, price = 8000, total_units = 44, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 101, product_name = "VA2", location_id = 4, price = 6000, total_units = 25, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 102, product_name = "VA3", location_id = 4, price = 9000, total_units = 19, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 103, product_name = "VA1", location_id = 5, price = 8000, total_units = 40, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 104, product_name = "VA2", location_id = 5, price = 6000, total_units = 28, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { sales_id = 105, product_name = "VA3", location_id = 5, price = 9000, total_units = 22, sales_date = new DateTime(2023, 6, 17) }
                );
        }
    }
}
