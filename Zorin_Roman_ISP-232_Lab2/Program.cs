namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double a = 10;
            double b = 3;
            double c = a / b;
            Console.WriteLine($"Переменная c: {c}");
            double x = 10 / 3;
            Console.WriteLine($"Переменная х: {x}");

            int x1 = 4;
            int y1 = ++x1;
            Console.WriteLine($"x1 = {x1}, y1 = {y1}");

            int x2 = 4;
            int y2 = x2++;
            Console.WriteLine($"x1 = {x2}, y1 = {y2}");

            int x3 = 10 / 5 * 2 // операторы / и * имеют одинаковый приоритет, поэтому всё идет по порядку: сначала выполняетс 10 / 5, а потом * на 2
        }
    }
}
