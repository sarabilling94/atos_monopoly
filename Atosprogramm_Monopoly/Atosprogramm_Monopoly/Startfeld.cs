using System;
using System.Collections.Generic;
using System;

namespace Atosprogramm_Monopoly
{
    class Startfeld : IFeld
    {
        public int Gewinn { get; set; }

        public Startfeld(int inGewinn)
        {
            this.Gewinn = inGewinn;
        }

        public void Handeln(Spieler spieler)
        {
            spieler.kontostand += Gewinn;

        }
        public String getTypus()
        {
            return "startfeld";
        }

    }
}
