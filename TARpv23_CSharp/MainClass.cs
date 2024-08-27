using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TARpv23_CSharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Задача 1 Проверка имени и возраста Juku для покупки билета
            Console.Write("Sisesta oma nimi: ");
            string nimi = Console.ReadLine();
            if (nimi.ToLower() == "juku")
            {
                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());
                if (vanus < 0 || vanus > 100)
                {
                    Console.WriteLine("Viga andmetega!");
                }
                else if (vanus < 6)
                {
                    Console.WriteLine("Tasuta pilet");
                }
                else if (vanus >= 6 && vanus <= 14)
                {
                    Console.WriteLine("Lastepilet");
                }
                else if (vanus >= 15 && vanus <= 65)
                {
                    Console.WriteLine("Täispilet");
                }
                else if (vanus > 65)
                {
                    Console.WriteLine("Sooduspilet");
                }
            }
            else
            {
                Console.WriteLine("Tere, {0}! See programm on mõeldud ainult Juku jaoks.", nimi);
            }

            // Задача 2 Сообщение о том, что два человека сегодня соседи по парте
            Console.Write("Sisesta esimese inimese nimi: ");
            string nimi1 = Console.ReadLine();
            Console.Write("Sisesta teise inimese nimi: ");
            string nimi2 = Console.ReadLine();
            Console.WriteLine("{0} ja {1} on täna pinginaabrid!", nimi1, nimi2);

            // Задача 3 Расчет площади комнаты и стоимости ремонта
            Console.Write("Sisesta esimese seina pikkus meetrites: ");
            double sein1 = double.Parse(Console.ReadLine());
            Console.Write("Sisesta teise seina pikkus meetrites: ");
            double sein2 = double.Parse(Console.ReadLine());
            double pindala = sein1 * sein2;
            Console.WriteLine("Ristkülikukujulise toa põranda pindala on {0} ruutmeetrit.", pindala);

            Console.Write("Kas soovid teha remonti (jah/ei): ");
            string remontVastus = Console.ReadLine().ToLower();
            if (remontVastus == "jah")
            {
                Console.Write("Sisesta ruutmeetri hind: ");
                double hind = double.Parse(Console.ReadLine());
                double koguMaksumus = pindala * hind;
                Console.WriteLine("Põranda vahetamise hind on {0} eurot.", koguMaksumus);
            }

            // Задача 4 Нахождение начальной цены с учетом 30% скидки
            Console.Write("Sisesta hind pärast 30% allahindlust: ");
            double hindPärastAllahindlust = double.Parse(Console.ReadLine());
            double algneHind = hindPärastAllahindlust / 0.7;
            Console.WriteLine("Alghind enne allahindlust oli {0} eurot.", algneHind);

            // Задача 5 Проверка температуры на соответствие комфортному уровню
            Console.Write("Sisesta toatemperatuur kraadides: ");
            double temperatuur = double.Parse(Console.ReadLine());
            if (temperatuur > 18)
            {
                Console.WriteLine("Temperatuur on sobiv.");
            }
            else
            {
                Console.WriteLine("Temperatuur on liiga madal.");
            }

            // Дополнительно, ранее добавленные функции
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}", nimetus);
            Funktsioonid.Tere(nimetus);

            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus = Funktsioonid.Liitmine(b, a);
            Console.WriteLine(vastus);

            double arv = 5.123456;
            vastus = Funktsioonid.Liitmine(a, (int)arv);
            Console.WriteLine(vastus);

            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus);
            }

            Console.WriteLine(Funktsioonid.Arvuta("*", 5, 5));
        }
    }
}
