using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_Commandline
{
    class Startfeld:IFeld
    {
        public int Gewinn { get; set; }

        public Startfeld(int inGewinn)
        {
            this.Gewinn = inGewinn;
        }

        public void handeln(Spieler spieler)
        {
            spieler.Kontostand += Gewinn;

        } public String getTypus()
        {
            return "startfeld";
        }

    }
}
