using System;

class Program
{
    static void Main()
    {
        Console.Write("Выберите класс (воин, маг, разбойник, паладин, варвар, охотник, друид, жрец): ");
        string CC = Console.ReadLine();

        Console.WriteLine(CC switch
        {
            "воин" or "паладин" or "варвар" or "разбойник" => "ближний боец",
            "маг" or "охотник" or "жрец" or "друид" => "дальнобойщик",
            _ => "неизвестный класс"
        });
    }
}