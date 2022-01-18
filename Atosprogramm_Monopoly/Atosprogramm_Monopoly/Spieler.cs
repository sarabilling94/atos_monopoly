using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atosprogramm_Monopoly
{
    public class Spieler
    {
        public Figur figur { get; set; }
        public int kontostand { get; set; }
        public bool inPrison { get; set; }

        public int position { get; set; }
        public List<Haus> houseList { get; set; }


        public Spieler(Figur figur, int kontostand, int position)
        {
            this.figur = figur;
            this.kontostand = kontostand;
            this.position = position;
            houseList = new List<Haus>();
            inPrison = false;

        }
    }
}
