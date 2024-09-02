using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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

            //III.osa OOP
            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 352;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            Inimene inimene3 = new Inimene("David", 17);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Devid", 18));
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " on " + inimene.Vanus + "aasta vana");
            }

            Auto auto1 = new Auto("681MRP", Color.Bisque, inimene1);
            Auto auto2 = new Auto("180ABC", Color.NavajoWhite, inimene2);
            Auto auto3 = new Auto("079TDI", Color.Red, inimene3);
            auto1.KelleOmaAuto();
            Dictionary<Auto, Inimene> register = new Dictionary<Auto, Inimene>();
            register.Add(auto1, inimene1);
            register.Add(auto2, inimene3);
            register.Add(auto3, inimene3);
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key.RegNumber} - {item.Value.Nimi}");
            }
            foreach (KeyValuePair<Auto, Inimene> pair in register)
            {
                Console.WriteLine(pair.Key.RegNumber + "-" + pair.Value.Nimi);
            }
            //Ülesanne1
            Console.WriteLine("Sisesta numbrid");
            string numbstr = Console.ReadLine();
            string[] numblist = numbstr.Split(" ");
            int[] newlist = new int[numbstr.Length];

            for (int i = 0; i < numblist.Length; i++)
            {
                int g;
                if (i == 0)
                {
                    g = int.Parse(numblist[numblist.Length-1]) + int.Parse(numblist[i+1]);
                }
                else if (i ==numblist.Length - 1)
                {
                    g = int.Parse(numblist[i - 1]) + int.Parse(numblist[0]);
                }
                else
                {
                    g = int.Parse(numblist[i-1]) + int.Parse(numblist[i+1]);
                }

                newlist[i] = g;

            }

            Console.WriteLine("New list of sums:");
            Console.WriteLine(string.Join(" ", newlist));




            //Ülesanne 2
            List<int> numbers = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(rand.Next(0, 101));
            }

            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

            List<int> newList = evenNumbers.Concat(oddNumbers).ToList();

            Console.WriteLine(string.Join(", ", newList));



            //Ülesanne 3 
            // Toiduainete nimed ja vastavad kalorid
            List<string> tooted = new List<string> { "Õun", "Banaan", "Kanafilee", "Riis", "Jogurt" };
            List<int> kalorid = new List<int> { 52, 89, 165, 130, 60 }; // Kalorid 100 grammi kohta

            //-----------------------------------------------
            Console.Write("Sisesta oma sugu (M/N): ");
            char sugu = Char.ToUpper(Console.ReadLine()[0]);

            Console.Write("Sisesta oma kaal (kg): ");
            double kaal = double.Parse(Console.ReadLine());

            Console.Write("Sisesta oma pikkus (cm): ");
            double pikkus = double.Parse(Console.ReadLine());

            Console.Write("Sisesta oma vanus (aastad): ");
            int vanus = int.Parse(Console.ReadLine());

            //------------------------------------
            double SBI;
            if (sugu == 'M')
            {
                SBI = 66 + (13.7 * kaal) + (5 * pikkus) - (6.8 * vanus);
            }
            else
            {
                SBI = 655 + (9.6 * kaal) + (1.8 * pikkus) - (4.7 * vanus);
            }

            //--------------------------------------------
            Console.WriteLine("Vali oma aktiivsuse tase:");
            Console.WriteLine("1. Istuv eluviis");
            Console.WriteLine("2. Vähene aktiivsus (1-3 korda nädalas)");
            Console.WriteLine("3. Mõõdukas aktiivsus (3-5 korda nädalas)");
            Console.WriteLine("4. Kõrge aktiivsus (6-7 korda nädalas)");
            Console.WriteLine("5. Väga kõrge aktiivsus (treening 2 korda päevas)");
            int aktiivsuseValik = int.Parse(Console.ReadLine());

            //-----------------------------------------
            double aktiivsusKoef = aktiivsuseValik switch
            {
                1 => 1.2,
                2 => 1.375,
                3 => 1.55,
                4 => 1.725,
                5 => 1.9,
                _ => 1.2
            };

            double paevaneKaloraaž = SBI * aktiivsusKoef;
            Console.WriteLine($"Sinu päevane kaloraaž on umbes {paevaneKaloraaž:F2} kalorit.");

            //------------------------------------------------------------
            Console.WriteLine("\nToiduainete loetelu ja soovitatav kogus (grammides):");
            for (int i = 0; i < tooted.Count; i++)
            {
                double maxKogus = (paevaneKaloraaž / kalorid[i]) * 100; // Kalorid 100g kohta
                Console.WriteLine($"{tooted[i]}: kuni {maxKogus:F0} grammi päevas");
            }






                ////II.1 osa Listid ja sõnastikud
                //List<string> abc = new List<string>();
                //try
                //{
                //    foreach (string rida in File.ReadAllLines (@"..\..\..\ABC.txt"))
                //    { 
                //        abc.Add(rida);
                //    }

                //}
                //catch (Exception)
                //{

                //    Console.WriteLine("Fail ei saa leida!");
                //}
                //foreach (string e in abc)
                //{ 
                //    Console.WriteLine(e);
                //}
                //Console.ReadLine();

                //    //II.2 osa Listid ja sõnastikud
                //    ArrayList arrayList = new ArrayList();
                //arrayList.Add("Esimene");
                //arrayList.Add("Teine");
                //arrayList.Add("Kolmas");
                //Console.WriteLine("Otsing: ");
                //string vas = Console.ReadLine();
                //if (vas != null && arrayList.Contains(vas))
                //{
                //    Console.WriteLine("Otsitav element asub " + arrayList.IndexOf(vas) + ". kohal");
                //}
                //else
                //{ 
                //    Console.WriteLine("Kokku oli " + arrayList.Count + "elemente, vaid otsitav puudub");
                //}
                //arrayList.Clear();
                //arrayList.Insert(1, "Anna");
                //arrayList.Insert(2, "Inna");
                //foreach (string e in arrayList)
                //{
                //    Console.WriteLine(e);
                //}



                ////I.osa Andmetüübid, Alamfunktsioonid, IF
                //string[] nime = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
                ////1.V
                //for (int i = 0; i < nime.Length; i++)
                //{
                //    Console.WriteLine(nime[i]);
                //}
                ////2.v
                //foreach (string nimi in nime)
                //{
                //    Console.WriteLine(nimi);
                //}
                ////3.v
                //int n = 0;
                //while (n < nime.Length)
                //{
                //    Console.WriteLine(nime[n]);
                //    n++;
                //}
                ////4.v
                //do
                //{
                //    Console.WriteLine(nime[n - 1]);
                //    n--;
                //} while (n! > 0); //!


                //for (int i = 0; i < 7; i++)
                //{
                //    int paev_nr = random.Next(-4, 30);
                //    string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
                //    Console.WriteLine(paeva_nimetus);
                //}



                //try
                //{




                //    Console.WriteLine("Mis on sinu pikkus?");
                //    double pikkus = Double.Parse(Console.ReadLine());
                //    string vastus1 = Funktsioonid.Pikkuse_analuus(pikkus);
                //    Console.WriteLine("Sinu pikkus on {0}, sa oled {1}", pikkus, vastus1);
                //}
                //catch (Exception e)
                //{
                //    Console.Write(e.ToString());
                //}



                ////1* Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus (-100,100).
                //int N = random.Next(-100, 101);
                //int M = random.Next(-100, 101);
                //int[] arvud;

                //if (N < M)
                //{
                //    arvud = Funktsioonid.Arvude_massive(N, M);
                //}
                //else
                //{
                //    arvud = Funktsioonid.Arvude_massive(N, M);
                //}
                //foreach (int item in arvud)
                //{
                //    Console.WriteLine(item * item);
                //}


                //// 2* Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende summa, aritmeetiline keskmine ja korrutis.
                //int[] numbrid = new int[5];
                //int summa = 0;
                //int korrutis = 1;
                //for (int i = 0; i < 5; i++)
                //{
                //    Console.Write("Sisesta arv {0}: ", i + 1);
                //    numbrid[i] = int.Parse(Console.ReadLine());
                //    summa += numbrid[i];
                //    korrutis *= numbrid[i];
                //}
                //double keskmine = summa / 5.0;
                //Console.WriteLine("Summa: " + summa);
                //Console.WriteLine("Aritmeetiline keskmine: " + keskmine);
                //Console.WriteLine("Korrutis: " + korrutis);

                //// 3* Küsi viielt kasutajalt nimed ja vanused, salvesta nende andmeid massiivi ning väljasta summaarne vanus, aritmeetiline keskmine, vaanema ja noorema inimeste nimed ja vanused.
                //string[] nimed = new string[5];
                //int[] vanused = new int[5];
                //int vanusteSumma = 0;
                //for (int i = 0; i < 5; i++)
                //{
                //    Console.Write("Sisesta nimi {0}: ", i + 1);
                //    nimed[i] = Console.ReadLine();
                //    Console.Write("Sisesta vanus {0}: ", i + 1);
                //    vanused[i] = int.Parse(Console.ReadLine());
                //    vanusteSumma += vanused[i];
                //}
                //double vanusteKeskmine = vanusteSumma / 5.0;
                //int vanimIndex = Array.IndexOf(vanused, vanused.Max());
                //int noorimIndex = Array.IndexOf(vanused, vanused.Min());
                //Console.WriteLine("Summaarne vanus: " + vanusteSumma);
                //Console.WriteLine("Aritmeetiline keskmine vanus: " + vanusteKeskmine);
                //Console.WriteLine("Vanim inimene: " + nimed[vanimIndex] + ", Vanus: " + vanused[vanimIndex]);
                //Console.WriteLine("Noorim inimene: " + nimed[noorimIndex] + ", Vanus: " + vanused[noorimIndex]);

                //// 4* Ütle kasutajale "Osta elevant ära!". Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab "elevant".
                //string vastuse = "";
                //while (vastuse.ToLower() != "elevant")
                //{
                //    Console.WriteLine("Osta elevant ära!");
                //    vastuse = Console.ReadLine();
                //}
                //Console.WriteLine("Tänan, et ostsid elevandi!");

                //// 5* Mis arv mõtles välja arvuti? Kasuta vähemalt 5 katset, et seda teada.
                //int arvutiArv = random.Next(1, 101);
                //int katsed = 5;
                //bool arvasOige = false;
                //for (int i = 0; i < katsed; i++)
                //{
                //    Console.Write("Mis arv mõtles välja arvuti? (1-100): ");
                //    int kasutajaArv = int.Parse(Console.ReadLine());
                //    if (kasutajaArv == arvutiArv)
                //    {
                //        Console.WriteLine("Õige! Arvuti mõtles välja arvu " + arvutiArv);
                //        arvasOige = true;
                //        break;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Vale arv, proovi uuesti.");
                //    }
                //}
                //if (!arvasOige)
                //{
                //    Console.WriteLine("Sa ei arvanud ära. Arvuti mõtles välja arvu " + arvutiArv);
                //}

                //// 6* Küsi kasutajalt 4 arvu ning väljasta nendest koostatud suurim neliarvuline arv.
                //int[] neliArvu = new int[4];//*Объявляется массив*//
                //for (int i = 0; i < 4; i++)
                //{
                //    Console.Write("Sisesta arv {0}: ", i + 1);
                //    neliArvu[i] = int.Parse(Console.ReadLine());
                //}
                //Array.Sort(neliArvu);
                //Array.Reverse(neliArvu);
                //string suurimArv = string.Join("", neliArvu); //*объединяет все элементы массива*//
                //Console.WriteLine("Suurim võimalik neliarvuline arv: " + int.Parse (suurimArv));
            }
        }
    }
}
