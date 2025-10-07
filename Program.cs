using System;

class Program
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void PrintDayInRussian(DayOfWeek day)
    {
        switch (day)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Понедельник");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Вторник");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Среда");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Четверг");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Пятница");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Суббота");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Воскресенье");
                break;
        }
    }

    enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Cyan,
        Magenta
    }

    static string GetHexCode(Color color)
    {
        switch (color)
        {
            case Color.Red:
                return "#FF0000";
            case Color.Green:
                return "#00FF00";
            case Color.Blue:
                return "#0000FF";
            case Color.Yellow:
                return "#FFFF00";
            case Color.Cyan:
                return "#00FFFF";
            case Color.Magenta:
                return "#FF00FF";
            default:
                return "#000000";
        }
    }

    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    static double Calculate(double a, double b, Operation operation)
    {
        switch (operation)
        {
            case Operation.Add:
                return a + b;
            case Operation.Subtract:
                return a - b;
            case Operation.Multiply:
                return a * b;
            case Operation.Divide:
                return a / b;
            default:
                return 0;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ DayOfWeek ===");
        Console.WriteLine("Все дни недели:");
        PrintDayInRussian(DayOfWeek.Monday);
        PrintDayInRussian(DayOfWeek.Tuesday);
        PrintDayInRussian(DayOfWeek.Wednesday);
        PrintDayInRussian(DayOfWeek.Thursday);
        PrintDayInRussian(DayOfWeek.Friday);
        PrintDayInRussian(DayOfWeek.Saturday);
        PrintDayInRussian(DayOfWeek.Sunday);

        Console.WriteLine("\n=== ТЕСТИРОВАНИЕ Color ===");
        Console.WriteLine("HEX-коды цветов:");
        Console.WriteLine($"Red: {GetHexCode(Color.Red)}");
        Console.WriteLine($"Green: {GetHexCode(Color.Green)}");
        Console.WriteLine($"Blue: {GetHexCode(Color.Blue)}");
        Console.WriteLine($"Yellow: {GetHexCode(Color.Yellow)}");
        Console.WriteLine($"Cyan: {GetHexCode(Color.Cyan)}");
        Console.WriteLine($"Magenta: {GetHexCode(Color.Magenta)}");

        Console.WriteLine("\n=== ТЕСТИРОВАНИЕ Operation ===");
        Console.WriteLine("Арифметические операции:");
        double a = 15, b = 3;
        Console.WriteLine($"{a} + {b} = {Calculate(a, b, Operation.Add)}");
        Console.WriteLine($"{a} - {b} = {Calculate(a, b, Operation.Subtract)}");
        Console.WriteLine($"{a} * {b} = {Calculate(a, b, Operation.Multiply)}");
        Console.WriteLine($"{a} / {b} = {Calculate(a, b, Operation.Divide)}");
    }
}