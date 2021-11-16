using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_Commandline
{
    class Spieler
    {
        private Figur Figur { get; set; }
        private int Kontostand { get; set; }

        private int Position { get; set; }

        public Spieler(Figur figur, int kontostand, int position)
        {
            this.Figur = figur;
            this.Kontostand = kontostand;
            this.Position = position;
        }  
    }
}
