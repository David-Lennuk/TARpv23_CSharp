using System;
//Ü 1. Задан генератором случайных чисел одномерный массив из действительных чисел. Найдите максимальное и минимальное число этого массива, не используя функции max(), min().

namespace TARpv23_CSharp
{
    class Program1
    {
        static void Ulesanne1()
        {
            // Loome juhuslike arvude generaatori ja initsialiseerime massiivi
            Random random = new Random();
            int length = 3; // Massiivi pikkus
            int[] array = new int[length];

            // Täidame massiivi juhuslike arvudega vahemikus -100 kuni 100
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(-100, 101); // Arvud vahemikus [-100, 100] (täpselt -100 kuni 100)
            }

            // Maksimaalse ja minimaalse väärtuse muutujate initsialiseerimine
            int max = array[0];
            int min = array[0];

            // Läbime massiivi ja otsime maksimaalse ja minimaalse väärtuse
            for (int i = 1; i < array.Length; i++)
            {
                // Võrdlus maksimaalse väärtuse leidmiseks
                if (array[i] > max)
                {
                    max = array[i]; // Uuendame max, kui praegune element on suurem
                }

                // Võrdlus minimaalse väärtuse leidmiseks
                if (array[i] < min)
                {
                    min = array[i]; // Uuendame min, kui praegune element on väiksem
                }
            }

            // Väljasta massiiv ja tulemused
            Console.WriteLine("Massiiv: " + string.Join(", ", array));
            Console.WriteLine("Kõrgeim väärtus: " + max);
            Console.WriteLine("Madalaim väärtus: " + min);
        }
    }
}