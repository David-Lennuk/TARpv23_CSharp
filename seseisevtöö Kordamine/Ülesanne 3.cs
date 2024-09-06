using System;
//Ü 3. Надо спросить у пользователя его имя. Разбить имя на буквы, сохранить их в соответствующем массиве, вывести его на экран и посчитать сколько в имени гласных и согланых букв.

namespace TARpv23_CSharp
{
    public static class Program3
    {
        public static void Ulesanne3()
        {
            // Küsime kasutajalt nime
            Console.Write("Sisestage oma nimi: ");
            string name = Console.ReadLine();

            // Jagame nime tähtedeks ja salvestame massiivi
            char[] letters = name.ToCharArray();

            // Kuvame tähemassiivi ekraanile
            Console.WriteLine("Tähtede massiiv: " + string.Join(", ", letters));

            // Määrame vokaalid ja kaashäälikud
            string vowels = "aeiouAEIOU";
            int vowelCount = 0;
            int consonantCount = 0;

            // Arvutame vokaalide ja kaashäälikute arvu
            foreach (char letter in letters)
            {
                if (char.IsLetter(letter))
                {
                    if (vowels.Contains(letter))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            // Kuvame arvestustulemused
            Console.WriteLine("Vokaalide arv: " + vowelCount);
            Console.WriteLine("Kaashäälikute arv: " + consonantCount);
        }
    }
}
