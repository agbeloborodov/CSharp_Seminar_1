internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        //
        //  4 -> да
        //  -3 -> нет
        //  7 -> нет
        Console.WriteLine("Для определения чётности вещественного числа необходимо его ввести. Прошу...");
        Console.Write("Проверяемое число: ");
        double a = double.Parse(Console.ReadLine());
        if (a % 2 == 0) Console.WriteLine("Проверяемое число чётное ");
        else  Console.WriteLine("Проверяемое число нечётное ");
    }
}