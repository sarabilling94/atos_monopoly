using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atosprogramm_Monopoly
{
    interface IFeld
    {
        public void handeln(Spieler s);

        public String getTypus();
    }
}
