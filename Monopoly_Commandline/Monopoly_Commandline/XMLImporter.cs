using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Monopoly_Commandline
{
    class XMLImporter
    {
        public List<Haus> loadHouses()
        {
            var ele = new XmlDocument();
            ele.Load("../../../../HausData.xml");
            XmlNode root = ele.LastChild;
            List<Haus> retList = new List<Haus>();
            for (var i = 0; i < root.ChildNodes.Count; i++)
            {
                var u = root.ChildNodes[i].ChildNodes;
                string name =u[0].InnerText;
                int preis = Int32.Parse(u[1].InnerText);
                int miete = Int32.Parse(u[2].InnerText);
                retList.Add(new Haus(name,preis,miete));
            }

            return retList;
        }

    }
}
