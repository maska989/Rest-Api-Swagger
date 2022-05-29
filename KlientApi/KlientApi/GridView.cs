using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientApi
{
    internal class GridView
    {

        public Guid gp;
        public Guid go;
        public string pokoj { get; set; }
        public string osoba { get; set; }


        public GridView(Guid GP, Guid GO,string SP, string SO)
        {
            gp = GP;
            go = GO;
            pokoj = SP;
            osoba = SO;



        }
    }
}
