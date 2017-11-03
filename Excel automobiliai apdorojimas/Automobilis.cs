using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_automobiliai_apdorojimas
{
    public class Automobilis
    {
        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }
        public int Rida { get; private set; }

        public Automobilis(string marke, string modelis, int metai, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Rida = rida;
        }
    }
}
