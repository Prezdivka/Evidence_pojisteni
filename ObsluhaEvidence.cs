using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojisteni_opravena
{
    internal class ObsluhaEvidence
    {
        /// <summary>
        /// Třída nabízející výběr možných operací pro práci s evidencí pojištěných.
        /// Samotné metody pro tyto operace jsou potom ve třídě EvidencePojistenych.cs.
        /// </summary>
        public void Uvod()
        {
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
        }
    }
}
