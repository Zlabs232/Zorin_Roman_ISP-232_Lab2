using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вы — отважный искатель приключений, ваша задача - найти сокровища легендарного Dungeon Master'a. Вам требуется пройти через несколько комнат. Вы стоите перед выбором. Пройти в дверь с Драконом(1) или пойти по тёмному коридору(2). Что же вы выберете?");
        int choice = int.Parse(Console.ReadLine());
        string res = choice == 1 ? DragonPath() : DarkCPath();
        Console.WriteLine(res);
    }
    static string DragonPath()
    {
        Console.WriteLine("Вам нужно ответить на загадку дракона! \nДракон: 'Кто не дышит, но живет; хоть не нужно — много пьет; и в жизни, и в смерти тело как лед.'");
        Console.WriteLine("Ваш ответ: ");
        string answer = Console.ReadLine().ToLower();
        return answer == "рыба" ? "Дракон: 'Красавчик! Дуй отсюда'" : "Дракон: 'Мдаа, ну полезай мне в рот, ща тебя сожру'";
    }
    static string DarkCPath()
    {
        Console.WriteLine("Вы в темной комнате с двумя дверями. Выберите дверь 1 или 2:");
        int doorChoice = int.Parse(Console.ReadLine());

        return doorChoice == 1 ? "Молоток! Ты нашел сокровища Dungeon Master'a" : "Ты сдох от ядовитых шипов, позоооор. Игра окончена.";
    }
}