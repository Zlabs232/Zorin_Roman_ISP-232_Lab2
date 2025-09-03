namespace Program //Пространство имён
{
    internal class Program //Главный класс программы
    {
        static int health = 100; //Статич. поле ХП персонажа - 100 единиц
        
        static void Main(string[] args) //Главный метод - точка входа
        {
            Console.WriteLine($"Здоровье персонажа: {health}"); //Вывод текущего ХП персонажа в консоль
            TakeDamage(30); //Вызов метода для нанесения урона 
        }

        static void TakeDamage(int damage) //Метод обработки получения урона 
        {
            health -= damage; //Уменьшение ХП на величину урона
            Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровье {health}"); //Вывод информации об уровне и новом ХП
        }
    }
}