using System;
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
            if (!gefängnisLog.ContainsKey(spieler.figur.Bezeichnung))
            {
                gefängnisLog.Add(spieler.figur.Bezeichnung, AnzTage);
                gefängnisLog[spieler.figur.Bezeichnung]--;
            }
            else
            {
                gefängnisLog[spieler.figur.Bezeichnung]--;
                if (gefängnisLog[spieler.figur.Bezeichnung] == 0)
                {
                    spieler.inPrison = false;
                    gefängnisLog.Remove(spieler.figur.Bezeichnung);
                }
            }

        }

        public string getTypus()
        {
            return "gefaengnis";
        }
    }
}
