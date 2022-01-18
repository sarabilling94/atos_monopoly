using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Atosprogramm_Monopoly
{
    class ToPrison : IFeld
    {
        public int PrisonIndex { get; set; }

        public ToPrison(int inPrisonIndex)
        {
            this.PrisonIndex = inPrisonIndex;
        }
        public void Handeln(Spieler s)
        {
            s.position.setPosition(PrisonIndex);
            Console.WriteLine("Direkt ins Gefängnis!");
            s.inPrison = true;
        }

        public string getTypus()
        {
            return "Auf dem Weg ins Gefängnis";
        }
    }
}
