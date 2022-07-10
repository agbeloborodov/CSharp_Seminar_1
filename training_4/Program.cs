internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        //
        //  2, 3, 7 -> 7
        //  44 5 78 -> 78
        //  22 3 9 -> 22
        Console.WriteLine("Для определения максимального значения из трёх вещественных чисел необходимо ввести эти переменные. Прошу...");
        Console.Write("Число a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Число b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Число c: ");
        int c = int.Parse(Console.ReadLine());
        int max = a;
        if (b > a) max = b;
        if (c > max) max = c;
        Console.Write("Максимальное значение из этих трёх переменных Max = ");
        Console.WriteLine(max);
    }
}