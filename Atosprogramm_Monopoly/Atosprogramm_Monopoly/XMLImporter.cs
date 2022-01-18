using System;
using System.Collections.Generic;
using System.Xml;

namespace Atosprogramm_Monopoly
{
    internal class XMLImporter
    {
        public static List<Feld> LoadFields()
        {
            var ele = new XmlDocument();
            int prisonIndex = -1;
            //pfad für xml dokument
            ele.Load("../../../../HausData.xml");
            //nimmt houseList
            XmlNode root = ele.LastChild;
            List<Feld> retList = new List<Feld>();

            for (var i = 0; i < root.ChildNodes.Count; i++)
            {
                var u = root.ChildNodes[i].ChildNodes;
                Feld tempFeld = new Feld();
                switch (root.ChildNodes[i].Name)
                {
                    case "startfeld":
                        int gewinn = Int32.Parse(u[0].InnerText);
                        tempFeld.inhalt = new Startfeld(gewinn);
                        break;

                    case "haus":
                        string name = u[0].InnerText;
                        int preis = Int32.Parse(u[1].InnerText);
                        int miete = Int32.Parse(u[2].InnerText);
                        tempFeld.inhalt = new Haus(name, preis, miete);
                        break;

                    case "gefaengnis":
                        int anzTage = Int32.Parse(u[0].InnerText);
                        tempFeld.inhalt = new Gefaengnis(anzTage);
                        prisonIndex = retList.Count;
                        break;
                    case "toPrison":
                        tempFeld.inhalt = new ToPrison(prisonIndex);
                        break;

                    default: break;
                }
                retList.Add(tempFeld);
            }
            return retList;
        }
    }
}
