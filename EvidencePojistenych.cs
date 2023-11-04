using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Evidence_pojisteni_opravena
{
    /// <summary>
    /// Třída sloužící k operacím s evidencí (přidání pojištěnce, vyhledání pojištěnce a výpis uložených pojištěnců).
    /// </summary>
    internal class EvidencePojistenych
    {
        private List<Pojistenec> list;

        public EvidencePojistenych()
        {
            list = new List<Pojistenec>();
        }
        /// <summary>
        /// Přidá nového pojištěného včetně jeho věku a telefonního čísla do databáze.
        /// </summary>
        public void PridejPojistence()
        {
            Console.WriteLine();
            Console.WriteLine("Zadejte křestní jméno pojištěného: ");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Chyba v zadání, zadejte křestní jméno znovu:");
            }

            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Chyba v zadání, zadejte příjmení znovu:");
            }

            Console.WriteLine("Zadejte věk pojištěného: ");
            int vek;
            while ((!int.TryParse(Console.ReadLine(), out vek)) || (vek <= 0))
            {
                Console.WriteLine("Věk by měl být číslo větší než nula. Zadejte prosím znovu:");
            }

            Console.WriteLine("Zadejte telefonní číslo pojištěného: ");
            string telefonniCislo;
            while (string.IsNullOrWhiteSpace(telefonniCislo = Console.ReadLine()))
            {
                Console.WriteLine("Chyba v zadání, zadejte telefonní číslo znovu:");
            }

            list.Add(new Pojistenec(jmeno, prijmeni, vek, telefonniCislo));
            Console.WriteLine("Data byla uložena.");
        }
        /// <summary>
        /// Vypíše všechny pojištěnce uložené v databázi.
        /// </summary>
        public void VypisPojistence()
        {
            Console.WriteLine();
            if (list.Count == 0)
            {
                Console.WriteLine("V databázi nejsou vloženi žádní pojištěnci.");
            }
            else
            {
                foreach (var pojistenci in list)
                {
                    Console.WriteLine(pojistenci);
                }
            }


        }
        /// <summary>
        /// Vyhledá konkrétního pojištěného podle jména a příjmení.
        /// </summary>
        public void VyhledejPojisteneho()
        {
            Console.WriteLine();
            Console.WriteLine("Zadejte křestní jméno pojištěného: ");
            string hledaneJmeno = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string hledanePrijmeni = Console.ReadLine().ToLower().Trim();

            foreach (var pojistenci in list)
            {
                if ((hledaneJmeno == pojistenci.Jmeno.ToLower()) && (hledanePrijmeni == pojistenci.Prijmeni.ToLower()))
                {
                    Console.WriteLine(pojistenci);
                    return;
                }
            }
            Console.WriteLine("Pojištěnec nebyl nalezen.");
        }
    }
}

