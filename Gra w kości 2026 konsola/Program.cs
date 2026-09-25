using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_kości_2026_konsola
{
    public class Kosc
    {
        public static int LiczbaInstancji = 0;
        public static string[] NazwyPlikow = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };
        public int LiczbaOczek;
        public int IdentyfikatorPliku;
        public bool CzyDostepna;
        private static Random random = new Random();
        public Kosc(int wylosowanaWartosc)
        {
            if (wylosowanaWartosc < 1 || wylosowanaWartosc > 6)
            {
                LiczbaOczek = 0;
                IdentyfikatorPliku = 0;
            }
            else
            {
                LiczbaOczek = wylosowanaWartosc;
                IdentyfikatorPliku = wylosowanaWartosc;
            }

            CzyDostepna = true;
            LiczbaInstancji++;
        }
        public Kosc()
        {
            int wylosowanaWartosc = random.Next(1, 7);
            LiczbaOczek = wylosowanaWartosc;
            IdentyfikatorPliku = wylosowanaWartosc;
            CzyDostepna = true;
            LiczbaInstancji++;
        }
        public void RzucKoscia()
        {
            if (CzyDostepna)
            {
                int wylosowanaWartosc = random.Next(1, 7);
                LiczbaOczek = wylosowanaWartosc;
                IdentyfikatorPliku = wylosowanaWartosc;
            }
        }
        public void ZablokujKosc()
        {
            CzyDostepna = false;
        }
        public string DajSlownaWartosc()
        {
            switch (LiczbaOczek)
            {
                case 1: return "jeden";
                case 2: return "dwa";
                case 3: return "trzy";
                case 4: return "cztery";
                case 5: return "pięć";
                case 6: return "sześć";
                default: return "zero";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kosc kosc1 = new Kosc();
            Console.Write("Podaj wartość oczek dla drugiej kości (1-6): ");
            int wpisanaWartosc = Int32.Parse(Console.ReadLine());
            Kosc kosc2 = new Kosc(wpisanaWartosc);
            kosc1.RzucKoscia();
            Console.WriteLine("Liczba Instancji: " + Kosc.LiczbaInstancji);
            Console.WriteLine("Pierwsza kość (konstruktor bezargumentowy): " + kosc1.LiczbaOczek + ", " + kosc1.DajSlownaWartosc() + ", " + Kosc.NazwyPlikow[kosc1.LiczbaOczek]);
            Console.WriteLine("Druga kość (konstruktor jednoargumentowy): " + kosc2.LiczbaOczek + ", " + kosc2.DajSlownaWartosc() + ", " + Kosc.NazwyPlikow[kosc2.LiczbaOczek]);
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
