using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        // seeding data into database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seeding some countries into database
            modelBuilder.Entity<Country>().HasData(
                new Country{Id = 1, Name = "India", ShortName = "IN"},
                new Country{Id = 2, Name = "Jamaica", ShortName = "JM"},
                new Country{Id = 3, Name = "United States", ShortName = "US"}
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel{
                    Id = 1,
                    Name = "Taj Hotel",
                    Address = "Mumbai",
                    CountryId = 1,
                    Rating = 4.8
                },
                new Hotel{
                    Id = 2,
                    Name = "Skylights",
                    Address = "Jam City",
                    CountryId = 2,
                    Rating = 4.2
                },new Hotel{
                    Id = 3,
                    Name = "Holiday Resort",
                    Address = "Washington",
                    CountryId = 3,
                    Rating = 4.5
                }
            );
        }
    }
}