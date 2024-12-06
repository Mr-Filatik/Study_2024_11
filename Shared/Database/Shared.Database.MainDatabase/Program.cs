using Microsoft.EntityFrameworkCore;
using Shared.Database.MainDatabase.Repositories;
using Study_2024_11.Shared.Entities;

namespace Shared.Database.MainDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var dbContext = new MainDbContext();

            var repo = new MessageRepository(dbContext);

            var message = repo.Get(1);
            if (message != null)
            {
                Console.WriteLine(message.Body);
            }

            //repo.GetRangeByIds([1, 2, 3], 10);
            //var b = repo.Update(new Message()
            //{
            //    AuthorId = 1,
            //    Body = "hello",
            //    Title = "hello",
            //    UniqId = 1,
            //});
            //if (b)
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    Console.WriteLine("DONT OK");
            //}


            //Console.WriteLine($"====================================");

            ////users = dbContext.Users.Where(u => u.Age < 25);
            //foreach (var u in users)
            //{
            //    Console.WriteLine($"User found. Id: {u.Id}, Name: {u.FirstName}.");
            //}
        }
    }
}
