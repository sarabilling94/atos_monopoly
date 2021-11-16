using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_Commandline
{
    class Spieler
    {
        private Figur Figur;
        private int Kontostand;

        private int Position;

        public Spieler(Figur figur, int kontostand, int position)
        {
            this.Figur = figur;
            this.Kontostand = kontostand;
            this.Position = position;
        }  
    }
}
