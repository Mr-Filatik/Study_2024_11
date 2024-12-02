using Microsoft.EntityFrameworkCore;
using Study_2024_11.Shared.Entities;

namespace Shared.Database.MainDatabase;

public class MainDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public MainDbContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=main_db;Username=main_user;Password=main_password");
        optionsBuilder.UseSqlite("Data Source=test_db_study_2024_11.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User()
        {
            Id = 1,
            FirstName = "Admin",
            SecondName = "Main",
            Age = 100,
            Email = "admin@mail.com",
            PasswordHash = "password",
            Gender = true,
        });
    }
}
