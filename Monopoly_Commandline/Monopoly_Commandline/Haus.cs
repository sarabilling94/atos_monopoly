namespace Monopoly_Commandline
{
    public class Haus
    {
        private string Name;
        private int Preis;
        private int Miete;
        private Spieler Besitzer;

        public Haus(string name, int preis, int miete, Spieler besitzer)
        {
            Name = name;
            Preis = preis;
            Miete = miete;
            Besitzer = besitzer;
        }

        public void handeln(Spieler spieler)
        {
            //TODO: add this function later
        }
    }
}