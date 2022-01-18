﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atosprogramm_Monopoly
{
    class Gefaengnis : IFeld
    {
        public int AnzTage { get; set; }
        public Dictionary<string, int> gefängnisLog;

        public Gefaengnis(int anzTage)
        {
            this.AnzTage = anzTage;
            gefängnisLog = new Dictionary<string, int>();
        }

        public void Handeln(Spieler spieler)
        {
            if (!gefängnisLog.ContainsKey(spieler.Figur.Bezeichnung))
            {
                gefängnisLog.Add(spieler.Figur.Bezeichnung, AnzTage);
                gefängnisLog[spieler.Figur.Bezeichnung]--;
            }
            else
            {
                gefängnisLog[spieler.Figur.Bezeichnung]--;
                if (gefängnisLog[spieler.Figur.Bezeichnung] == 0)
                {
                    spieler.inPrison = false;
                    gefängnisLog.Remove(spieler.Figur.Bezeichnung);
                }
            }

        }

        public string getTypus()
        {
            return "gefaengnis";
        }
    }
}
