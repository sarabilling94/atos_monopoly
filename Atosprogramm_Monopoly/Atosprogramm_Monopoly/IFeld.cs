using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atosprogramm_Monopoly
{
    public interface IFeld
    {
        void Handeln(Spieler s);
        
        string getTypus();
    }
}
