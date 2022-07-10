internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        //
        // 5 -> 2, 4
        // 8 -> 2, 4, 6, 8
        Console.WriteLine("Введите число, которое определит последовательность чётных чисел [1..N]");
        Console.Write("Определите границу последовательности чётных чисел [1..N] : ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Полученная последовательность чётных чисел: ");
        for (int i = 1; i <=a; i++)
        {
            if ((i % 2) == 0) 
            {
                Console.Write(" ");
                Console.Write(i);
            }
        }
    }
}