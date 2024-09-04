using System;
using System.Collections.Generic;

namespace TARpv23_CSharp
{

    public enum Eluviis
    {
        Istuv,
        Vähem,      
        Möödukas,  
        Kõrge,     
        Väga_kõrge   
    }

    public enum Sugu
    {
        Mees,
        naine
    }

    internal class Inimene
    {

        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public double Kaal { get; set; } 
        public double Pikkus { get; set; }
        public int Sugu { get; set; } 


        public Inimene() { }

        public Inimene(string nimi)
        {
            Nimi = nimi;
        }

        public Inimene(string nimi, int vanus = 2)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public double HB_vorrand(Eluviis eluviis)
        {
            double SBI = 0;


            if (Sugu == 0)
            {
                SBI = 66 + (13.7 * Kaal) + (5 * Pikkus) - (6.8 * Vanus);
            }
            else if (Sugu == 1)
            {
                SBI = 655 + (9.6 * Kaal) + (1.8 * Pikkus) - (4.7 * Vanus);
            }
            else
            {
                throw new ArgumentException("Некорректное значение для пола. Ожидалось: 0 (мужчина) или 1 (женщина).");
            }

            switch (eluviis)
            {
                case Eluviis.Istuv:
                    SBI *= 1.2;
                    break;
                case Eluviis.Vähem:
                    SBI *= 1.375;
                    break;
                case Eluviis.Möödukas:
                    SBI *= 1.55;
                    break;
                case Eluviis.Kõrge:
                    SBI *= 1.725;
                    break;
                case Eluviis.Väga_kõrge:
                    SBI *= 1.9;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(eluviis), "Неверный выбор уровня активности.");
            }

            return SBI;
        }
    }
}
