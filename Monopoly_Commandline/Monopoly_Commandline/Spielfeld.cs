using System;
using System.Collections.Generic;
using System.Threading;

namespace Monopoly_Commandline
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
                Console.WriteLine("Ursprünglicher Kontostand: " + currentSpieler.Value.Kontostand);
                spielerList.RemoveFirst();
                spielerList.AddLast(currentSpieler);
                würfeln(currentSpieler.Value);
            }
        }

        private void würfeln(Spieler spi)
        {
            int result1 = Würfel.Würfeln();
            int result2 = Würfel.Würfeln();
            Console.WriteLine("Würfeln?");
            Console.ReadKey();
            Thread.Sleep(500);
            Console.WriteLine(result1);
            Console.WriteLine("2. Würfel");
            Console.ReadKey();
            Thread.Sleep(500);
            Console.WriteLine(result2);
            if (spielFeld[spi.Position].inhalt.getTypus().Equals("gefaengnis") && spi.inPrison)
            {
                spielFeld[spi.Position].handeln(spi);
            }
            else
            {
                for (int i = 0; i < (result1 + result2); i++)
                {
                    if (spi.Position == spielFeld.Count - 1)
                    {
                        spi.Position = 0;
                        spielFeld[0].handeln(spi);
                    }
                    else
                    {
                        spi.Position += 1;
                    }
                }

                if (!spielFeld[spi.Position].inhalt.getTypus().Equals("startfeld"))
                {
                    spielFeld[spi.Position].handeln(spi);
                }
                Console.WriteLine("Endgültiger Kontostand: " + spi.Kontostand);
            }

            Console.WriteLine("Der Spieler ist jetzt bei: " + spielFeld[spi.Position].inhalt.getTypus());
        }
    }
}