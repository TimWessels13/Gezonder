using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gezonder
{
    class Klanten
    {
        public int KlantNaam { get; set; }
        public int KlantAdres { get; set; }
        public int KlantPostcode { get; set; }
        public int KlantPlaats { get; set; }
        public int ArtsNaam { get; set; }
        public int MedicatieNaam { get; set; }
        public int VerzekeraarNaam { get; set; }

        List<Klanten> K = new List<Klanten>();
    }
}
