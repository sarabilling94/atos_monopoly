using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atosprogramm_Monopoly
{
    public class Spieler
    {
        public Figur Figur { get; set; }
        public int Kontostand { get; set; }
        public bool inPrison { get; set; }

        public int Position { get; set; }
        public List<Haus> houseList { get; set; }


        public Spieler(Figur figur, int kontostand, int position)
        {
            this.Figur = figur;
            this.Kontostand = kontostand;
            this.Position = position;
            houseList = new List<Haus>();
            inPrison = false;

        }
    }
}
