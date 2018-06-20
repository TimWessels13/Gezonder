using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gezonder
{
    class Klanten
    {
        public Klanten(string KlantNaam, string KlantAdres, string KlantPostcode, string KlantPlaats, int ArtsId, int MedicatieId, int VerzekeraarId)
        {
        }

        public string KlantNaam { get; set; }
        public string KlantAdres { get; set; }
        public string KlantPostcode { get; set; }
        public string KlantPlaats { get; set; }
        public int ArtsId { get; set; }
        public int MedicatieId { get; set; }
        public int VerzekeraarId { get; set; }

        public static void Main(string[] args)
        {
            List<Klanten> K = new List<Klanten>();
            K.Add(new Klanten("Pietje Bel", "Pesterstraat 13", "1873 CS", "Veenendaal", 1, 1, 1));
        }
    }
}
