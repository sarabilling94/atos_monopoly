using System;
using System.Collections.Generic;
using System.Text;

namespace Atosprogramm_Monopoly
{
    class Wuerfel
    {
        public static int Wuerfeln()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }
    }
}
