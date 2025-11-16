using DairyEntry.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DairyEntry.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntrys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adding data into DiaryEntry database
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { Id = 1, Title = "Went Hiking", Content = "Went hiking with Joe", Created= new DateTime(2025, 11, 15, 12, 9, 0)},
                new DiaryEntry { Id = 2, Title = "Went Shopping", Content = "Went shopping with Joe", Created = new DateTime(2025, 11, 15, 12, 9, 0) },
                new DiaryEntry { Id = 3, Title = "Went Diving", Content = "Went diving with Joe", Created = new DateTime(2025, 11, 15, 12, 9, 0) }
                );

        }

        // Four steps to add a table
        // 1. Create a Model class (DiaryEntry.cs)
        // 2. Add Db Context (here)
        // 3. add-migration AddDiaryEntryTable

    }
}
