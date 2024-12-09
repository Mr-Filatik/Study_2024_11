using System.Text;

namespace Study_2024_11;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var str = "csjbcsjs";
        Console.WriteLine(str.RemoveModTwo());

        var storage = new MemoryStorage();

        //storage.SetValue("SERVER_ADDRESS", "localhost:8080");

        //SellerPanel(storage);

        //UserPanel(storage);

        //AdminPanel(storage);

        //var repository = new EntityRepository<User>();
        //repository.Create(new User());
        //repository.Create(new Admin());
    }

    public static void UserPanel(IStorage storage)
    {
        // преобразования (плохой вариант) может выдать ошибку при null
        //var stor1 = (MemoryStorage)storage;
        // преобразования (хороший вариант) вернёт null если не сможет преобразовать
        var stor = storage as MemoryStorage;
        if (stor != null)
        {
            stor.SetString();
        }
        Console.WriteLine(storage.GetValue("PRODUCT_ID"));
    }

    public static void AdminPanel(IStorage storage)
    {
        Console.WriteLine(storage.GetValue("SERVER_ADDRESS"));
    }

    public static void SellerPanel(IStorage storage)
    {
        storage.SetValue("PRODUCT_ID", "152278767");

        Console.WriteLine(storage.GetValue("PRODUCT_ID"));
    }
}

public static class StringExtension
{
    public static string RemoveModTwo(this string str)
    {
        StringBuilder res = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if (i % 2 == 0)
            {
                res.Append(str[i]);
            }
        }
        return res.ToString();
    }
}