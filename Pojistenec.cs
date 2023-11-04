using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojisteni_opravena
{
    /// <summary>
    /// Třída popisující všechny vlastnosti pojištěnce.
    /// </summary>
    internal class Pojistenec
    {
        private string jmeno;
        private string prijmeni;
        private int vek;
        private string telefonniCislo;

        public Pojistenec(string jmeno, string prijmeni, int vek, string telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public string TelefonniCislo { get; private set; }
        public override string ToString()
        {
            return String.Format($"{Jmeno} {Prijmeni}, {Vek} let, telefon: {TelefonniCislo}");
        }
    }


}
