﻿using System;
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

        public void handeln(Spieler spieler)
        {
            spieler.Kontostand += Gewinn;

        }
        public String getTypus()
        {
            return "startfeld";
        }

    }
}
