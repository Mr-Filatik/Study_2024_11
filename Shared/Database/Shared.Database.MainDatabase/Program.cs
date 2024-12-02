using Microsoft.EntityFrameworkCore;
using Study_2024_11.Shared.Entities;

namespace Shared.Database.MainDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var dbContext = new MainDbContext();

            //dbContext.Users.Add(new User()
            //{
            //    FirstName = "Test3",
            //    SecondName = "Test3",
            //    Email = "Test3",
            //    PasswordHash = "Test3",
            //    Age = 30,
            //    Gender = false,
            //});
            //dbContext.SaveChanges();
            Console.WriteLine($"====================================");

            //var user = dbContext.Users.AsNoTracking().FirstOrDefault(u => u.Id == 3);
            var user = dbContext.Users.FirstOrDefault(u => u.Id == 1);
            if (user != null)
            {
                Console.WriteLine($"User found. Id: {user.Id}, Name: {user.FirstName}.");
            }
            else
            {
                Console.WriteLine($"User not found.");
            }

            Console.WriteLine($"====================================");

            var users = dbContext.Users.Where(u => u.Age < 25);//.Skip(20).Take(10);

            //dbContext.Users.Add(new User()
            //{
            //    FirstName = "Test4",
            //    SecondName = "Test4",
            //    Email = "Test4",
            //    PasswordHash = "Test4",
            //    Age = 23,
            //    Gender = false,
            //});
            //dbContext.SaveChanges();

            foreach (var u in users)
            {
                Console.WriteLine($"User found. Id: {u.Id}, Name: {u.FirstName}.");
            }

            //dbContext.Users.Remove(new User() { Id = 4 });
            if (user != null)
            {
                user.Email = "ho-ho-ho";
                dbContext.Users.Update(user);
                dbContext.SaveChanges();
            }

            Console.WriteLine($"====================================");

            //users = dbContext.Users.Where(u => u.Age < 25);
            foreach (var u in users)
            {
                Console.WriteLine($"User found. Id: {u.Id}, Name: {u.FirstName}.");
            }
        }
    }
}
