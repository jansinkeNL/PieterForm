using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieterForm
{
    class Categorie
    {
        public int parent { get; set; }
        public int id { get; set; }
        public String naam { get; set; }
        public bool uitgeschakeld { get; set; }
        public string afbeelding { get; set; }
        public int volgorde { get; set; }
    }
}
