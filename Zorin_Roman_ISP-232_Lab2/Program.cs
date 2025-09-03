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

            int x3 = 10 / 5 * 2; // операторы / и * имеют одинаковый приоритет, поэтому всё идет по порядку: сначала выполняетс 10 / 5, а потом * на 2

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

            int n1 = 25;
            int n2 = 17;
            Console.WriteLine(n1 == n2);

            int n3 = 45;
            int n4 = 13;
            Console.WriteLine(n3 != n4);
            Console.WriteLine(n3 != 45);

            int n5 = 45;
            int n6 = 13;
            Console.WriteLine(n5 > n6);

            int n7 = 45;
            int n8 = 13;
            Console.WriteLine(n7 < n8);

            int n9 = 45;
            int n10 = 13;
            Console.WriteLine(n9 <= n10);

            int n11 = 45;
            int n12 = 13;
            Console.WriteLine(n11 >= n12);

            bool n13 = (5 > 6) | (4 < 6);
            bool n14 = (5 > 6) | (4 > 6);
            Console.WriteLine(n13);
            Console.WriteLine(n14);

            bool n15 = (5 > 6) & (4 < 6);
            bool n16 = (5 < 6) & (4 < 6);
            Console.WriteLine(n15);
            Console.WriteLine(n16);

            bool n17 = (5 > 6) || (4 < 6);
            bool n18 = (5 > 6) || (4 > 6);
            Console.WriteLine(n17);
            Console.WriteLine(n18);

            bool n19 = (5 > 6) && (4 < 6);
            bool n20 = (5 < 6) && (4 < 6);
            Console.WriteLine(n19);
            Console.WriteLine(n20);

            bool n21 = true;
            bool n22 = !n21;
            Console.WriteLine(n22);

            bool n23 = (5 > 6) ^ (4 < 6);
            bool n24 = (50 > 6) ^ (4 / 2 < 3);
            Console.WriteLine(n23);
            Console.WriteLine(n24);

            double number = 1245.56789;
            Console.WriteLine("{0:F2}", number); //2 числа после запятой
            Console.WriteLine("{0:C}", number); // валюта
            Console.WriteLine("{0:P}", 0.1234); // проценты

            Console.WriteLine("Введите целое число: ");
            string? input = Console.ReadLine();
            int number2 = Convert.ToInt32(input);

            if (number2 > 0)
            {
                Console.WriteLine("Число положительное.");
            }
            else if (number2 < 0)
            {
                Console.WriteLine("Число отрицательное.");
            }
            else
            {
                Console.WriteLine("Это ноль.");
            }

            int x5 = 3;
            int y4 = 2;
            int z3 = x5 < y4 ? (x5 + y4) : (x5 - y4);
            Console.WriteLine(z3);

            string game = Console.ReadLine().ToLower();

            Console.WriteLine(game switch
            {
                "dota 2" => "Ваша игра - Dota 2",
                "cs" => "Ваша игра - CS:GO",
                "minecraft" => "Ваша игра - Minecraft",
                _ => "Игра не найдена"
            });

            //Task 1
            int numb = int.Parse(Console.ReadLine());
            string res = numb % 2 == 0 ? $"число {numb} чётное" : $"число {numb} нечётное";
            Console.WriteLine(res);

            //Task 2
            string password1 = Console.ReadLine();
            string password2 = Console.ReadLine();
            string res2 = password1 == password2 ? "парол принят" : "парол не принят";
            Console.WriteLine(res2);

            //Task 3
            string number3 = Console.ReadLine();

            int first = int.Parse(number3[0].ToString());
            int second = int.Parse(number3[1].ToString());
            int third = int.Parse(number3[2].ToString());
            int fourth = int.Parse(number3[3].ToString());

            string res3 = (first + fourth) == (second - third) ? "Да" : "Нет";
            Console.WriteLine(res3);





        }
    }
}
