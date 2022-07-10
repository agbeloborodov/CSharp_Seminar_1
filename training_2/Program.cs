internal class NewBaseType
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
        //
        //  a = 5; b = 7 -> max = 7
        //  a = 2 b = 10 -> max = 10
        //  a = -9 b = -3 -> max = -3
        Console.WriteLine("Для определения максимального значения из двух чисел необходимо ввести эти переменные. Прошу...");
        Console.Write("Число a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Число b: ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.Write("Максимальное значение из этих двух переменных Max = ");
            Console.WriteLine(a);
        }
        else
        {
            Console.Write("Максимальное значение из этих двух переменных Max = ");
            Console.WriteLine(b);
        }
    }
}

