using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gezonder
{
    class Klanten
    {
        public string KlantNaam { get; set; }
        public string KlantAdres { get; set; }
        public string KlantPostcode { get; set; }
        public string KlantPlaats { get; set; }
        public string ArtsNaam { get; set; }
        public string MedicatieNaam { get; set; }
        public string VerzekeraarNaam { get; set; }

       
       
   

        public Klanten(string KlantNaam, string KlantAdres, string KlantPostcode, string KlantPlaats, string ArtsNaam, string MedicatieNaam, string  VerzekeraarNaam)
        {
            this.KlantNaam = KlantNaam;
            this.KlantAdres = KlantAdres;
            this.KlantPostcode = KlantPostcode;
            this.KlantPlaats = KlantPlaats;
            this.ArtsNaam = ArtsNaam;
            this.MedicatieNaam = MedicatieNaam;
            this.VerzekeraarNaam = VerzekeraarNaam;
            
        }

       
    }
}
