using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_Commandline
{
    class Würfel
    {
        static int Würfeln()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }
    }
}
