using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    internal class Funktsioonid
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere kallis {0}", nimi);
        }

        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }

        public static double Arvuta(string operatsion, int arv1, int arv2)
        {
            int Arve = 0;
            if (operatsion == "+")
            {
                Arve = arv1 + arv2;
            }
            else if (operatsion == "-")
            {
                Arve = arv1 - arv2;
            }
            else if (operatsion == "/")
            {
                Arve = arv1 / arv2;
            }
            else if (operatsion == "*")
            {
                Arve = arv1 * arv2;
            }
            return Arve;
        }
    }
}
