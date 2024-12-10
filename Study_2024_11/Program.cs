using System.Text;

namespace Study_2024_11;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Start Main!");
        Method1();
        Console.WriteLine("End Main!");
    }

    public static void Method1()
    {
        Console.WriteLine("Start Method1!");
        try
        {
            Method2();
        }
        catch (DatabaseException e)
        {
            Console.WriteLine($"Error: {e.Message}!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Uncnown exception!!!");
        }
        Console.WriteLine("End Method1!");
    }

    public static void Method2()
    {
        Console.WriteLine("Start Method2!");
        Method3();
        Console.WriteLine("End Method2!");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="DatabaseException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static void Method3()
    {
        Console.WriteLine("Start Method3!");
        int a = 3;
        if (a == 0)
        {
            throw new DatabaseException("Error connect to database");
        }
        if (a == 1)
        {
            throw new ArgumentException("Uncnown exception!");
        }
        Console.WriteLine("End Method3!");
    }
}

public class DatabaseException : Exception
{
    public DatabaseException(string message) : base(message)
    {
        
    }
}