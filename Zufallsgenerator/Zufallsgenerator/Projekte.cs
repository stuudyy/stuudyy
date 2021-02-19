using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallsgenerator
{
    public class Projekte
    {
        private int nummer;
        private string projekt;

        private static int autonum = 1;

        public Projekte() { }

        public Projekte(string projekt)
        {
            nummer = autonum;
            autonum++;

            this.projekt = projekt;
            
        }

        public int Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }

        public string Projekt
        {
            get { return projekt; }
            set { projekt = value; }
        }

        public static int Autonum
        {
            get { return autonum; }
            set { autonum = value; }
        }


    }
}
