using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atosprogramm_Monopoly
{
    public class Haus : IFeld
    {
        public string Name { get; set; }
        public int Preis { get; set; }
        public int Miete { get; set; }
        public Spieler Besitzer { get; set; }

        public bool gekauft { get; set; }

        public Haus(string inName, int inPreis, int inMiete)
        {
            this.Name = inName;
            this.Preis = inPreis;
            this.Miete = inMiete;
            this.gekauft = false;
        }

        public void handeln(Spieler spieler)
        {
            if (!gekauft)
            {
                Console.WriteLine("Möchtes du " + Name + " kaufen für: " + Preis + " ?");
                Console.ReadKey();
                gekauft = true;
            }
            else
            {
                Console.WriteLine("Du musst leider: " + Miete + " bezahlen :(");
            }
        }

        public String getTypus()
        {
            return Name;
        }
    }
}
