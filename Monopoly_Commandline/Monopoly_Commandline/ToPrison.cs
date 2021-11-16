using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Monopoly_Commandline
{
    class ToPrison:IFeld
    {
        public int PrisonIndex { get; set; }

        public ToPrison(int inPrisonIndex)
        {
            this.PrisonIndex = inPrisonIndex;
        }
        public void handeln(Spieler s)
        {
            s.Position = PrisonIndex;
            s.inPrison = true;
        }

        public string getTypus()
        {
            return "Auf dem Weg ins Gefängnis";
        }
    }
}
