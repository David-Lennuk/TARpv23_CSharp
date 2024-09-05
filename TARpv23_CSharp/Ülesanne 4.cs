using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace TARpv23_CSharp
{
    public class MainClass
    {

        class EstoniaCounties
        {
            // Словарь, где ключ — столица, значение — название округа
            private Dictionary<string, string> counties = new Dictionary<string, string>()
    {
        { "Таллин", "Харьюмаа" },
        { "Тарту", "Тартумаа" },
        { "Нарва", "Ида-Вирумаа" },
        { "Пярну", "Пярнумаа" },
        { "Курессааре", "Сааремаа" },
        { "Раквере", "Ляэне-Вирумаа" }
    };

            // Метод для получения города по названию округа
            public string GetCity(string county)
            {
                foreach (var pair in counties)
                {
                    if (pair.Value.Equals(county, StringComparison.OrdinalIgnoreCase))
                    {
                        return pair.Key;
                    }
                }
                return null;
            }

            // Метод для получения округа по названию города
            public string GetCounty(string city)
            {
                if (counties.TryGetValue(city, out string county))
                {
                    return county;
                }
                return null;
            }

            // Метод для добавления новой записи в словарь
            public void AddCounty(string city, string county)
            {
                if (!counties.ContainsKey(city))
                {
                    counties[city] = county;
                    Console.WriteLine($"Добавлено: {city} - {county}");
                }
                else
                {
                    Console.WriteLine("Такая столица уже есть в словаре.");
                }
            }

            // Метод для проверки знаний пользователя
            public void KnowledgeCheck()
            {
                var questions = new List<KeyValuePair<string, string>>(counties);
                var random = new Random();
                int correct = 0;
                int total = questions.Count;

                // Перемешиваем вопросы случайным образом
                for (int i = 0; i < total; i++)
                {
                    int randomIndex = random.Next(i, total);
                    var temp = questions[i];
                    questions[i] = questions[randomIndex];
                    questions[randomIndex] = temp;
                }

                // Задаем вопросы пользователю
                foreach (var question in questions)
                {
                    Console.Write($"Какой округ у столицы {question.Key}? ");
                    string answer = Console.ReadLine();

                    if (answer.Equals(question.Value, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Правильно!");
                        correct++;
                    }
                    else
                    {
                        Console.WriteLine($"Неправильно. Правильный ответ: {question.Value}.");
                    }
                }

                double percentage = (double)correct / total * 100;
                Console.WriteLine($"Вы ответили правильно на {correct} из {total} вопросов. Это {percentage:F2}%.");
            }
        }

        class Program
        {
            static void Main()
            {
                var estonia = new EstoniaCounties();

                while (true)
                {
                    Console.WriteLine("\nМеню:");
                    Console.WriteLine("1. Показать город по округу");
                    Console.WriteLine("2. Показать округ по городу");
                    Console.WriteLine("3. Добавить новый округ и город");
                    Console.WriteLine("4. Проверка знаний");
                    Console.WriteLine("5. Выйти");

                    Console.Write("Выберите действие: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Введите название округа: ");
                            string county = Console.ReadLine();
                            string city = estonia.GetCity(county);
                            if (city != null)
                            {
                                Console.WriteLine($"Столица округа {county} — {city}.");
                            }
                            else
                            {
                                Console.WriteLine("Такого округа нет в словаре.");
                            }
                            break;

                        case "2":
                            Console.Write("Введите название города: ");
                            city = Console.ReadLine();
                            county = estonia.GetCounty(city);
                            if (county != null)
                            {
                                Console.WriteLine($"Округ города {city} — {county}.");
                            }
                            else
                            {
                                Console.WriteLine("Такого города нет в словаре.");
                            }
                            break;

                        case "3":
                            Console.Write("Введите название города: ");
                            city = Console.ReadLine();
                            Console.Write("Введите название округа: ");
                            county = Console.ReadLine();
                            estonia.AddCounty(city, county);
                            break;

                        case "4":
                            estonia.KnowledgeCheck();
                            break;

                        case "5":
                            return;

                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                }
            }
        }
    }
}
