using System.Text;

namespace Study_2024_11;

public class Program
{
    public static async Task Main(string[] args)
    {
        //Task - задача
        //Thread - поток

        //Готовка пельменей
        //1. Приготовить тесто
        //2. Дать тесту настояться
        //3. Приготовить фарш
        //4. Сделать пельмени

        var ts = new CancellationTokenSource(TimeSpan.FromMinutes(1));
        var token = ts.Token;

        var ar = Method1();
        Console.WriteLine(ar);
        var b = Method2Async(ar); //=====

        var cr = Method3();
        Console.WriteLine(cr);

        var br = await b; //=====
        Console.WriteLine(br);
        var dr = Method4(br, cr);
        Console.WriteLine(dr);
    }

    public static string Method1()
    {
        Thread.Sleep(2000);
        return $"неготовое тесто";
    }

    public static async Task<string> Method2Async(string str)
    {
        await Task.Delay(1000);
        return $"тесто из {str}";
    }

    public static string Method3()
    {
        Thread.Sleep(2000);
        return $"фарш";
    }

    public static string Method4(string str, string str2)
    {
        Thread.Sleep(2000);
        return $"пельмени = {str} + {str2}";
    }
}