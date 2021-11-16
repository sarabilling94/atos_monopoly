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

        public Haus(string inName, int inPreis, int inMiete)
        {
            this.Name = inName;
            this.Preis = inPreis;
            this.Miete = inMiete;
        }
    }
}
