using Evidence_pojisteni_opravena;

namespace Evidence_pojisteni_opravena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObsluhaEvidence obsluha = new ObsluhaEvidence();
            EvidencePojistenych mojeDatabaze = new EvidencePojistenych();

            Console.WriteLine("------------------------------\nEvidence pojištěných\n------------------------------");
            Console.WriteLine();

            char volba = '0';

            while (volba != '4')
            {
                obsluha.Uvod();
                volba = Console.ReadKey().KeyChar;

                switch (volba)
                {
                    case '1':
                        mojeDatabaze.PridejPojistence();
                        break;
                    case '2':
                        mojeDatabaze.VypisPojistence();
                        break;
                    case '3':
                        mojeDatabaze.VyhledejPojisteneho();
                        break;
                    case '4':
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Program je ukončen.");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Zadali jste špatné číslo, musíte zadat od 1 do 4.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Pokračujte stisknutím klávesy Enter.");
                Console.ReadLine();
            }
        }
    }
}