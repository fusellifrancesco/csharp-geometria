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
        public int CalcolaArea() {
            return baseRettangolo * altezzaRettangolo;
        }

        public int CalcolaPerimetro() {
            return (baseRettangolo + altezzaRettangolo) * 2;
        }

    }
}
