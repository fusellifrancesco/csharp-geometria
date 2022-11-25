using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria {
    public class Rettangolo {
        public int baseRettangolo;
        public int altezzaRettangolo;

        // METODI
        public int calcolaArea() {
            return baseRettangolo * altezzaRettangolo;
        }

        public int calcolaPerimetro() {
            return (baseRettangolo + altezzaRettangolo) * 2;
        }

    }
}
