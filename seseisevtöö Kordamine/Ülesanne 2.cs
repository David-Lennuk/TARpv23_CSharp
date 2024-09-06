using System;
//Ü 2. В массиве строк (список фамилий) определите самую длинную фамилию.


namespace TARpv23_CSharp
{
    class Program2
    {
        static void Ulesanne2()
        {
            // Stringide massiivi näide (perekonnanimede loend)
            string[] surnames = { "Ivanov", "Viktor", "Lennuk", "Kudriašev", "Baširov" };

            // Pikima perekonnanime salvestamiseks initsialiseerige muutuja
            string longestSurname = "";

            // Itereerige läbi kõik massiivi nimed
            foreach (string surname in surnames)
            {
                // Если текущая фамилия длиннее сохраненной, обновляем значение
                if (surname.Length > longestSurname.Length)
                {
                    longestSurname = surname;
                }
            }

            // Trüki pikim perekonnanimi
            Console.WriteLine("Pikim perekonnanimi: " + longestSurname);
        }
    }
}