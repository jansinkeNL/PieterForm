using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieterForm
{
    class Afbeelding
    {
        public Int64 id { get; set; }
        public int parentCategorie { get; set; }
        public string afbeelding { get; set; }
        public int volgorde { get; set; }
        public string audio { get; set; }
        public string naam { get; set; }
    }
}
