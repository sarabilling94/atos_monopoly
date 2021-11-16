using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_Commandline
{
    class Logik
    {
        public Spielfeld spielfeld { get; private set; }


        public Logik()
        {
            Spieler mert = new Spieler(new Figur("hase"), 2000, 0);
            LinkedList<Spieler> spielerList = new LinkedList<Spieler>();
            spielerList.AddFirst(mert);
            spielfeld = new Spielfeld(spielerList);
            spielfeld.spielFeld = XMLImporter.LoadFields();
            spielfeld.bewegen();
        }

    }
}
