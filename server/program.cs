using System;
class TextProcessor {
static void Main()
    {
        Console.WriteLine("Доброго времени суток!");
        const string fullName = "Просвиров Дмитрий Анатольевич";
        const string group = "ИСП-241";
        const string data = "24.09.2026";

        bool Run = true;
        while (Run)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1 — Показать ФИО");
            Console.WriteLine("2 — Показать группу");
            Console.WriteLine("3 — Показать дату и время");
            Console.WriteLine("4 — Выход");
            Console.Write("Введите номер пункта: ");

            string userInput = Console.ReadLine();

        }
    }
}