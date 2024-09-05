using System;  // Подключаем пространство имен System для работы с базовыми классами, такими как Console.
using System.Collections.Generic;  // Подключаем пространство имен для работы с коллекциями, такими как List<T>.

class PrimeFilter
{
    // Метод для проверки, является ли число простым.
    static bool IsPrime(int number)
    {
        // Проверяем, меньше ли число или равно 1. Числа <= 1 не являются простыми.
        if (number <= 1) return false;

        // Цикл для проверки делимости числа от 2 до квадратного корня из числа.
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            // Если число делится на i без остатка, то оно не является простым.
            if (number % i == 0) return false;
        }

        // Если число не делилось ни на одно из чисел в цикле, то оно простое.
        return true;
    }

    // Метод для фильтрации списка, оставляя только простые числа.
    static List<int> GetPrimes(List<int> numbers)
    {
        // Создаем новый список для хранения простых чисел.
        List<int> primes = new List<int>();

        // Перебираем каждое число из переданного списка.
        foreach (int number in numbers)
        {
            // Если число простое, добавляем его в список простых чисел.
            if (IsPrime(number))
            {
                primes.Add(number);
            }
        }

        // Возвращаем список с простыми числами.
        return primes;
    }

    // Главный метод программы.
    static void Main()
    {
        // Инициализируем список чисел для примера.
        List<int> numbers = new List<int> { 10, 15, 3, 7, 11, 13, 18 };

        // Получаем список простых чисел, вызывая метод GetPrimes.
        List<int> primeNumbers = GetPrimes(numbers);

        // Выводим результат: простые числа из исходного списка.
        Console.WriteLine("Простые числа в списке: " + string.Join(", ", primeNumbers));
    }
}
