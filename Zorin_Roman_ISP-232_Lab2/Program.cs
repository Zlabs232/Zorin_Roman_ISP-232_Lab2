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

            double a2 = 0.1;
            double b2 = 0.2;
            double c2 = a2 + b2;
            double d = 0.3;
            Console.WriteLine(c2 == d); // false, т.к. у типа double значения с плав. точкой, следовательно вычисление будет с небольшой погрешностью

            decimal x4 = 0.1m;
            decimal y3 = 0.2m;
            decimal z = x4 + y3;
            decimal e = 0.3m;
            Console.WriteLine(z == e); // тут же в свою очередь, вычисление точное из-за десятичного представления(decimal), поэтому True 
        }
    }
}
