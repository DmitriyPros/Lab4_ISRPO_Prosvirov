// using System;
// class TextProcessor {
//     static void Main()
//     {
//         Console.WriteLine("Доброго времени суток!");
//         const string fullName = "Просвиров Дмитрий Анатольевич";
//         const string group = "ИСП-241";
//         const string data = "24.09.2026";

//         bool Run = true;
//         while (Run)
//         {
//             Console.WriteLine("\nВыберите действие:");
//             Console.WriteLine("1 — Показать ФИО");
//             Console.WriteLine("2 — Показать группу");
//             Console.WriteLine("3 — Показать дату и время");
//             Console.WriteLine("4 — Выход");
//             Console.Write("Введите номер пункта: ");

//             string userInput = Console.ReadLine();
//             if (userInput == "1")
//             {
//                 Console.WriteLine($"Ваше ФИО: {fullName}");
//             }
//             else if (userInput == "2")
//             {
//                 Console.WriteLine($"Номер вашей группы {group}");
//             }
//             else if (userInput == "3")
//             {
//                 Console.WriteLine($"Текущая дата: {data}");
//             }
//             else if (userInput == "4")
//             {
//                 Console.WriteLine("Завершение работы. До свидания!");
//                 Run = false;
//             }
//             else
//             {
//                 Console.WriteLine("Ошибка: Введен неверный пункт меню. Попробуйте еще раз.");
//             }
//         }
//     }
// }
