using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_Commandline
{
    interface IFeld
    {
        public void handeln(Spieler s);

        public String getTypus();
    }
}
