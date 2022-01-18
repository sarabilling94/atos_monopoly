using System;
using System.Collections.Generic;
using System.Threading;

namespace Atosprogramm_Monopoly
{
    internal class Spielfeld
    {
        public List<Feld> spielFeld { get; set; }
        public LinkedList<Spieler> spielerList { get; set; }

        public Spielfeld(LinkedList<Spieler> inSpielerList)
        {
            this.spielerList = inSpielerList;
        }

        public void bewegen()
        {
            while (true)
            {
                var currentSpieler = spielerList.First;
                Console.WriteLine("Ursprünglicher Kontostand: " + currentSpieler.Value.kontostand);
                spielerList.RemoveFirst();
                spielerList.AddLast(currentSpieler);
                wuerfeln(currentSpieler.Value);
            }
        }

        private void wuerfeln(Spieler spi)
        {
            int result1 = Wuerfel.Wuerfeln();
            int result2 = Wuerfel.Wuerfeln();
            Console.WriteLine("Würfeln?");
            Console.ReadKey();
            Thread.Sleep(500);
            Console.WriteLine(result1);
            Console.WriteLine("2. Würfel");
            Console.ReadKey();
            Thread.Sleep(500);
            Console.WriteLine(result2);
            if (spielFeld[spi.position].inhalt.getTypus().Equals("gefaengnis") && spi.inPrison)
            {
                spielFeld[spi.position].handeln(spi);
            }
            else
            {
                for (int i = 0; i < (result1 + result2); i++)
                {
                    if (spi.position == spielFeld.Count - 1)
                    {
                        spi.position = 0;
                        spielFeld[0].handeln(spi);
                    }
                    else
                    {
                        spi.position += 1;
                    }
                }

                if (!spielFeld[spi.position].inhalt.getTypus().Equals("startfeld"))
                {
                    spielFeld[spi.position].handeln(spi);
                }
                Console.WriteLine("Endgültiger Kontostand: " + spi.kontostand);
            }

            Console.WriteLine("Der Spieler ist jetzt bei: " + spielFeld[spi.position].inhalt.getTypus());
        }
    }
}
