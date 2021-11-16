using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_Commandline
{
    class Feld
    {
        public int position { get; set; }
        public IFeld inhalt { get; set; }

        public void handeln(Spieler s)
        {
            inhalt.handeln(s);
        }


    }
}
