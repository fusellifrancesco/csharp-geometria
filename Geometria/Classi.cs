using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria {
    public class Rettangolo {
        public string nomeRettangolo;
        public int baseRettangolo;
        public int altezzaRettangolo;

        // METODI
        public int CalcolaArea() {
            return baseRettangolo * altezzaRettangolo;
        }

        public int CalcolaPerimetro() {
            return (baseRettangolo + altezzaRettangolo) * 2;
        }

        public void StampaRettangolo() {
            Console.WriteLine("--" + nomeRettangolo + "--");
            Console.WriteLine("Base: " + baseRettangolo);
            Console.WriteLine("Altezza: " + altezzaRettangolo);
            Console.WriteLine("Perimetro: " + CalcolaPerimetro() + " cm");
            Console.WriteLine("Area: " + CalcolaArea() + " cm2");
        }

    }
}
