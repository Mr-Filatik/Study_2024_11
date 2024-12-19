using Microsoft.EntityFrameworkCore;
using Shared.Database.MainDatabase.Configuration;
using Study_2024_11.Shared.Entities;

namespace Shared.Database.MainDatabase;

public class MainDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Message> Messages { get; set; }

    public MainDbContext()
    {
        // Удалить Database.EnsureCreated и Database.EnsureDeleted и базу если есть
        // Установить пакет Microsoft.EntityFrameworkCore.Tools
        // Создаём миграцию Add-Migration Name
        // Если с ней всё ок применяем Update-Database

        // Если обнаруживаем косяк, можем откатиться на определённую миграцию через Update-Database Name и удалить последнюю миграцию Remove-Migration
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=main_db;Username=main_user;Password=main_password");
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\Filatik\\test_db_study_2024_11.db");
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
            PasswordSalt = "password",
            Gender = true,
        });

        modelBuilder.ApplyConfiguration(new MessageCreatingConfiguration());
    }
}
