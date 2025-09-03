using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int sum = (num1 > 0 ? num1 : 0) + (num2 > 0 ? num2 : 0) + (num3 > 0 ? num3 : 0);
        Console.WriteLine(sum);
    }
}