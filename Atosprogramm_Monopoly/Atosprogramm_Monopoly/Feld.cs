using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atosprogramm_Monopoly
{
    class Feld
    {
        public int position { get; set; }
        public IFeld inhalt { get; set; }

        public void handeln(Spieler s)
        {
            inhalt.Handeln(s);
        }

    }
}
