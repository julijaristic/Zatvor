using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class Firma
    {

        public virtual int Pib { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Ulica { get; set; }
        public virtual IList<Angazuje> FirmaAngazuje { get; set; }
        public virtual IList<Zatvorenik> Zatvorenik { get; set; }
        public virtual IList<TelefonFIrma> Telefon { get; set; }
        public virtual IList<OdgLiceFirme> OdgovornoLice { get; set; }

        public Firma()
        {
            FirmaAngazuje = new List<Angazuje>();
            Zatvorenik = new List<Zatvorenik>();
            Telefon = new List<TelefonFIrma>();
            OdgovornoLice = new List<OdgLiceFirme>();



        }
    }
}
