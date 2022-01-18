using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atosprogramm_Monopoly
{
    public class Spieler
    {
        public int id { get; set; }
        public Figur figur { get; set; }
        public int kontostand { get; set; }
        public bool inPrison { get; set; }

        public Position position { get; set; }
        public List<Haus> houseList { get; set; }


        public Spieler(int id, Figur figur, int kontostand, Position position)
        {
            this.id = id;
            this.figur = figur;
            this.kontostand = kontostand;
            this.position = position;
            houseList = new List<Haus>();
            inPrison = false;

        }
    }
}
