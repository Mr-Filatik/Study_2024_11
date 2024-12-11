using System.Text;

namespace Study_2024_11;

public class Program
{
    public static List<int> ints = new List<int>() { 1, 3, 6, 2, 8, 3, 2 };

    public static void Main(string[] args)
    {
        //Console.WriteLine("Start Main!");
        //Method1(a => a < 4);
        //Console.WriteLine("Method Main!");
        //Method1(a => a >= 4);
        //Console.WriteLine("End Main!");

        //Method2(() =>
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Error");
        //});

        var car = new Car(MethodForCar);
        car.Move(10);
        car.Move(110);
        car.Move(120);
        car.Move(10);
    }

    public static void Method1(Predicate<int> func)
    {
        foreach (var item in ints)
        {
            if (func(item))
            {
                Console.WriteLine(item);
            }
        }
    }

    public static void Method2(Action func)
    {
        Console.WriteLine("Start work!");
        Console.WriteLine("Error");
        func();
    }

    public static void MethodForCar(string mes)
    {
        Console.WriteLine("Отправка данных --------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(mes);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Отправка данных --------------");
    }
}

public class Car
{
    private Action<string> _signal;

    public Car(Action<string> signal)
    {
        _signal = signal;
    }

    public void Move(int distance)
    {
        Console.WriteLine($"Start move {distance}!");
        if (distance > 100)
        {
            _signal.Invoke("Нужна заправка");
        }
        Console.WriteLine($"End move {distance}!");
    }
}

//Action<string, int, bool> - public void Move(string str, int distance, bool aaa)
//Predicate<string, int, bool> - public bool Move(string str, int distance, bool aaa)
//Func<int, bool, string> - public string Move(int distance, bool aaa)
