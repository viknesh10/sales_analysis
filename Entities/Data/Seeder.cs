using Microsoft.EntityFrameworkCore;

namespace sales_analysis.Entities.Data
{
    public static class Seeder
    {
        public static void DataSeed(this ModelBuilder modelBuilder)
        {

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
                new SalesRecord() { product_name = "VA1", location_id = 1, price = 8000, total_units = 10, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA2", location_id = 1, price = 6000, total_units = 10, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA3", location_id = 1, price = 9000, total_units = 10, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA1", location_id = 2, price = 8000, total_units = 12, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA2", location_id = 2, price = 6000, total_units = 30, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA3", location_id = 2, price = 9000, total_units = 45, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA1", location_id = 3, price = 8000, total_units = 15, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA2", location_id = 3, price = 6000, total_units = 18, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA3", location_id = 3, price = 9000, total_units = 8, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA1", location_id = 4, price = 8000, total_units = 14, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA2", location_id = 4, price = 6000, total_units = 20, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA3", location_id = 4, price = 9000, total_units = 19, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA1", location_id = 5, price = 8000, total_units = 22, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA2", location_id = 5, price = 6000, total_units = 16, sales_date = new DateTime(2023, 6, 11) },
                new SalesRecord() { product_name = "VA3", location_id = 5, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 11) },

                new SalesRecord() { product_name = "VA1", location_id = 1, price = 8000, total_units = 20, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA2", location_id = 1, price = 6000, total_units = 30, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA3", location_id = 1, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA1", location_id = 2, price = 8000, total_units = 14, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA2", location_id = 2, price = 6000, total_units = 34, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA3", location_id = 2, price = 9000, total_units = 56, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA1", location_id = 3, price = 8000, total_units = 26, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA2", location_id = 3, price = 6000, total_units = 33, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA3", location_id = 3, price = 9000, total_units = 21, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA1", location_id = 4, price = 8000, total_units = 30, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA2", location_id = 4, price = 6000, total_units = 15, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA3", location_id = 4, price = 9000, total_units = 18, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA1", location_id = 5, price = 8000, total_units = 35, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA2", location_id = 5, price = 6000, total_units = 18, sales_date = new DateTime(2023, 6, 12) },
                new SalesRecord() { product_name = "VA3", location_id = 5, price = 9000, total_units = 26, sales_date = new DateTime(2023, 6, 12) },

                new SalesRecord() { product_name = "VA1", location_id = 1, price = 8000, total_units = 45, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA2", location_id = 1, price = 6000, total_units = 36, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA3", location_id = 1, price = 9000, total_units = 78, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA1", location_id = 2, price = 8000, total_units = 70, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA2", location_id = 2, price = 6000, total_units = 67, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA3", location_id = 2, price = 9000, total_units = 50, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA1", location_id = 3, price = 8000, total_units = 50, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA2", location_id = 3, price = 6000, total_units = 30, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA3", location_id = 3, price = 9000, total_units = 70, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA1", location_id = 4, price = 8000, total_units = 20, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA2", location_id = 4, price = 6000, total_units = 13, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA3", location_id = 4, price = 9000, total_units = 60, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA1", location_id = 5, price = 8000, total_units = 33, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA2", location_id = 5, price = 6000, total_units = 24, sales_date = new DateTime(2023, 6, 13) },
                new SalesRecord() { product_name = "VA3", location_id = 5, price = 9000, total_units = 17, sales_date = new DateTime(2023, 6, 13) },

                new SalesRecord() { product_name = "VA1", location_id = 1, price = 8000, total_units = 23, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA2", location_id = 1, price = 6000, total_units = 12, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA3", location_id = 1, price = 9000, total_units = 13, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA1", location_id = 2, price = 8000, total_units = 100, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA2", location_id = 2, price = 6000, total_units = 120, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA3", location_id = 2, price = 9000, total_units = 43, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA1", location_id = 3, price = 8000, total_units = 18, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA2", location_id = 3, price = 6000, total_units = 17, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA3", location_id = 3, price = 9000, total_units = 18, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA1", location_id = 4, price = 8000, total_units = 22, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA2", location_id = 4, price = 6000, total_units = 25, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA3", location_id = 4, price = 9000, total_units = 20, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA1", location_id = 5, price = 8000, total_units = 25, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA2", location_id = 5, price = 6000, total_units = 35, sales_date = new DateTime(2023, 6, 14) },
                new SalesRecord() { product_name = "VA3", location_id = 5, price = 9000, total_units = 19, sales_date = new DateTime(2023, 6, 14) },

                new SalesRecord() { product_name = "VA1", location_id = 1, price = 8000, total_units = 4, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA2", location_id = 1, price = 6000, total_units = 5, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA3", location_id = 1, price = 9000, total_units = 6, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA1", location_id = 2, price = 8000, total_units = 10, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA2", location_id = 2, price = 6000, total_units = 32, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA3", location_id = 2, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA1", location_id = 3, price = 8000, total_units = 8, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA2", location_id = 3, price = 6000, total_units = 15, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA3", location_id = 3, price = 9000, total_units = 16, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA1", location_id = 4, price = 8000, total_units = 16, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA2", location_id = 4, price = 6000, total_units = 20, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA3", location_id = 4, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA1", location_id = 5, price = 8000, total_units = 23, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA2", location_id = 5, price = 6000, total_units = 18, sales_date = new DateTime(2023, 6, 15) },
                new SalesRecord() { product_name = "VA3", location_id = 5, price = 9000, total_units = 36, sales_date = new DateTime(2023, 6, 15) },

                new SalesRecord() { product_name = "VA1", location_id = 1, price = 8000, total_units = 8, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA2", location_id = 1, price = 6000, total_units = 9, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA3", location_id = 1, price = 9000, total_units = 10, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA1", location_id = 2, price = 8000, total_units = 54, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA2", location_id = 2, price = 6000, total_units = 65, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA3", location_id = 2, price = 9000, total_units = 23, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA1", location_id = 3, price = 8000, total_units = 12, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA2", location_id = 3, price = 6000, total_units = 23, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA3", location_id = 3, price = 9000, total_units = 11, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA1", location_id = 4, price = 8000, total_units = 20, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA2", location_id = 4, price = 6000, total_units = 17, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA3", location_id = 4, price = 9000, total_units = 25, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA1", location_id = 5, price = 8000, total_units = 18, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA2", location_id = 5, price = 6000, total_units = 25, sales_date = new DateTime(2023, 6, 16) },
                new SalesRecord() { product_name = "VA3", location_id = 5, price = 9000, total_units = 35, sales_date = new DateTime(2023, 6, 16) },

                new SalesRecord() { product_name = "VA1", location_id = 1, price = 8000, total_units = 45, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA2", location_id = 1, price = 6000, total_units = 44, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA3", location_id = 1, price = 9000, total_units = 6, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA1", location_id = 2, price = 8000, total_units = 32, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA2", location_id = 2, price = 6000, total_units = 21, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA3", location_id = 2, price = 9000, total_units = 44, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA1", location_id = 3, price = 8000, total_units = 41, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA2", location_id = 3, price = 6000, total_units = 43, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA3", location_id = 3, price = 9000, total_units = 7, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA1", location_id = 4, price = 8000, total_units = 44, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA2", location_id = 4, price = 6000, total_units = 25, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA3", location_id = 4, price = 9000, total_units = 19, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA1", location_id = 5, price = 8000, total_units = 40, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA2", location_id = 5, price = 6000, total_units = 28, sales_date = new DateTime(2023, 6, 17) },
                new SalesRecord() { product_name = "VA3", location_id = 5, price = 9000, total_units = 22, sales_date = new DateTime(2023, 6, 17) }
                );
        }
    }
}
