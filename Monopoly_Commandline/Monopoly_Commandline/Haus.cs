using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_Commandline
{
    class Haus
    {
        public string Name { get; set; }
        public int Preis { get; set; }
        public int Miete { get; set; }
        public Spieler Besitzer { get; set; }
    }
}
