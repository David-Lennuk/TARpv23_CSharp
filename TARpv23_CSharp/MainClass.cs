using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TARpv23_CSharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, world!");
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


            //I.osa Andmetüübid, Alamfunktsioonid, IF
            string[] nime = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
            //1.V
            for (int i = 0; i < nime.Length; i++)
            {
                Console.WriteLine(nime[i]);
            }
            //2.v
            foreach (string nimi in nime)
            {
                Console.WriteLine(nimi);
            }
            //3.v
            int n = 0;
            while (n < nime.Length)
            {
                Console.WriteLine(nime[n]);
                n++;
            }
            //4.v
            do
            {
                Console.WriteLine(nime[n - 1]);
                n--;
            } while (n! > 0); //!


            for (int i = 0; i < 7; i++)
            {
                int paev_nr = random.Next(-4, 30);
                string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
                Console.WriteLine(paeva_nimetus);
            }



            try
            {




                Console.WriteLine("Mis on sinu pikkus?");
                double pikkus = Double.Parse(Console.ReadLine());
                string vastus1 = Funktsioonid.Pikkuse_analuus(pikkus);
                Console.WriteLine("Sinu pikkus on {0}, sa oled {1}", pikkus, vastus1);
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }



            //1* Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus (-100,100).
            int N = random.Next(-100, 101);
            int M = random.Next(-100, 101);
            int[] arvud;

            if (N < M)
            {
                arvud = Funktsioonid.Arvude_massive(N, M);
            }
            else
            {
                arvud = Funktsioonid.Arvude_massive(N, M);
            }
            foreach (int item in arvud)
            {
                Console.WriteLine(item * item);
            }


            // 2* Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende summa, aritmeetiline keskmine ja korrutis.
            int[] numbrid = new int[5];
            int summa = 0;
            int korrutis = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sisesta arv {0}: ", i + 1);
                numbrid[i] = int.Parse(Console.ReadLine());
                summa += numbrid[i];
                korrutis *= numbrid[i];
            }
            double keskmine = summa / 5.0;
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Aritmeetiline keskmine: " + keskmine);
            Console.WriteLine("Korrutis: " + korrutis);

            // 3* Küsi viielt kasutajalt nimed ja vanused, salvesta nende andmeid massiivi ning väljasta summaarne vanus, aritmeetiline keskmine, vaanema ja noorema inimeste nimed ja vanused.
            string[] nimed = new string[5];
            int[] vanused = new int[5];
            int vanusteSumma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sisesta nimi {0}: ", i + 1);
                nimed[i] = Console.ReadLine();
                Console.Write("Sisesta vanus {0}: ", i + 1);
                vanused[i] = int.Parse(Console.ReadLine());
                vanusteSumma += vanused[i];
            }
            double vanusteKeskmine = vanusteSumma / 5.0;
            int vanimIndex = Array.IndexOf(vanused, vanused.Max());
            int noorimIndex = Array.IndexOf(vanused, vanused.Min());
            Console.WriteLine("Summaarne vanus: " + vanusteSumma);
            Console.WriteLine("Aritmeetiline keskmine vanus: " + vanusteKeskmine);
            Console.WriteLine("Vanim inimene: " + nimed[vanimIndex] + ", Vanus: " + vanused[vanimIndex]);
            Console.WriteLine("Noorim inimene: " + nimed[noorimIndex] + ", Vanus: " + vanused[noorimIndex]);

            // 4* Ütle kasutajale "Osta elevant ära!". Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab "elevant".
            string vastuse = "";
            while (vastuse.ToLower() != "elevant")
            {
                Console.WriteLine("Osta elevant ära!");
                vastuse = Console.ReadLine();
            }
            Console.WriteLine("Tänan, et ostsid elevandi!");

            // 5* Mis arv mõtles välja arvuti? Kasuta vähemalt 5 katset, et seda teada.
            int arvutiArv = random.Next(1, 101);
            int katsed = 5;
            bool arvasOige = false;
            for (int i = 0; i < katsed; i++)
            {
                Console.Write("Mis arv mõtles välja arvuti? (1-100): ");
                int kasutajaArv = int.Parse(Console.ReadLine());
                if (kasutajaArv == arvutiArv)
                {
                    Console.WriteLine("Õige! Arvuti mõtles välja arvu " + arvutiArv);
                    arvasOige = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Vale arv, proovi uuesti.");
                }
            }
            if (!arvasOige)
            {
                Console.WriteLine("Sa ei arvanud ära. Arvuti mõtles välja arvu " + arvutiArv);
            }

            // 6* Küsi kasutajalt 4 arvu ning väljasta nendest koostatud suurim neliarvuline arv.
            int[] neliArvu = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Sisesta arv {0}: ", i + 1);
                neliArvu[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(neliArvu);
            Array.Reverse(neliArvu);
            string suurimArv = string.Join("", neliArvu);
            Console.WriteLine("Suurim võimalik neliarvuline arv: " + suurimArv);
        }
    }
}
