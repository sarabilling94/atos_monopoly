using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_Commandline
{
    public class Spieler
    {
        public Figur Figur { get; set; }
        public int Kontostand { get; set; }

        public int Position { get; set; }

        public Spieler(Figur figur, int kontostand, int position)
        {
            this.Figur = figur;
            this.Kontostand = kontostand;
            this.Position = position;
        }  
    }
}
